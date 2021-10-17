Public Class Results
    ' Results.RecordLocks = 2

    Dim dr As DataRow
    Dim dt As DataTable
    Dim rowid As Integer

    Dim pl As Integer = 0
    Dim totAss As Double = 0.0
    Dim Av As Double = 0.0

    Public Sub Binding(ByVal row As String)
        row = rowid
    End Sub




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Timer1.Stop()
        pl = 0
        Me.pnlDrop.Size = New Size(Me.pnlDrop.Size.Width, pl)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pl > 350 Then
            Timer1.Stop()
        Else
            Me.pnlDrop.Size = New Size(Me.pnlDrop.Size.Width, pl)
            pl += 50
        End If

    End Sub

    Private Sub btnGrade_MouseHover(sender As Object, e As EventArgs) Handles btnGrade.MouseHover
        ' Timer1.Start()
    End Sub

    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblresults' table. You can move, or remove it, as needed.
        Me.TblresultsTableAdapter.Fill(Me.ClassscheduleDataSet.tblresults)

        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tblsubject' table. You can move, or remove it, as needed.
        Me.TblsubjectTableAdapter.Fill(Me.ClassscheduleDataSet.tblsubject)

        'TODO: This line of code loads data into the 'ClassscheduleDataSet.tbgrade' table. You can move, or remove it, as needed.
        Me.TbgradeTableAdapter.Fill(Me.ClassscheduleDataSet.tbgrade)

        'TODO: This line of code loads data into the 'ClassscheduleDataSet.schoolyr' table. You can move, or remove it, as needed.
        Me.SchoolyrTableAdapter.Fill(Me.ClassscheduleDataSet.schoolyr)


        Me.pnlDrop.Size = New Size(Me.pnlDrop.Size.Width, pl)
        'lblAp.Text = txtAp.Text
        lblA.Text = txtA.Text
        lblB.Text = txtB.Text
        lblBp.Text = txtBp.Text
        lblC.Text = txtC.Text
        lblD.Text = txtD.Text

        'resultData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        btn_add.Enabled = False
    End Sub

    Private Sub btnGrade_MouseLeave(sender As Object, e As EventArgs) Handles btnGrade.MouseLeave
        'Timer1.Stop()
        'pl = 0
        'Me.pnlDrop.Size = New Size(Me.pnlDrop.Size.Width, pl)
    End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Timer1.Start()
        lblE.Text = txtD.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        TbgradeBindingSource.EndEdit()
        TbgradeTableAdapter.Update(ClassscheduleDataSet.tbgrade)
        TbgradeTableAdapter.Fill(ClassscheduleDataSet.tbgrade)

        Timer1.Stop()
        pl = 0
        Me.pnlDrop.Size = New Size(Me.pnlDrop.Size.Width, pl)
    End Sub

    Private Sub comboYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboYear.SelectedIndexChanged
        If comboSem.SelectedIndex = -1 Then
        Else
            TblsubjectTableAdapter.SubjectFilterQuery(ClassscheduleDataSet.tblsubject, comboYear.Text, comboSem.Text)
        End If
    End Sub

    Private Sub comboSem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSem.SelectedIndexChanged
        TblsubjectTableAdapter.SubjectFilterQuery(ClassscheduleDataSet.tblsubject, comboYear.Text, comboSem.Text)
    End Sub



    Function getGrade(ByVal x As String, ByVal y As String) As String
        If Val(x) >= Val(txtAp.Text) Then
            y = "A+"
        ElseIf Val(x) < Val(txtAp.Text) And Val(x) >= Val(txtA.Text) Then
            y = "A"
        ElseIf Val(x) < Val(txtA.Text) And Val(x) >= Val(txtAm.Text) Then
            y = "A-"
        ElseIf Val(x) < Val(txtAm.Text) And Val(x) >= Val(txtBp.Text) Then
            y = "B+"
        ElseIf Val(x) < Val(txtBp.Text) And Val(x) >= Val(txtB.Text) Then
            y = "B"
        ElseIf Val(x) < Val(txtB.Text) And Val(x) >= Val(txtBm.Text) Then
            y = "B-"
        ElseIf Val(x) < Val(txtBm.Text) And Val(x) >= Val(txtCp.Text) Then
            y = "C+"
        ElseIf Val(x) < Val(txtCp.Text) And Val(x) >= Val(txtC.Text) Then
            y = "C"
        ElseIf Val(x) < Val(txtC.Text) And Val(x) >= Val(txtCm.Text) Then
            y = "C-"
        ElseIf Val(x) < Val(txtCm.Text) And Val(x) >= Val(txtDp.Text) Then
            y = "D+"
        ElseIf Val(x) < Val(txtDp.Text) And Val(x) >= Val(txtD.Text) Then
            y = "D"
        ElseIf Val(x) < Val(txtD.Text) And Val(x) >= 1 Then
            y = "E"
        ElseIf x = "" Then

            y = ""
        Else
            y = ""
        End If

        Return y
    End Function


    Private Sub txtAss1_TextChanged(sender As Object, e As EventArgs) Handles txtAss1.TextChanged
        lblAss1.Text = getGrade(txtAss1.Text, lblAss1.Text)

    End Sub


    Private Sub txtAss2_TextChanged(sender As Object, e As EventArgs) Handles txtAss2.TextChanged
        lblAss2.Text = getGrade(txtAss2.Text, lblAss2.Text)
    End Sub

    Private Sub txtAss3_TextChanged(sender As Object, e As EventArgs) Handles txtAss3.TextChanged
        lblAss3.Text = getGrade(txtAss3.Text, lblAss3.Text)
    End Sub

    Private Sub txtFinal_TextChanged(sender As Object, e As EventArgs) Handles txtFinal.TextChanged
        'Dim marks() = {Val(txtAss1.Text), Val(txtAss2.Text), Val(txtAss3.Text)}
        'Array.Sort(marks)

        'If radB2.Checked = True And radB3.Checked = False Then
        '    Av = ((marks(1) + marks(2)) / 2)
        '    totAss = Av * (33.0 / 100.0)
        '    finalScore.Text = totAss + ((Val(txtFinal.Text)) * (67.0 / 100.0))
        'ElseIf radB2.Checked = False And radB3.Checked = True Then
        '    Av = ((marks(0) + marks(1) + marks(2)) / 3)
        '    totAss = Av * (33.0 / 100.0)
        '    finalScore.Text = totAss + ((Val(txtFinal.Text)) * (67.0 / 100.0))
        'ElseIf radB2.Checked = False And radB3.Checked = False Then

        '    MsgBox("Please Select The number of Assesments to Consider!!", MsgBoxStyle.Exclamation)
        'ElseIf Val(finalScore.Text) = 0 Then
        '    MsgBox("Please Enter the final Exam Score!!", MsgBoxStyle.Exclamation)
        'End If

        'lblFinalGrade.Text = getGrade(finalScore.Text, lblFinalGrade.Text)


    End Sub



    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim marks() = {Val(txtAss1.Text), Val(txtAss2.Text), Val(txtAss3.Text)}
        Array.Sort(marks)

        If radB2.Checked = True And radB3.Checked = False Then
            ' Av = ((marks(1) + marks(2)) / 2.0)
            totAss = (((marks(1) + marks(2)) / 2.0) * (33.0 / 100.0))
            finalScore.Text = (((marks(1) + marks(2)) / 2.0) * (33.0 / 100.0)) + ((Val(txtFinal.Text)) * (67.0 / 100.0))
            ' totAss = Av * (33.0 / 100.0)
            'finalScore.Text = totAss + ((Val(txtFinal.Text)) * (67.0 / 100.0))
        ElseIf radB2.Checked = False And radB3.Checked = True Then
            ' Av = ((marks(0) + marks(1) + marks(2)) / 3.0)
            totAss = (((marks(0) + marks(1) + marks(2)) / 3.0) * (33.0 / 100.0))
            finalScore.Text = (((marks(0) + marks(1) + marks(2)) / 3.0) * (33.0 / 100.0)) + ((Val(txtFinal.Text)) * (67.0 / 100.0))
            ' totAss = Av * (33.0 / 100.0)
            'finalScore.Text = totAss + ((Val(txtFinal.Text)) * (67.0 / 100.0))
        ElseIf radB2.Checked = False And radB3.Checked = False Then
            MsgBox("Please Select The number of Assesments to Consider!!", MsgBoxStyle.Exclamation)
        ElseIf Val(finalScore.Text) = 0 Then
            MsgBox("Please Enter the final Exam Score!!", MsgBoxStyle.Exclamation)
        End If

        lblFinalGrade.Text = getGrade(finalScore.Text, lblFinalGrade.Text)

    End Sub


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        TblresultsBindingSource.EndEdit()

        TblresultsTableAdapter.Update(ClassscheduleDataSet.tblresults)
        'Binding(rowid)
        btn_add.Enabled = False
        Me.TblresultsTableAdapter.Fill(Me.ClassscheduleDataSet.tblresults)
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        TblresultsBindingSource.AddNew()
        btn_add.Enabled = True
        radB2.Checked = False
        radB3.Checked = False
        ' comboSub.SelectedValue = Not vbNull
    End Sub

    Private Sub comboSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSub.SelectedIndexChanged
        'lblTemp.Text = comboSub.SelectedValue.ToString()
        '    If comboSub.SelectedValue = -1 Then
        '        txtDesc.Text = TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue)
        '    Else
        '        txtDesc.Text = TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue)
        '    End If
        ' If comboSub.SelectedValue = Not Nothing Then
        ' Else
        '  txtDesc.Text = TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue.ToString)

        'End If

        'If String.IsNullOrEmpty(comboSub.SelectedValue.ToString) Then
        '    ' "Contains Empty value or Null Value" 
        'Else
        '    TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue)
        'End If
        'If comboSub.SelectedValue IsNot Nothing Then
        '    txtDesc.Text = TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue.ToString())
        'End If
        'If comboSub.SelectedValue = -1 Then
        '    TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue.ToString())
        'End If
        'If comboSub.SelectedValue IsNot Nothing Then
        '    lblTemp.Text = comboSub.SelectedValue.ToString()
        '    TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, lblTemp.Text)
        'End If
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        'If comboSub.SelectedValue = -1 Then
        '    TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue.ToString())
        'End If
        'If comboSub.SelectedValue IsNot Nothing Then
        '    TblsubjectTableAdapter.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue.ToString())
        'End If
    End Sub

    'Sub comboSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboSub.SelectedIndexChanged
    '    Dim cbo = CType(sender, ComboBox)
    '    Dim cc = CType(cbo.SelectedItem, Subject)
    '    If cc IsNot Nothing Then
    '        txtDesc.Text = cc.SelectDescript(ClassscheduleDataSet.tblsubject, comboSub.SelectedValue)
    '        'lblUnits.Text = cc.Units.ToString()
    '    End If

    'End Sub

   
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Select Case MsgBox("Do you really want to Delete ?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes

                dt = ClassscheduleDataSet.tblresults
                rowid = resultData.CurrentRow.Index

                dt.Rows(rowid).Delete()
                TblresultsTableAdapter.Update(ClassscheduleDataSet.tblresults)

                MsgBox("Details Removed !!", MsgBoxStyle.Information)
                Me.TblresultsTableAdapter.Fill(Me.ClassscheduleDataSet.tblresults)
            Case MsgBoxResult.No
                MsgBox("No any Changs were made!", MsgBoxStyle.Information)
        End Select
        Me.TblresultsTableAdapter.Fill(Me.ClassscheduleDataSet.tblresults)
    End Sub
End Class