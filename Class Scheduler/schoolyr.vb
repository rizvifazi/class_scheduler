Public Class schoolyr
    Dim dr As DataRow
    Dim dt As DataTable
    Dim rowid As Integer

    Public Sub Binding(ByVal row As String)
        rowid = row
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub schoolyr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.schoolyr' table. You can move, or remove it, as needed.
        Me.SchoolyrTableAdapter.Fill(Me.ClassscheduleDataSet.schoolyr)
        btn_add.Enabled = False
        dataYr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        SchoolyrBindingSource.AddNew()
        btn_add.Enabled = True
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (txtYear.Text = "") Then
            MsgBox(" All fields are required!!", vbExclamation)
        Else
            SchoolyrBindingSource.EndEdit()
            SchoolyrTableAdapter.Update(ClassscheduleDataSet.schoolyr)
            MsgBox(" New Details added !!", MsgBoxStyle.Information)
            Me.SchoolyrTableAdapter.Fill(Me.ClassscheduleDataSet.schoolyr)
            btn_add.Enabled = False
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        SchoolyrBindingSource.EndEdit()
        SchoolyrTableAdapter.Update(ClassscheduleDataSet.schoolyr)
        MsgBox(" New Details updated !!", MsgBoxStyle.Information)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
       

            Select Case MsgBox("Do you really want to Delete ?", MsgBoxStyle.YesNo, "caption")
                Case MsgBoxResult.Yes

                dt = ClassscheduleDataSet.schoolyr
                rowid = dataYr.CurrentRow.Index
                dt.Rows(rowid).Delete()
                SchoolyrTableAdapter.Update(ClassscheduleDataSet.schoolyr)
                Me.SchoolyrTableAdapter.Fill(Me.ClassscheduleDataSet.schoolyr)

                MsgBox("Details Removed !!", MsgBoxStyle.Information)
                Case MsgBoxResult.No
                    MsgBox("No any Changs were made!", MsgBoxStyle.Information)
            End Select
            'you may want to add a confirmation message, and if the user confirms delete

       
    End Sub
End Class