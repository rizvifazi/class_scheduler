Public Class Instructor
    Dim dr As DataRow
    Dim dt As DataTable
    Dim rowid As Integer

    Public Sub Binding(ByVal row As String)
        row = rowid
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Instructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblinstructor' table. You can move, or remove it, as needed.
        Me.TblinstructorTableAdapter.Fill(Me.ClassscheduleDataSet.tblinstructor)

        btn_add.Enabled = False
        'dataIns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill



    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If (txt_name.Text = "" Or txtLast.Text = "") Then
            MsgBox(" Some Required Fields are Empty!!", vbExclamation)
        Else
            TblinstructorBindingSource.EndEdit()
            TblinstructorTableAdapter.Update(ClassscheduleDataSet.tblinstructor)

            Dim mem As New IO.MemoryStream()
            picBx.Image.Save(mem, Drawing.Imaging.ImageFormat.Jpeg)
            Dim pic() As Byte = mem.ToArray()

            MsgBox(" New Details added !!", MsgBoxStyle.Information)
            Me.TblinstructorTableAdapter.Fill(Me.ClassscheduleDataSet.tblinstructor)

            Binding(rowid)
            btn_add.Enabled = False

        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        TblinstructorBindingSource.AddNew()
        btn_add.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        TblinstructorBindingSource.EndEdit()
        If txt_name.Text <> Nothing Or txtLast.Text <> Nothing Then
            TblinstructorTableAdapter.Update(ClassscheduleDataSet.tblinstructor)
            MsgBox(" New Details updated !!", MsgBoxStyle.Information)
        Else
            MsgBox(" Some required Fields are Empty!!", vbExclamation)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case MsgBox("Do you really want to Delete ?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes

                dt = ClassscheduleDataSet.tblinstructor
                rowid = dataIns.CurrentRow.Index

                dt.Rows(rowid).Delete()
                TblinstructorTableAdapter.Update(ClassscheduleDataSet.tblinstructor)

                MsgBox("Details Removed !!", MsgBoxStyle.Information)
                Me.TblinstructorTableAdapter.Fill(Me.ClassscheduleDataSet.tblinstructor)
            Case MsgBoxResult.No
                MsgBox("No any Changs were made!", MsgBoxStyle.Information)
        End Select
        Me.TblinstructorTableAdapter.Fill(Me.ClassscheduleDataSet.tblinstructor)
    End Sub

    Private Sub btnPre_Click(sender As Object, e As EventArgs) Handles btnPre.Click
        TblinstructorBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TblinstructorBindingSource.MoveNext()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TblinstructorTableAdapter.searchInstructor(ClassscheduleDataSet.tblinstructor, txtSearch.Text + "%", "%" + txtSearch.Text + "%", txtSearch.Text + "%", txtSearch.Text + "%", txtSearch.Text + "%")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picBx.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        picBx.Image = Nothing
    End Sub
End Class