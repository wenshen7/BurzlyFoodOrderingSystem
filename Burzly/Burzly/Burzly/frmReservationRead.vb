Public Class frmReservationRead
    Dim db As New BurzlyDataContext()

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Activated
        'TODO: This line of code loads data into the 'BurzlyDBDataSet.Reservation' table. You can move, or remove it, as needed.
        '  Me.ReservationTableAdapter.Fill(Me.BurzlyDBDataSet.Reservation)
        'Dim db As New BurzlyDataContext()
        db = New BurzlyDataContext()
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
    End Sub


    Private Sub SeacrhData()

        'Dim db As New BurzlyDataContext()
        db = New BurzlyDataContext()
        Dim rs = From o In db.Reservations
                 Where o.reserveName.Contains(txtSeacrh.Text) Or o.reserveId.Contains(txtSeacrh.Text) Or o.reserveContact.Contains(txtSeacrh.Text)
        dgvReservation.DataSource = rs


    End Sub

    Private Sub txtSeacrh_TextChanged(sender As Object, e As EventArgs) Handles txtSeacrh.TextChanged
        SeacrhData()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        db = New BurzlyDataContext()
        'Dim db As New BurzlyDataContext()
        dgvReservation.DataSource = db.Reservations
        frmReservationInsert.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        db = New BurzlyDataContext()
        dgvReservation.DataSource = db.Reservations
        frmReservationUpdate.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        db = New BurzlyDataContext()
        'Dim db As New BurzlyDataContext()
        dgvReservation.DataSource = db.Reservations
        frmReservationDelete.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        db = New BurzlyDataContext()
    End Sub
End Class