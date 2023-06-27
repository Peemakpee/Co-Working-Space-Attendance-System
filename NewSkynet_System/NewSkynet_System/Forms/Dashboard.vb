Public Class Dashboard
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewEmp.Click

        NewEmployee.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnTimeInOut.Click

        TimeInOut.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnGenerate.Click, btnGenerate.Click

        FormReport.Show()
        Me.Hide()

    End Sub

End Class