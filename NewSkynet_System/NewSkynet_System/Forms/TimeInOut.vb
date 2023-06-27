Imports System.Security.Cryptography.X509Certificates

Public Class TimeInOut
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateTime.Now.ToString("yyyy/M/dd")
    End Sub

    Private Sub btnTimeInOut_Click(sender As Object, e As EventArgs) Handles btnTimeInOut.Click
        Try
            If txtboxEmpID.Text = "" Then
                MessageBox.Show("Please enter Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                reloadtxt("SELECT * FROM employee_table WHERE EMPLOYEEID='" & txtboxEmpID.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM employee_attendance WHERE EMPLOYEEID='" & txtboxEmpID.Text & "' AND LOGDATE='" & lblDate.Text & "' AND AM_STATUS='Time In' AND PM_STATUS='Time Out'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("You have already time in and time out for today", "Already", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        reloadtxt("SELECT * FROM employee_attendance WHERE EMPLOYEEID='" & txtboxEmpID.Text & "' AND LOGDATE='" & lblDate.Text & "' AND AM_STATUS='Time In'")
                        If dt.Rows.Count > 0 Then
                            updateLogged("UPDATE employee_attendance SET TIMEOUT='" & TimeOfDay & "', PM_STATUS='Time Out', TOTALHOURS=TIMEOUT-TIMEIN, PAYMENT=TOTALHOURS*40 WHERE EMPLOYEEID='" & txtboxEmpID.Text & "' AND LOGDATE='" & lblDate.Text & "'")
                            MessageBox.Show("Successfully Time Out", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            createLogged("INSERT INTO employee_attendance(EMPLOYEEID, LOGDATE, TIMEIN, AM_STATUS)VALUES('" & txtboxEmpID.Text & "', '" & lblDate.Text & "', '" & TimeOfDay & "','Time In')")
                            MessageBox.Show("Successfully Time In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Employee ID not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TimeInOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadAttendance()
    End Sub

    Public Sub ReloadAttendance()
        Try
            reload("SELECT CONCAT(FIRSTNAME, ' ', LASTNAME) AS FULLNAME, LOGDATE, TIMEIN, AM_STATUS, TIMEOUT, PM_STATUS, TOTALHOURS, PAYMENT FROM employee_attendance INNER JOIN employee_table ON employee_attendance.EMPLOYEEID=employee_table.EMPLOYEEID", dgvTITO)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ReloadAttendance()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class