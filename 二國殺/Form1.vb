Imports System.ComponentModel

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\7vvfj-pmu2p.wav", AudioPlayMode.Background)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        player1.URL = My.Application.Info.DirectoryPath & "\三国杀OST长安Hi-Res百万级录音棚试听 [TubeRipper.com].wav"
        player1.settings.setMode("loop", True)
        player1.controls.play()
    End Sub

End Class
