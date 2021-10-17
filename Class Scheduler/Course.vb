Public Class Course
    Dim dr As DataRow
    Dim dt As DataTable
    Dim rowid As Integer

    Public Sub Binding(ByVal row As String)
        rowid = row
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblcourse' table. You can move, or remove it, as needed.
        Me.TblcourseTableAdapter.Fill(Me.ClassscheduleDataSet.tblcourse)
        btn_add.Enabled = False
        dataCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        '' dataCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (txtCourse.Text = "" Or txtDesc.Text = "") Then
            MsgBox(" All fields are required!!", vbExclamation)
        Else
            TblcourseBindingSource.EndEdit()
            TblcourseTableAdapter.Update(ClassscheduleDataSet.tblcourse)
            MsgBox(" New Details added !!", MsgBoxStyle.Information)
            Me.TblcourseTableAdapter.Fill(Me.ClassscheduleDataSet.tblcourse)
            btn_add.Enabled = False
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        TblcourseBindingSource.AddNew()
        btn_add.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        TblcourseBindingSource.EndEdit()
        TblcourseTableAdapter.Update(ClassscheduleDataSet.tblcourse)
        MsgBox(" New Details updated !!", MsgBoxStyle.Information)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case MsgBox("Do you really want to Delete ?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes

                dt = ClassscheduleDataSet.tblcourse
                rowid = dataCourse.CurrentRow.Index
                dt.Rows(rowid).Delete()
                TblcourseTableAdapter.Update(ClassscheduleDataSet.tblcourse)
                Me.TblcourseTableAdapter.Fill(Me.ClassscheduleDataSet.tblcourse)
                MsgBox("Details Removed !!", MsgBoxStyle.Information)
            Case MsgBoxResult.No
                MsgBox("No any Changs were made!", MsgBoxStyle.Information)
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TblcourseTableAdapter.searchCourse(ClassscheduleDataSet.tblcourse, txtSearch.Text + "%")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNxt.Click
        TblcourseBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        TblcourseBindingSource.MovePrevious()
    End Sub
End Class