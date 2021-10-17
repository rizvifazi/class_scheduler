Public Class Subject

    Dim dr As DataRow
    Dim dt As DataTable
    Dim rowid As Integer



    Public Sub Binding(ByVal row As String)
        row = rowid
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblsubject' table. You can move, or remove it, as needed.
        Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)
        subjectData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        btn_add.Enabled = False
        If comboCredit.SelectedItem = Not 0 Then
            comboLab.Enabled = False
        Else
            comboLab.Enabled = True
        End If

        If comboLab.SelectedItem = Not 0 Then
            comboCredit.Enabled = False
        Else
            comboCredit.Enabled = True
        End If

    End Sub

    Private Sub checkCredit_CheckedChanged(sender As Object, e As EventArgs) Handles checkCredit.CheckedChanged
        If checkCredit.Checked = True Then
            comboCredit.Enabled = False
            comboLab.Enabled = False
        Else
            comboCredit.Enabled = True
            comboLab.Enabled = True
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        TblsubjectBindingSource.AddNew()
        btn_add.Enabled = True
        checkCredit.Checked = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txtSubjectcode.Text = "" And (comboCredit.SelectedItem = Nothing Or comboLab.SelectedItem = Nothing Or checkCredit.Checked = False) And txtQuantity.Text = Nothing Then
            MsgBox(" Some Required Fields are Empty!!", vbExclamation)
        ElseIf checkCredit.Checked = True Then
            comboCredit.SelectedIndex = 0
            comboLab.SelectedIndex = 0


            TblsubjectBindingSource.EndEdit()
            TblsubjectTableAdapter.Update(ClassscheduleDataSet.tblsubject)


            MsgBox(" New Details added !!", MsgBoxStyle.Information)
            Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)

            Binding(rowid)
            btn_add.Enabled = False

        ElseIf checkCredit.Checked = False Then

            TblsubjectBindingSource.EndEdit()
            TblsubjectTableAdapter.Update(ClassscheduleDataSet.tblsubject)


            MsgBox(" New Details added !!", MsgBoxStyle.Information)
            Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)

            Binding(rowid)
            btn_add.Enabled = False
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        TblsubjectBindingSource.EndEdit()
        If txtSubjectcode.Text = "" And (comboCredit.SelectedItem = Nothing Or comboLab.SelectedItem = Nothing Or checkCredit.Checked = False) And txtQuantity.Text = Nothing Then
            MsgBox(" Some Required Fields are Empty!!", vbExclamation)
        ElseIf checkCredit.Checked = True Then
            comboCredit.SelectedIndex = 0
            comboLab.SelectedIndex = 0


            TblsubjectBindingSource.EndEdit()
            TblsubjectTableAdapter.Update(ClassscheduleDataSet.tblsubject)


            MsgBox(" New Details Updated !!", MsgBoxStyle.Information)
            Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)

            Binding(rowid)
            btn_add.Enabled = False

        ElseIf checkCredit.Checked = False Then

            TblsubjectBindingSource.EndEdit()
            TblsubjectTableAdapter.Update(ClassscheduleDataSet.tblsubject)


            MsgBox(" New Details Updated!!", MsgBoxStyle.Information)
            Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)

            Binding(rowid)
            btn_add.Enabled = False
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Do you really want to Delete ?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes

                dt = ClassscheduleDataSet.tblsubject
                rowid = subjectData.CurrentRow.Index

                dt.Rows(rowid).Delete()
                TblsubjectTableAdapter.Update(ClassscheduleDataSet.tblsubject)

                MsgBox("Details Removed !!", MsgBoxStyle.Information)
                Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)
            Case MsgBoxResult.No
                MsgBox("No any Changs were made!", MsgBoxStyle.Information)
        End Select
        Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)
    End Sub

  
    Private Sub comboCredit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCredit.SelectedIndexChanged
       
    End Sub

    Private Sub comboLab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboLab.SelectedIndexChanged
       
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        TblsubjectBindingSource.MovePrevious()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        TblsubjectBindingSource.MoveNext()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        TblsubjectTableAdapter.searchSubject(ClassscheduleDataSet.tblsubject, txtSearch.Text + "%", "%" + txtSearch.Text + "%")
    End Sub
End Class