Public Class Form1

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim p As System.Diagnostics.Process =
            System.Diagnostics.Process.Start("taskkill", "/IM itunes.exe")
        Me.Close()
    End Sub
End Class
