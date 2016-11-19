Public Class App
    Dim ImageName As String = "itunes"
    Dim ImageNameExt As String = ImageName + ".exe"

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        QuitApp()
    End Sub

    Private Sub KillBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles KillBtn.LinkClicked
        iTunesKill()
        QuitApp()
    End Sub

    ' タイマー起動時に実行する処理
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        iTunesKill()
        QuitApp()
    End Sub

    ' Killコマンド
    Private Sub iTunesKill()
        Dim p As System.Diagnostics.Process =
            Process.Start("taskkill", "/IM " + ImageNameExt)
    End Sub

    ' アプリケーションの終了
    Public Sub QuitApp()
        Application.Exit()
    End Sub

    ' iTunesが起動しているか確認する関数
    Public Function iTunesState()
        If Process.GetProcessesByName(ImageName).Length <> 0 Then
            Return True ' 起動していればTrue
        End If
        Return False ' 起動していなければFalse
    End Function

End Class
