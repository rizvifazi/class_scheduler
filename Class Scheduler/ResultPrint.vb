Public Class ResultPrint

    Private Sub ResultPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim rpt As New PrintResults1
        ' Dim frm_rpt As New ResultPrint
        If Main.comboExam.SelectedItem = "Assesment 1" Then
            CrystalReportViewer1.Visible = True
            CrystalReportViewer2.Visible = False
            CrystalReportViewer3.Visible = False
            CrystalReportViewer4.Visible = False
            CrystalReportViewer1.SelectionFormula = "{tblresults.Subject} = '" & Main.comboSub.SelectedValue.ToString & "' And {tblresults.Accademic_Year} = '" & Main.comboAc.SelectedValue.ToString & "'"
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
        ElseIf Main.comboExam.SelectedItem = "Assesment 2" Then
            CrystalReportViewer1.Visible = False
            CrystalReportViewer2.Visible = True
            CrystalReportViewer3.Visible = False
            CrystalReportViewer4.Visible = False
            CrystalReportViewer2.SelectionFormula = "{tblresults.Subject} = '" & Main.comboSub.SelectedValue.ToString & "' And {tblresults.Accademic_Year} = '" & Main.comboAc.SelectedValue.ToString & "'"
            CrystalReportViewer2.Refresh()
            CrystalReportViewer2.RefreshReport()
        ElseIf Main.comboExam.SelectedItem = "Assesment 3" Then
            CrystalReportViewer1.Visible = False
            CrystalReportViewer2.Visible = False
            CrystalReportViewer3.Visible = True
            CrystalReportViewer4.Visible = False
            CrystalReportViewer3.SelectionFormula = "{tblresults.Subject} = '" & Main.comboSub.SelectedValue.ToString & "' And {tblresults.Accademic_Year} = '" & Main.comboAc.SelectedValue.ToString & "'"
            CrystalReportViewer3.Refresh()
            CrystalReportViewer3.RefreshReport()
        ElseIf Main.comboExam.SelectedItem = "Final" Then
            CrystalReportViewer1.Visible = False
            CrystalReportViewer2.Visible = False
            CrystalReportViewer3.Visible = False
            CrystalReportViewer4.Visible = True
            CrystalReportViewer4.SelectionFormula = "{tblresults.Subject} = '" & Main.comboSub.SelectedValue.ToString & "' And {tblresults.Accademic_Year} = '" & Main.comboAc.SelectedValue.ToString & "'"
            CrystalReportViewer4.Refresh()
            CrystalReportViewer4.RefreshReport()
        End If

    End Sub
End Class