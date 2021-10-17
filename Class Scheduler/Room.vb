Public Class Room
    Dim dr As DataRow
    Dim dt As DataTable
    Dim rowid As Integer

    Public Sub Binding(ByVal row As String)
        rowid = row
    End Sub
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblroom' table. You can move, or remove it, as needed.
        Me.TblroomTableAdapter.Fill(Me.ClassscheduleDataSet.tblroom)
        btn_add.Enabled = False
        dataRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        TblroomBindingSource.AddNew()
        btn_add.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataRoom.CellContentClick

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (room_no.Text = "" Or room_capacity.Text = "") Then
            MsgBox(" All fields are required!!", vbExclamation)
        Else
            TblroomBindingSource.EndEdit()
            TblroomTableAdapter.Update(ClassscheduleDataSet.tblroom)
            MsgBox(" New Details added !!", MsgBoxStyle.Information)
            Me.TblroomTableAdapter.Fill(Me.ClassscheduleDataSet.tblroom)
            btn_add.Enabled = False
        End If
    End Sub

    Private Sub lblRegistration_Click(sender As Object, e As EventArgs) Handles lblRegistration.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        TblroomBindingSource.EndEdit()
        TblroomTableAdapter.Update(ClassscheduleDataSet.tblroom)
        MsgBox(" New Details updated !!", MsgBoxStyle.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Select Case MsgBox("Do you really want to Delete ?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes

                dt = ClassscheduleDataSet.tblroom
                rowid = dataRoom.CurrentRow.Index
                dt.Rows(rowid).Delete()

                MsgBox("Details Removed !!", MsgBoxStyle.Information)
            Case MsgBoxResult.No
                MsgBox("No any Changs were made!", MsgBoxStyle.Information)
        End Select
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        TblroomBindingSource.MovePrevious()
    End Sub

    Private Sub btnNxt_Click(sender As Object, e As EventArgs) Handles btnNxt.Click
        TblroomBindingSource.MoveNext()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TblroomTableAdapter.searchRoom(ClassscheduleDataSet.tblroom, txtSearch.Text + "%")
    End Sub
End Class