Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Collections.Generic

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As New BurzlyDataContext()
        Dim id As String = txtUserId.Text.Trim()
        Dim pass As String = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txtPassword.Text))


        Try
            Dim correct As Employee = db.Employees.FirstOrDefault(Function(o) o.empId = id)

            If id = "" Then
                MessageBox.Show("Please Enter Employee ID.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lblId.Text = "(Please Enter ID)"
            End If

            If pass = "" Then
                MessageBox.Show("Please Enter Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lblPassw.Text = "(Please Enter Password)"
            End If

            If pass <> "" And id <> "" Then
                Try
                    If correct.empPassword = pass Then
                        If correct.empPosition = "Manager" Then
                            lblId.Text = ""
                            lblPassw.Text = ""
                            lblStatus.Text = "Login successful!"
                            frmProductMenu.userTitle = correct.empPosition
                            frmProductMenu.tableNumber = "Manager"
                            frmMenuManager.ShowDialog()

                        ElseIf correct.empPosition = "Staff" Then
                            lblId.Text = ""
                            lblPassw.Text = ""
                            lblStatus.Text = "Login successful!"
                            frmProductMenu.userTitle = correct.empPosition
                            frmProductMenu.tableNumber = "Staff"
                            frmMenuStaff.ShowDialog()
                        Else
                            lblId.Text = ""
                            lblPassw.Text = ""
                            lblStatus.Text = "Login successful!"
                            frmProductMenu.tableNumber = ""
                            frmMenuStaff.ShowDialog()
                            frmProductMenu.userTitle = correct.empPosition
                        End If
                    Else
                        lblPassw.Text = "(Wrong Password)"
                        lblStatus.Text = "Login fail, please try again"
                        MessageBox.Show("Wrong Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Catch
                    lblStatus.Text = "Wrong ID"

                End Try
            End If
        Catch
            MessageBox.Show("Invalid User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function MD5Hash(ByRef password As String) As Object

        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim result As Byte()
        result = md5.ComputeHash(Encoding.ASCII.GetBytes(password))
        Return BitConverter.ToString(result)
    End Function
    Friend WithEvents err As System.Windows.Forms.ErrorProvider

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        txtUserId.Clear()
        lblStatus.Text = ""
        lblId.Text = ""
        lblPassw.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class