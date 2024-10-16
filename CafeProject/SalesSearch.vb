Imports System.Data.SqlClient
Public Class SalesSearch

    'SQL Connection
    Private sqlConnection As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    Private Function checkSQLConnection(ByVal c As SqlConnection) As Boolean

        Try
            c.Open()

            If c.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Dim rowSpacing As Integer = 20
    Private Sub btnDateSearch_Click(sender As Object, e As EventArgs) Handles btnDateSearch.Click
        If dtpTo.Value >= dtpFrom.Value Then
            Main.btnSalesPrev.Enabled = False
            Main.page = 0
            Main.search = False
            Main.DateSearch = True

            Dim dateFrom As DateTime = dtpFrom.Value
            Dim dateTo As DateTime = dtpTo.Value

            Dim startDatetime As DateTime = dateFrom.Date
            Dim endDateTime As DateTime = dateTo.Date.AddDays(1).AddSeconds(-1)
            MsgBox(Format(startDatetime, "MMMM-dd-yyyy hh:mm:ss tt") & " " & Format(endDateTime, "MMMM-dd-yyyy hh:mm:ss tt"))

            Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startDatetime & "'AND '" & endDateTime & "' ORDER BY customerID + 0 ASC"
            Main.dateFrom = startDatetime
            Main.dateTo = endDateTime
            Main.SalesData(rowSpacing, query)
            Me.Close()
        Else
            MsgBox("Date To should not below than the date from.", vbInformation, "Invalid Input")
        End If
    End Sub

End Class