Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        txtdepartment.Enabled = False
        txtfirstname.Enabled = False
        txtlastname.Enabled = False
        txtposition.Enabled = False

    End Sub

    Private Sub btnfind_Click(sender As Object, e As EventArgs) Handles btnfind.Click
        FindRecord(txtid.Text)
    End Sub


End Class
