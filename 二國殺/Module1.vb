Module Module1
    Public se As Boolean = True
    Public music As Boolean = True
    Public player1 As New WMPLib.WindowsMediaPlayer
    Public player2 As New WMPLib.WindowsMediaPlayer
    Public cha(2) As Integer
    Public voice As Integer
    Public bgi As Integer = 0
    Public Sub 按鈕音效()
        If se = True Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\z8y42-o9b8u.wav", AudioPlayMode.Background)
        End If
    End Sub
    Public Sub 重要按鈕音效()
        If se = True Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\7vvfj-pmu2p.wav", AudioPlayMode.Background)
        End If
    End Sub

    Public Sub 奸雄()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\奸雄1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\奸雄2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 鐵騎()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\鐵騎1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\鐵騎2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 武聖()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\武聖1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\武聖2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 無雙()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\無雙1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\無雙2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 英姿()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\英姿1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\英姿2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 反間()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\反間1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\反間2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 苦肉()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\苦肉1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\苦肉2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 集智()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\集智1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\集智2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 觀星()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\觀星1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\觀星2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 空城()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\空城1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\空城2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 烈弓()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\烈弓1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\烈弓2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 咆嘯()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\咆哮1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\咆哮2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 破軍()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\大敗而歸.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\犯疆土.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub

    Public Sub 連營()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\連營1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\連營2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 仁德()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\仁德1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\仁德2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 遺計()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\遺計1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\遺計2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 天妒()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\天妒1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\天妒2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 龍膽()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\龍膽1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\龍膽2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 制衡()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\制衡1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\制衡2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 鬼才()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\鬼才1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\鬼才2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 反饋()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\反饋1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\反饋2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Public Sub 克己()
        If se = True Then
            Randomize()
            voice = Int(Rnd() * 2)
            If voice = 0 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\克己1.wav", AudioPlayMode.Background)
            ElseIf voice = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\克己2.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
End Module
