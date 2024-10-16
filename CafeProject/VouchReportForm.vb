Public Class VouchReportForm
    Private Sub VouchReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tblvouch' table. You can move, or remove it, as needed.
        Me.tblvouchTableAdapter.Fill(Me.DataSet1.tblvouch)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class