Public Class Scheduler
    Private Sub Scheduler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Visible = True
       

        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class