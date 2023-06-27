Public Class FormReport
    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try
            reload("SELECT CONCAT(FIRSTNAME, ' ', LASTNAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, TOTALHOURS, PAYMENT FROM employee_attendance INNER JOIN employee_table ON employee_attendance.EMPLOYEEID=employee_table.EMPLOYEEID WHERE DATE(LOGDATE)=CURDATE()", dgvReport)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        Try
            reload("SELECT CONCAT(FIRSTNAME, ' ', LASTNAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, TOTALHOURS, PAYMENT FROM employee_attendance INNER JOIN employee_table ON employee_attendance.EMPLOYEEID=employee_table.EMPLOYEEID WHERE WEEK(LOGDATE)=WEEK(NOW())", dgvReport)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        Try
            reload("SELECT CONCAT(FIRSTNAME, ' ', LASTNAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, TOTALHOURS, PAYMENT FROM employee_attendance INNER JOIN employee_table ON employee_attendance.EMPLOYEEID=employee_table.EMPLOYEEID WHERE MONTH(LOGDATE)=MONTH(NOW())", dgvReport)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class