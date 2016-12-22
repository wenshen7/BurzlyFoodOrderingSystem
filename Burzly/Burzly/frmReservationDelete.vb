Public Class frmReservationDelete


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Reservation' table. You can move, or remove it, as needed.
        '  Me.ReservationTableAdapter.Fill(Me.BurzlyDBDataSet.Reservation)
        Dim db As New BurzlyDataContext()
        dgvReservation.DataSource = db.Reservations

        dgvReservation.DataSource = db.Reservations
        dgvReservation.Columns("reserveId").HeaderText = "Reserve ID"
        dgvReservation.Columns("reserveName").HeaderText = "Reserve Name"
        dgvReservation.Columns("reserveContact").HeaderText = "Reserve Contact"
        dgvReservation.Columns("reserveDate").HeaderText = "Reserve Date"
        dgvReservation.Columns("reserveTime").HeaderText = "Reserve Time"
        dgvReservation.Columns("reservePax").HeaderText = "Reserve Pax"
        dgvReservation.Columns("reserveTable").HeaderText = "Reserve Table"
        dgvReservation.Columns("reserveStatus").HeaderText = "Reserve Status"


        SeacrhData()

        txtSeacrh.Clear()
        txtSeacrh.Focus()
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub SeacrhData()

        Dim db As New BurzlyDataContext()
        Dim rs = From o In db.Reservations
                 Where o.reserveName.Contains(txtSeacrh.Text) Or o.reserveId.Contains(txtSeacrh.Text) Or o.reserveContact.Contains(txtSeacrh.Text)
        dgvReservation.DataSource = rs

    End Sub

    Private Sub txtSeacrh_TextChanged(sender As Object, e As EventArgs) Handles txtSeacrh.TextChanged
        SeacrhData()

        txtSeacrh.Focus()

    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New BurzlyDataContext
        Dim r As Reservation = db.Reservations.FirstOrDefault(Function(o) o.reserveId = txtSeacrh.Text Or o.reserveName = txtSeacrh.Text Or o.reserveContact = txtSeacrh.Text)

        If r Is Nothing Then
            MessageBox.Show("record not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As Integer = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                db.Reservations.DeleteOnSubmit(r)
                db.SubmitChanges()
                MessageBox.Show("Data delete sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dgvReservation.DataSource = db.Reservations
            Else
                MessageBox.Show("delete unsucessful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        txtSeacrh.Clear()
        txtSeacrh.Focus()
    End Sub


End Class