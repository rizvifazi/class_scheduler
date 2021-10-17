Public Class forgot_password

   

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        TbluserTableAdapter.user(ClassscheduleDataSet.tbluser, txt_username.Text)
        If TbluserTableAdapter.fogotpass(ClassscheduleDataSet.tbluser, txt_username.Text, txt_question.Text, txt_answer.Text) Then
            MsgBox("Enter Nwe details", vbInformation)
            Me.Hide()
            Registration.Show()
        ElseIf TbluserTableAdapter.fogotpass(ClassscheduleDataSet.tbluser, txt_username.Text, txt_question.Text, txt_answer.Text) = False Then
            MsgBox("Wrong Information", vbExclamation)
            txt_username.Clear()
            txt_question.Clear()
            txt_answer.Clear()
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub forgot_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tbluser' table. You can move, or remove it, as needed.
        Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)

    End Sub
End Class