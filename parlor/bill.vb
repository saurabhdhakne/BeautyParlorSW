Imports Microsoft.Reporting.WinForms


Public Class bill

    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim user As New ReportParameter("username", Form1.username.Text)
        Dim total As New ReportParameter("Rate", Form1.total.Text)
        ReportViewer1.LocalReport.SetParameters(user)
        ReportViewer1.LocalReport.SetParameters(total)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class