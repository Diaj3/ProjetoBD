Public Class MainPage
    Private Sub buttonManager_Click(sender As Object, e As EventArgs) Handles buttonManager.Click
        Managerf.Show()
        Me.Hide()
    End Sub

    Private Sub buttonCustomer_Click(sender As Object, e As EventArgs) Handles buttonCustomer.Click
        Customerf.Show()
        Me.Hide()
    End Sub

    Private Sub Employ_Click(sender As Object, e As EventArgs) Handles Employ.Click
        Employf.Show()
        Me.Hide()
    End Sub

End Class
