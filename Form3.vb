Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnect()
        loadDepartment()
        loadrecord()

        With dgvinfo
            .AutoResizeColumns()
            .allowusertoaddrows = False
            .allowusertodeleterows = False
            .allowusertoresizecolumns = False
            .allowusertoresizerows = False
            .RowsDefaultCellStyle.BackColor = Color.Blue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue


        End With
    End Sub



    Private Sub btndispaly_Click(sender As Object, e As EventArgs) Handles btndispaly.Click
        If Cbodept.SelectedIndex = 0 Then
            loadrec("101")
        ElseIf Cbodept.SelectedIndex = 1 Then
            loadrec("102")
        ElseIf Cbodept.SelectedIndex = 2 Then
            loadrec("103")
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class