Imports System.Text

Public Class frmReservationInsert


    Friend intTableNum As Integer
    Friend r As New Reservation
    Friend db As New BurzlyDataContext


    Friend err As New StringBuilder()
    Friend ctr As Control = Nothing


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim nextEmpId = (From emp In db.Reservations
                        Order By emp.reserveId Descending
                        Select emp.reserveId).Max
        Dim startIndex As String = nextEmpId.Substring(0, 1)
        Dim leftIndex As Integer = CInt(nextEmpId.Substring(1, 4))
        Dim addedIndex As Integer = leftIndex + 1
        Dim generatedResult As String = (startIndex & addedIndex.ToString("0000"))

        txtReserveId.Text = generatedResult


        txtReserveName.Text = ""
        txtReserveContact.Text = ""
        ReserveDateDateTimePicker.Text = ""
        mskReserveTime.Text = ""
        txtReservePax.Text = ""
        lblReserveTable.Text = ""
        lblReserveStatus.Text = ""

        radTable.Checked = False
        radTable2.Checked = False
        radTable3.Checked = False
        radTable4.Checked = False
        radTable5.Checked = False
        radTable6.Checked = False
        radTable7.Checked = False
        radTable8.Checked = False



    End Sub


    Private Sub btnAddSave_Click(sender As Object, e As EventArgs) Handles btnAddSave.Click

        If txtReserveName.Text = "" Or IsNumeric(txtReserveName.Text) Then
            err.AppendLine("Error name")
            ctr = If(ctr, txtReserveName)
        End If

        If txtReserveContact.Text = "" Or IsNumeric(txtReserveContact.Text) = False Then
            err.AppendLine("Error contact")
            ctr = If(ctr, txtReserveContact)
        End If

        If mskReserveTime.Text = Nothing Then
            err.AppendLine("Error time")
            ctr = If(ctr, mskReserveTime)
        End If

        If Not mskReserveTime.MaskFull Then
            err.AppendLine("Error time")
            ctr = If(ctr, mskReserveTime)
        End If

        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Error pax")
            ctr = If(ctr, txtReservePax)
        End If

        If r.reserveId = txtReserveId.Text Then
            err.AppendLine("Duplicate id")
            ctr = If(ctr, txtReserveId)
        End If

        If err.Length > 0 Then
            MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            err.Clear()
            ctr.Focus()
            Return
        Else
            With r
                .reserveId = txtReserveId.Text
                .reserveName = txtReserveName.Text
                .reserveContact = txtReserveContact.Text
                .reserveDate = CType(ReserveDateDateTimePicker.Text, Date?)
                .reserveTime = TimeSpan.Parse(mskReserveTime.Text)
                .reservePax = CType(txtReservePax.Text, Integer?)
                .reserveTable = CType(lblReserveTable.Text, Integer?)
                .reserveStatus = lblReserveStatus.Text
            End With

            Dim db As New BurzlyDataContext


            Dim result = (From o In db.Reservations
                         Where o.reserveTime = r.reserveTime And
                         o.reserveTime IsNot Nothing And o.reserveDate = r.reserveDate And o.reserveTable = r.reserveTable And o.reserveId = r.reserveId).Count

            If result > 0 Then
                MessageBox.Show("Time and table already booked, please select another time and table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                db.Reservations.InsertOnSubmit(r)
                db.SubmitChanges()
                MessageBox.Show("Insert data sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
            End If

        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub TableNum(intTableNum As Integer)

        lblReserveTable.Text = lblReserveTable.Text & intTableNum.ToString
        r.reserveTable = CType(intTableNum.ToString, Integer?)

    End Sub



    Private Sub radTable_CheckedChanged(sender As Object, e As EventArgs) Handles radTable.Click

        TableNum(1)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"

        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 4 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("maximun seat only 1 to 4 persons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If

    End Sub

    Private Sub radTable2_CheckedChanged(sender As Object, e As EventArgs) Handles radTable2.Click
        TableNum(2)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"

        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable2.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 4 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("maximun seat only 1 to 4 persons ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable2.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If


    End Sub

    Private Sub radTable3_CheckedChanged(sender As Object, e As EventArgs) Handles radTable3.Click
        TableNum(3)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"

        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable3.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 4 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("maximun seat only 1 to 4 persons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable3.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If


    End Sub

    Private Sub radTable4_CheckedChanged(sender As Object, e As EventArgs) Handles radTable4.Click
        TableNum(4)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"
        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable4.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 4 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("maximun seat only 1 to 4 persons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable4.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If

    End Sub

    Private Sub radTable5_CheckedChanged(sender As Object, e As EventArgs) Handles radTable5.Click
        TableNum(5)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"

        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable5.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 4 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("maximun seat only 1 to 4 persons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable5.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If


    End Sub

    Private Sub radTable6_CheckedChanged(sender As Object, e As EventArgs) Handles radTable6.Click
        TableNum(6)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"

        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable6.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 8 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("maximun seat only 1 to 8 persons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable6.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If

    End Sub

    Private Sub radTable7_CheckedChanged(sender As Object, e As EventArgs) Handles radTable7.Click
        TableNum(7)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"


        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable7.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 8 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("Maximun seat only 1 to 8 persons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable7.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If

    End Sub

    Private Sub radTable8_CheckedChanged(sender As Object, e As EventArgs) Handles radTable8.Click
        TableNum(8)
        lblReserveTable.Text = CStr(r.reserveTable)
        lblReserveStatus.Text = "Reserved"
        If txtReservePax.Text = "" Or IsNumeric(txtReservePax.Text) = False Then
            err.AppendLine("Please input table pax")
            ctr = If(ctr, txtReservePax)

            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err.Clear()
                ctr.Focus()
                radTable8.Checked = False
                lblReserveTable.Text = ""
                lblReserveStatus.Text = ""
                Return
            End If

        ElseIf CDbl(txtReservePax.Text) > 10 Or CDbl(txtReservePax.Text) <= 0 Then
            MessageBox.Show("maximun seat only 1 to 10 persons", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            radTable8.Checked = False
            lblReserveTable.Text = ""
            lblReserveStatus.Text = ""
            txtReservePax.Clear()
        End If

    End Sub
End Class

