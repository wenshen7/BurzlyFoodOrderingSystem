Imports System.Text
Public Class frmReservationUpdate

    Private db As New BurzlyDataContext



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Reservation' table. You can move, or remove it, as needed.
        ' Me.ReservationTableAdapter.Fill(Me.BurzlyDBDataSet.Reservation)
        db = New BurzlyDataContext()
        dgvReservation.DataSource = db.Reservations


        txtId.Text = ""
        txtReserveName.Text = ""
        txtReserveContact.Text = ""
        ReserveDateDateTimePicker.Text = ""
        mskReserveTime.Text = ""
        txtReservePax.Text = ""
        txtReserveTable.Text = ""
        lblReserveStatus.Text = ""


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        db = New BurzlyDataContext()
        If txtSeacrh.Text = "" Then

            MessageBox.Show("record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim searchEmp = (From em In db.Reservations
                Where em.reserveId = txtSeacrh.Text Or em.reserveName = txtSeacrh.Text Or em.reserveContact = txtSeacrh.Text).ToList()(0)
                txtId.Text = searchEmp.reserveId
                txtReserveName.Text = searchEmp.reserveName
                txtReserveContact.Text = searchEmp.reserveContact
                ReserveDateDateTimePicker.Text = CStr(searchEmp.reserveDate)
                mskReserveTime.Text = searchEmp.reserveTime.ToString
                txtReservePax.Text = CStr(searchEmp.reservePax)
                txtReserveTable.Text = CStr(searchEmp.reserveTable)
                lblReserveStatus.Text = searchEmp.reserveStatus

                txtSeacrh.Clear()
                txtSeacrh.Focus()
            Catch ex As Exception
                MessageBox.Show("Data not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If


        db.SubmitChanges()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim db As New BurzlyDataContext

        If txtId.Text = "" Then
            MessageBox.Show("record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing

            Dim updateRes = (From res In db.Reservations
                           Where res.reserveId = txtId.Text).ToList()(0)

            If IsNumeric(txtReserveName.Text) Or txtReserveName.Text = "" Then
                err.AppendLine("error name")
                ctr = If(ctr, txtReserveName)
            End If

            If txtReserveContact.Text = "" Or IsNumeric(txtReserveContact.Text) = False Then
                err.AppendLine("error contact")
                ctr = If(ctr, txtReserveContact)
            End If

            If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
                err.AppendLine("error pax")
                ctr = If(ctr, txtReservePax)
            End If

            If Not mskReserveTime.MaskFull Then
                err.AppendLine("error time")
                ctr = If(ctr, mskReserveTime)
            End If

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ctr.Focus()
                Return
            Else

                With updateRes
                    .reserveId = txtId.Text
                    .reserveName = txtReserveName.Text
                    .reserveContact = txtReserveContact.Text
                    .reserveContact = txtReserveContact.Text
                    .reserveDate = CType(CStr(ReserveDateDateTimePicker.Text), Date?)
                    .reserveTime = TimeSpan.Parse(mskReserveTime.Text)
                    .reservePax = CType(CStr(txtReservePax.Text), Integer?)
                    .reserveTable = CType(CStr(txtReserveTable.Text), Integer?)
                    .reserveStatus = lblReserveStatus.Text
                End With



                Dim result = (From o In db.Reservations
                           Where o.reserveTime = updateRes.reserveTime And
                           o.reserveTime IsNot Nothing And o.reserveDate = updateRes.reserveDate And o.reserveTable = updateRes.reserveTable And o.reserveId <> txtId.Text).Count

                If result > 0 Then
                    MessageBox.Show("Time and table already booked, please select another time and table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    db.SubmitChanges()
                    MessageBox.Show("Data updated sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgvReservation.DataSource = db.Reservations
                    db = New BurzlyDataContext()
                End If

            End If
        End If
    End Sub


    Private Sub txtSeacrh_TextChanged(sender As Object, e As EventArgs) Handles txtSeacrh.TextChanged
        SeacrhData()

    End Sub

    Private Sub SeacrhData()

        Dim db As New BurzlyDataContext()
        Dim rs = From o In db.Reservations
                 Where o.reserveName.Contains(txtSeacrh.Text) Or o.reserveId.Contains(txtSeacrh.Text) Or o.reserveContact.Contains(txtSeacrh.Text)
        dgvReservation.DataSource = rs

    End Sub

    Private Sub dgvReservation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservation.CellContentClick
        Dim db As New BurzlyDataContext()
    End Sub
End Class