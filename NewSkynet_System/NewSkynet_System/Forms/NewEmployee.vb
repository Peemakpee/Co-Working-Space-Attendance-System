Imports MySql.Data.MySqlClient

Public Class NewEmployee
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try
            create("INSERT INTO employee_table(EMPLOYEEID, FIRSTNAME, LASTNAME)VALUES('" & txtboxEmpID.Text & "',
                    '" & txtboxFname.Text & "', '" & txtboxLname.Text & "' )")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub NewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvEmp_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellDoubleClick
        txtboxEmpID.Text = dgvEmp.CurrentRow.Cells(1).Value.ToString()
        txtboxFname.Text = dgvEmp.CurrentRow.Cells(2).Value.ToString()
        txtboxLname.Text = dgvEmp.CurrentRow.Cells(3).Value.ToString()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            reloadtxt("UPDATE employee_table SET FIRSTNAME='" & txtboxFname.Text & "', LASTNAME='" & txtboxLname.Text & "' WHERE EMPLOYEEID='" & txtboxEmpID.Text & "'")
            MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            reloadtxt("DELETE FROM employee_table WHERE EMPLOYEEID='" & txtboxEmpID.Text & "'")
            MessageBox.Show("Successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try

    End Sub


    'Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    LoadData()
    'End Sub

    Public Sub LoadData()
        Try
            reload("SELECT * FROM employee_table", dgvEmp)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        Try
            reload("SELECT * FROM employee_table WHERE FIRSTNAME LIKE'%" & txtboxSearch.Text & "%' OR LASTNAME LIKE'%" & txtboxSearch.Text & "%' OR EMPLOYEEID LIKE'%" & txtboxSearch.Text & "%'", dgvEmp)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvEmp_MouseHover(sender As Object, e As EventArgs) Handles dgvEmp.MouseHover
        LoadData()
    End Sub
End Class