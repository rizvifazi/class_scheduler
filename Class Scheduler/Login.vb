Imports System.Data.SqlClient

Public Class Login
   


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (My.Settings.sessionAlive) Then

            txtUsername.Text = My.Settings.username
            txtPass.Text = My.Settings.password
        End If

        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tbluser' table. You can move, or remove it, as needed.
        Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)



    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        TbluserTableAdapter.user(ClassscheduleDataSet.tbluser, txtUsername.Text)
        If TbluserTableAdapter.login(ClassscheduleDataSet.tbluser, txtUsername.Text, txtPass.Text) Then
            MsgBox("Welcome " & txtUsername.Text & " !!", vbInformation)
            Me.Hide()
            Main.Show()
        ElseIf TbluserTableAdapter.login(ClassscheduleDataSet.tbluser, txtUsername.Text, txtPass.Text) = False Then
            txtUsername.Clear()
            txtPass.Clear()
            MsgBox("Wrong Username or Password", vbExclamation)
        End If
        'TbluserTableAdapter.login(ClassscheduleDataSet.tbluser, txtUsername.Text, txtPass.Text)

        If (checkRem.Checked) Then

            My.Settings.sessionAlive = True
            My.Settings.username = txtUsername.Text
            My.Settings.password = txtPass.Text
        Else
            My.Settings.username = ""
            My.Settings.password = ""
        End If



    End Sub

   


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblfgps.Click
        forgot_password.Show()
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles lblfgps.MouseHover
        lblfgps.ForeColor = Color.DarkBlue
    End Sub

    Private Sub lblfgps_MouseLeave(sender As Object, e As EventArgs) Handles lblfgps.MouseLeave
        lblfgps.ForeColor = Color.DodgerBlue
    End Sub
End Class