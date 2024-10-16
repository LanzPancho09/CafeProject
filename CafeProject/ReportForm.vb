Public Class ReportForm
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblReport' table. You can move, or remove it, as needed.
        Me.tblReportTableAdapter.Fill(Me.DataSet1.tblReport)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class