Public Class Registration

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tbluser' table. You can move, or remove it, as needed.
        Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)
        TbluserBindingSource.AddNew()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (txt_confirm_pass.Text = txt_pass.Text) And (txt_name.Text <> "") And (txt_username.Text <> "") And (txt_pass.Text <> "") And (txt_confirm_pass.Text <> "") And (txt_question.Text <> "") And (txt_answer.Text <> "") Then
            TbluserBindingSource.EndEdit()
            TbluserTableAdapter.Update(ClassscheduleDataSet.tbluser)
            MsgBox(" New user added !!", MsgBoxStyle.Information)
            txt_name.Text = vbEmpty
            txt_username.Text = vbEmpty
            txt_pass.Text = vbEmpty
            txt_confirm_pass.Text = vbEmpty
            txt_question.Text = vbEmpty
            txt_answer.Text = vbEmpty

            Me.Hide()
            Login.Show()


        ElseIf (txt_confirm_pass.Text <> txt_pass.Text) Then
            MsgBox(" Passwords not Matching!!", vbExclamation)
            txt_pass.Clear()
            txt_confirm_pass.Clear()
        Else
            MsgBox(" Some fields are empty!!", vbExclamation)
        End If
    End Sub

End Class