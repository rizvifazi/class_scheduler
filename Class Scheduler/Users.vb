Public Class Users
    Dim dr As DataRow
    Dim dt As DataTable
    Dim rowid As Integer

    Public Sub Binding(ByVal row As String)
        row = rowid
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tbluser' table. You can move, or remove it, as needed.
        Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)

        btn_add.Enabled = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (txt_name.Text = "") Then
            MsgBox(" All fields are required!!", vbExclamation)
        Else
            TbluserBindingSource.EndEdit()
            TbluserTableAdapter.Update(ClassscheduleDataSet.tbluser)

           

            MsgBox(" New Details added !!", MsgBoxStyle.Information)
            Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)
            btn_add.Enabled = False
            Binding(rowid)
        End If
    End Sub


    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        TbluserBindingSource.AddNew()
        btn_add.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        TbluserBindingSource.EndEdit()
        TbluserTableAdapter.Update(ClassscheduleDataSet.tbluser)
        MsgBox(" New Details updated !!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case MsgBox("Do you really want to Delete ?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes

                dt = ClassscheduleDataSet.tbluser
                rowid = dataUser.CurrentRow.Index
                dt.Rows(rowid).Delete()
                TbluserTableAdapter.Update(ClassscheduleDataSet.tbluser)

                MsgBox("Details Removed !!", MsgBoxStyle.Information)
                Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)
            Case MsgBoxResult.No
                MsgBox("No any Changs were made!", MsgBoxStyle.Information)
        End Select
        Me.TbluserTableAdapter.Fill(Me.ClassscheduleDataSet.tbluser)
    End Sub

End Class