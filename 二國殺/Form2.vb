Public Class Form2
    Dim times As Integer = 0
    Dim anounce As Integer = 0
    Dim pages As Integer = 1
    Public Sub 隱藏按鈕()
        Button1.Visible = False
        Button6.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox3.Visible = False
    End Sub
    Public Sub 顯示按鈕()
        Button1.Visible = True
        Button6.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        PictureBox3.Visible = True
    End Sub
    Public Sub 儲值按鈕()
        Button2.Visible = True
        Button10.Visible = True
        Button11.Visible = True
        Button12.Visible = True
        Button13.Visible = True
        Button14.Visible = True
        Button15.Visible = True
    End Sub
    Public Sub 隱藏儲值按鈕()
        Button2.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button15.Visible = False
    End Sub
    Public Sub 儲值訊息()
        MsgBox("若要儲值，請交給101洪東宇或張兆毅同學", 0 + 64, "感謝你的貢獻")
    End Sub
    Public Sub 背景勾勾重製()
        Button20.BackgroundImage = PictureBox20.Image
        Button21.BackgroundImage = PictureBox21.Image
        Button22.BackgroundImage = PictureBox22.Image
        Button23.BackgroundImage = PictureBox23.Image
    End Sub
    Public Sub 設定按鈕()
        Button16.Visible = True
        Button17.Visible = True
        Button18.Visible = True
        Button19.Visible = True
        Button10.Visible = True
        PictureBox9.Visible = True
        PictureBox7.Visible = True
        Button16.BackgroundImage = PictureBox11.Image
        Button17.BackgroundImage = PictureBox10.Image
    End Sub
    Public Sub 隱藏設定按鈕()
        PictureBox7.Visible = False
        For i = 16 To 23
            CType(Me.Controls.Find("Button" & i.ToString(), True)(0), Button).Visible = False
        Next
        Button10.Visible = False
        PictureBox9.Visible = False
    End Sub
    Public Sub 背景選擇文字()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
    End Sub
    Public Sub 隱藏背景選擇文字()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub
    Public Sub 背景()
        Button20.Visible = True
        Button21.Visible = True
        Button22.Visible = True
        Button23.Visible = True
    End Sub
    Public Sub 隱藏背景()
        Button20.Visible = False
        Button21.Visible = False
        Button22.Visible = False
        Button23.Visible = False
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '背景
        PictureBox4.Image = PictureBox20.Image
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '儲值按鈕
        If se = True Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\儲值.wav", AudioPlayMode.Background)
        End If
        If PictureBox4.Image Is PictureBox20.Image Then
            PictureBox1.Image = PictureBox2.Image
        ElseIf PictureBox4.Image Is PictureBox21.Image Then
            PictureBox1.Image = PictureBox29.Image
        ElseIf PictureBox4.Image Is PictureBox22.Image Then
            PictureBox1.Image = PictureBox28.Image
        ElseIf PictureBox4.Image Is PictureBox23.Image Then
            PictureBox1.Image = PictureBox27.Image
        End If
        Call 隱藏按鈕()
        Call 儲值按鈕()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    '儲值金額
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call 儲值訊息()
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Call 儲值訊息()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Call 儲值訊息()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Call 儲值訊息()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Call 儲值訊息()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("快交給101洪東宇或張兆毅同學!!!", 0 + 64, "真的假的，這麼多")
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '客服
        Call 按鈕音效()
        MsgBox("追蹤我們的ig帳號，kidr.k，dzgc16_zyc", 0 + 64, "支持我們")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '退出遊戲
        Call 按鈕音效()
        Me.Close()
        player1.close()
        Form1.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '退出
        Call 按鈕音效()
        Call 顯示按鈕()
        Call 隱藏儲值按鈕()
        Call 隱藏設定按鈕()
        Call 隱藏背景選擇文字()
        PictureBox1.Image = PictureBox4.Image
        PictureBox31.Visible = False
        Button24.Visible = False
        Button25.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '設定
        Call 按鈕音效()
        Call 隱藏按鈕()
        Call 背景()
        Call 背景選擇文字()
        Call 設定按鈕()
        Call 隱藏背景()
        Call 隱藏背景選擇文字()
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Call 按鈕音效()
        PictureBox7.Image = PictureBox8.Image
        Call 背景()
        Button17.BackgroundImage = PictureBox13.Image
        PictureBox9.Visible = False
        Button18.Visible = False
        Button19.Visible = False
        Button16.BackgroundImage = PictureBox12.Image
        Call 背景選擇文字()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Call 按鈕音效()
        Button17.BackgroundImage = PictureBox10.Image
        PictureBox9.Visible = True
        Button18.Visible = True
        Button19.Visible = True
        Button16.BackgroundImage = PictureBox11.Image
        Call 隱藏背景()
        PictureBox7.Image = PictureBox14.Image
        Call 隱藏背景選擇文字()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        '音效
        Call 按鈕音效()
        If se = True Then
            Button18.BackgroundImage = PictureBox15.Image
            se = False
        Else
            Button18.BackgroundImage = PictureBox18.Image
            se = True
            Call 按鈕音效()
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        '音樂
        Call 按鈕音效()
        If music = True Then
            Button19.BackgroundImage = PictureBox17.Image
            music = False
            player1.controls.stop()
        ElseIf music = False Then
            Button19.BackgroundImage = PictureBox16.Image
            music = True
            player1.controls.play()
        End If
    End Sub

    '選背景按鈕
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If PictureBox4.Image IsNot PictureBox20.Image Then
            Call 按鈕音效()
            PictureBox4.Image = PictureBox20.Image
            Call 背景勾勾重製()
            Button20.BackgroundImage = PictureBox19.Image
            PictureBox1.Image = PictureBox4.Image
            bgi = 0
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If PictureBox4.Image IsNot PictureBox22.Image Then
            Call 按鈕音效()
            PictureBox4.Image = PictureBox22.Image
            Call 背景勾勾重製()
            Button22.BackgroundImage = PictureBox26.Image
            PictureBox1.Image = PictureBox4.Image
            bgi = 1
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If PictureBox4.Image IsNot PictureBox23.Image Then
            Call 按鈕音效()
            PictureBox4.Image = PictureBox23.Image
            Call 背景勾勾重製()
            Button23.BackgroundImage = PictureBox25.Image
            PictureBox1.Image = PictureBox4.Image
            bgi = 2
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If PictureBox4.Image IsNot PictureBox21.Image Then
            Call 按鈕音效()
            PictureBox4.Image = PictureBox21.Image
            Call 背景勾勾重製()
            Button21.BackgroundImage = PictureBox24.Image
            PictureBox1.Image = PictureBox4.Image
            bgi = 3
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        '公告
        Call 按鈕音效()
        times += 1
        If times <= 10 Then
            Randomize()
            anounce = Int(Rnd() * (9))
            If anounce = 0 Then
                MsgBox("根據英國研究報導，台灣人通常在晚上休息，而同一時間的美國人則不會", 0 + 64, "快報，快報")
            ElseIf anounce = 1 Then
                MsgBox("根據權威機構說明，天秤座的媽媽碰上母親節，通常在禮拜日", 0 + 64, "號外，號外")
            ElseIf anounce = 2 Then
                MsgBox("根據相關機構說明，射手座的人可以喝岩漿，但只能喝一次", 0 + 64, "頭條，頭條")
            ElseIf anounce = 3 Then
                MsgBox("根據可信人士所說，處女座的男生100%不會是處女", 0 + 64, "號外，號外")
            ElseIf anounce = 4 Then
                MsgBox("民間流傳，有些人外表看起來堅強，但他們被車撞還是會受傷", 0 + 64, "急訊，急訊")
            ElseIf anounce = 5 Then
                MsgBox("不要小看邊緣人，當他們不說話的時候，就是他們安靜的時候", 0 + 64, "快報，快報")
            ElseIf anounce = 6 Then
                MsgBox("老師說，一邊做數學一邊罵髒話的行為，能視為在對數學dirty talk", 0 + 64, "頭條，頭條")
            ElseIf anounce = 7 Then
                MsgBox("國外媒體報導，水瓶座的人熬夜會很晚睡，不熬夜時會早一點睡", 0 + 64, "急訊，急訊")
            ElseIf anounce = 8 Then
                MsgBox("驚為天人!!!據傳，雙魚座洗澡從不穿衣服!", 0 + 64, "快報，快報")
            End If
        ElseIf times = 11 Then
            MsgBox("欸不是，幹話你也可以點10次，多做點有意義的事吧", 0 + 64, "來自製作人的慰問")
        ElseIf times <= 30 And times >= 12 Then
            MsgBox("真的沒了，想不到了", 0 + 64, "江郎才盡")
        ElseIf times = 31 Then
            MsgBox("算你厲害", 0 + 64, "6")
            Button3.BackgroundImage = PictureBox30.Image
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '遊戲說明
        Call 按鈕音效()
        Call 隱藏按鈕()
        Button24.Visible = True
        Button25.Visible = True
        Button25.Visible = False
        PictureBox31.Visible = True
        pages = 1
        PictureBox31.Image = CType(Me.Controls.Find("PictureBox" & pages + 31.ToString(), True)(0), PictureBox).Image
        Button10.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call 重要按鈕音效()
        Me.Hide()
        player1.controls.stop()
        Form3.Show()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Call 按鈕音效()
        pages += 1
        PictureBox31.Image = CType(Me.Controls.Find("PictureBox" & pages + 31.ToString(), True)(0), PictureBox).Image
        If pages > 10 Then
            Button24.Visible = False
        End If
        If pages > 1 Then
            Button25.Visible = True
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Call 按鈕音效()
        pages -= 1
        PictureBox31.Image = CType(Me.Controls.Find("PictureBox" & pages + 31.ToString(), True)(0), PictureBox).Image
        If pages < 2 Then
            Button25.Visible = False
        End If
        If pages < 11 Then
            Button24.Visible = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox("還沒做完", 0 + 64, "QAQ")
    End Sub
End Class