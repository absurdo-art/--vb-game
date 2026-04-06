Public Class Form3
    Dim stage As Integer = 1
    Dim skill As Integer = 1
    Public Sub 按鈕鎖定()
        For i = 1 To 18
            CType(Me.Controls.Find("Button" & i.ToString(), True)(0), Button).Enabled = True
        Next
        Button19.Visible = True
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '背景
        Me.BackgroundImage = ImageList3.Images(bgi)
        If music = True Then
            player2.URL = My.Application.Info.DirectoryPath & "\三國殺背景音樂之默認 (Sanguosha background music).wav"
            player2.settings.setMode("loop", True)
            player2.controls.play()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call 破軍()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call 仁德()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call 奸雄()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If se = True Then
            Randomize()
            skill = Int(Rnd() * 2)
            If skill = 0 Then
                Call 制衡()
            ElseIf skill = 1 Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\好舒服啊.wav", AudioPlayMode.Background)
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call 龍膽()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call 鐵騎()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call 烈弓()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call 咆嘯()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call 武聖()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If se = True Then
            Randomize()
            skill = Int(Rnd() * 2)
            If skill = 0 Then
                Call 英姿()
            ElseIf skill = 1 Then
                Call 反間()
            End If
        End If
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call 連營()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call 克己()
    End Sub
    Private Sub Butto13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Call 鬼才()
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Call 遺計()
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Call 觀星()
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Call 集智()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Call 苦肉()
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Call 無雙()
    End Sub
    Private Sub A1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button17.Click, Button18.Click
        If stage = 1 Then
            Call 按鈕鎖定()
            CType(sender, Button).Enabled = False
            cha(0) = Val(CType(sender, Button).Tag)
            PictureBox5.Image = ImageList1.Images(cha(0))
            PictureBox12.Image = ImageList2.Images(cha(0))
        End If
        If stage = 2 Then
            If cha(0) = Val(CType(sender, Button).Tag) Then
                MsgBox("不能選擇同一隻角色!!!", 0 + 64, "注意")
            Else
                Call 按鈕鎖定()
                CType(sender, Button).Enabled = False
                cha(1) = CType(sender, Button).Tag
                PictureBox6.Image = ImageList1.Images(cha(1))
                PictureBox10.Image = ImageList2.Images(cha(1))
            End If
        End If
    End Sub


    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        '繼續按鍵
        If stage = 1 Then
            Call 按鈕音效()
            PictureBox8.Visible = False
            Button19.Text = "開始"
            Button20.Visible = True
            Button19.Visible = False
            stage = 2
        ElseIf stage = 2 Then
            Call 重要按鈕音效()
            Me.Close()
            Form4.Show()
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Call 按鈕音效()
        PictureBox6.Image = PictureBox11.Image
        PictureBox8.Visible = True
        Button19.Text = "確認"
        Button20.Visible = False
        Button19.Visible = True
        PictureBox10.Image = ImageList2.Images(18)
        stage = 1
    End Sub


    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub
End Class