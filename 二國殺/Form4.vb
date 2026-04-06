Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Timers

Public Class Form4
    Dim setting As Boolean = True
    Dim back As Integer

    Dim abi(2) As Integer
    Dim abi_up(2) As Integer
    Dim power(2) As Integer
    Dim game As Integer = 1 '遊戲換誰
    Dim 觀星偵測 As Boolean = False
    Dim 觀星點數 As Integer = 0
    Dim 觀星減少 As Boolean = False
    Dim 樂(2) As Boolean
    Dim 兵(2) As Boolean
    Dim 閃(2) As Boolean
    Dim point As Integer
    Dim point_all As Integer = 0
    Dim 總判定 As Boolean
    Dim 判定中 As Boolean
    Dim 判定次數 As Integer
    Dim 鬼才偵測 As Boolean = False
    Dim 樂生效 As Boolean = False
    Dim 兵生效 As Boolean = False
    Dim 瀕死執行 As Boolean = False
    Dim list As Integer = 0
    Dim kill(2) As Integer
    Dim kill_up(2) As Integer
    Dim damage As Integer
    Dim beer As Integer
    Dim death As Integer = 0
    Dim champion As Integer
    Dim 元素傷害 As Boolean = False
    Dim 諸葛弩(2) As Boolean
    Dim 八卦(2) As Boolean
    Dim 藤甲(2) As Boolean
    Dim 過河拆橋 As Boolean = False
    Dim 誰過拆 As Integer = 0
    Dim 順手牽羊 As Boolean = False
    Dim 南蠻中(2) As Boolean
    Dim 無懈 As Integer
    Dim 無懈回傳 As Integer
    Dim 鬼才數 As Integer
    Dim 無雙中 As Boolean = False
    Dim 無雙次數 As Integer
    Dim 打出殺過 As Boolean
    Dim 反間過 As Boolean = False
    Dim 反間中 As Boolean = False
    Dim 反間1 As Integer
    Dim 反間2 As Integer
    Dim 反間確認 As Boolean
    Dim 反間確認2 As Boolean
    Dim 破軍點數 As Integer = 0
    Dim armor(2) As Integer
    Dim 制衡過 As Boolean = False
    Dim 鐵騎結果 As Boolean
    Dim 空城中(2) As Boolean
    Dim 仁德過 As Boolean = False
    Public Sub 角色初始化()
        For i = 0 To 1
            For j = 0 To 17
                If cha(i) = j Then
                    CType(Me.Controls.Find("PictureBox" & i + 2.ToString(), True)(0), PictureBox).Image = ImageList3.Images(j)
                End If
            Next
            power(i) = 5
        Next
        For i = 0 To 1
            If cha(i) = 0 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "曹操"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "奸雄"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 1 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "馬超"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "鐵騎,馬術"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 2 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "關羽"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "武聖"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 3 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "呂布"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "無雙"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 4 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "周瑜"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "英姿"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Text = "反間"
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Visible = True
                If i = 0 Then
                    Label34.Visible = True
                End If
                abi_up(i) = 3
            End If
            If cha(i) = 5 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "黃蓋"
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Text = "苦肉"
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Visible = True
                If i = 0 Then
                    Label34.Visible = True
                End If
                abi_up(i) = 4
            End If
            If cha(i) = 6 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "黃月英"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "奇才,集智"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 3
            End If
            If cha(i) = 7 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "諸葛亮"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "觀星,空城"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 3
            End If
            If cha(i) = 8 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "黃忠"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "烈弓"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 9 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "張飛"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "咆哮"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 10 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "界徐盛"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "破軍"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 11 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "陸遜"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "謙遜,連營"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 3
            End If
            If cha(i) = 12 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "劉備"
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Text = "仁德"
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Visible = True
                If i = 0 Then
                    Label34.Visible = True
                End If
                abi_up(i) = 4
            End If
            If cha(i) = 13 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "郭嘉"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "天妒,遺計"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 3
            End If
            If cha(i) = 14 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "趙雲"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "龍膽"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If
            If cha(i) = 15 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "孫權"
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Text = "制衡"
                CType(Me.Controls.Find("Label" & i + 17.ToString(), True)(0), Label).Visible = True
                If i = 0 Then
                    Label34.Visible = True
                End If
                abi_up(i) = 4
            End If
            If cha(i) = 16 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "司馬懿"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "鬼才,反饋"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 3
            End If
            If cha(i) = 17 Then
                CType(Me.Controls.Find("Label" & i + 1.ToString(), True)(0), Label).Text = "呂蒙"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Text = "克己"
                CType(Me.Controls.Find("Label" & i + 4.ToString(), True)(0), Label).Visible = True
                abi_up(i) = 4
            End If

            If abi_up(i) = 4 Then
                CType(Me.Controls.Find("PictureBox" & i + 6.ToString(), True)(0), PictureBox).Visible = True
            End If
            abi(i) = abi_up(i)
        Next

    End Sub
    Public Sub 暫停()
        Thread.Sleep(2000)
    End Sub
    Public Sub 資訊重製()
        For i = 13 To 16
            CType(Me.Controls.Find("Label" & i.ToString(), True)(0), Label).Text = "-"
        Next
    End Sub
    Public Sub 一判()
        Label13.Text = "進行一次判定"
        Label13.Refresh()
        Thread.Sleep(2000)
        總判定 = True
        判定次數 = 0
        Randomize()
        point = Int(Rnd() * 2)
        If point = 0 Then
            判定中 = False
        ElseIf point = 1 Then
            判定中 = True
        End If
        If 判定中 = False Then
            判定次數 += 1
            Label13.Text = "第1次判定:失敗"
            Label13.Refresh()
        Else
            Label13.Text = "第1次判定:成功"
            Label13.Refresh()
        End If
        If cha(0) = 16 Or cha(1) = 16 Then
            鬼才數 = 鬼才中()
            If 鬼才數 = 0 Then
                Label13.Text = "第1次判定:成功"
                Label13.Refresh()
                If 判定次數 >= 1 Then
                    判定次數 -= 1
                End If
            ElseIf 鬼才數 = 1 Then
                判定次數 += 1
                Label13.Text = "第1次判定:失敗"
                Label13.Refresh()
            End If
        End If
        Thread.Sleep(2000)
        If 判定次數 = 1 Then
            總判定 = False
        End If
    End Sub
    Public Sub 二判()
        Label13.Text = "進行兩次判定"
        Label13.Refresh()
        Thread.Sleep(2000)
        總判定 = True
        判定次數 = 0
        For i = 1 To 2
            Randomize()
            point = Int(Rnd() * 2)
            If point = 0 Then
                判定中 = False
            ElseIf point = 1 Then
                判定中 = True
            End If
            If 判定中 = False Then
                判定次數 += 1
                Label13.Text = "第" & i & "次判定:失敗"
                Label13.Refresh()
            Else
                Label13.Text = "第" & i & "次判定:成功"
                Label13.Refresh()
            End If
            If cha(0) = 16 Or cha(1) = 16 Then
                鬼才數 = 鬼才中()
                If 鬼才數 = 0 Then
                    Label13.Text = "第" & i & "次判定:成功"
                    Label13.Refresh()
                    If 判定次數 >= 1 Then
                        判定次數 -= 1
                    End If
                ElseIf 鬼才數 = 1 Then
                    判定次數 += 1
                    Label13.Text = "第" & i & "次判定:失敗"
                    Label13.Refresh()
                End If
            End If
            Thread.Sleep(2000)
        Next
        If 判定次數 = 2 Then
            總判定 = False
        End If
    End Sub
    Public Sub 三判()
        Label13.Text = "進行三次判定"
        Label13.Refresh()
        Thread.Sleep(2000)
        總判定 = True
        判定次數 = 0
        For i = 1 To 3
            Randomize()
            point = Int(Rnd() * 2)
            If point = 0 Then
                判定中 = False
            ElseIf point = 1 Then
                判定中 = True
            End If
            If 判定中 = False Then
                判定次數 += 1
                Label13.Text = "第" & i & "次判定:成功"
                Label13.Refresh()
            Else
                Label13.Text = "第" & i & "次判定:失敗"
                Label13.Refresh()
            End If
            If cha(0) = 16 Or cha(1) = 16 Then
                鬼才數 = 鬼才中()
                If 鬼才數 = 0 Then
                    Label13.Text = "第" & i & "次判定:成功"
                    Label13.Refresh()
                    判定次數 += 1

                ElseIf 鬼才數 = 1 Then
                    If 判定次數 >= 1 Then
                        判定次數 -= 1
                    End If
                    Label13.Text = "第" & i & "次判定:失敗"
                    Label13.Refresh()
                End If
            End If
            Thread.Sleep(2000)
        Next
        If 判定次數 = 3 Then
            總判定 = False
        End If
    End Sub
    Public Function 鬼才中()
        鬼才數 = MsgBox("是否使用鬼才使判定成功/失敗/取消", 3 + 64, "司馬懿")
        If 鬼才數 = 6 Then
            If cha(0) = 16 Then
                If power(0) >= 2 Then
                    power(0) -= 2
                    Call 鬼才()
                    Label16.Text = "司馬懿發動技能:鬼才"
                    Label16.Refresh()
                    Call 暫停()
                    Return 0
                Else
                    Label13.Text = "能量不足"
                    Call 暫停()
                    Return 2
                End If
            ElseIf cha(1) = 16 Then
                If power(1) >= 2 Then
                    power(1) -= 2
                    Call 鬼才()
                    Label16.Text = "司馬懿發動技能:鬼才"
                    Label16.Refresh()
                    Call 暫停()
                    Return 0
                Else
                    Label13.Text = "能量不足"
                    Call 暫停()
                    Return 2
                End If
            End If
        ElseIf 鬼才數 = 7 Then
            If cha(0) = 16 Then
                If power(0) >= 2 Then
                    power(0) -= 2
                    Call 鬼才()
                    Label16.Text = "司馬懿發動技能:鬼才"
                    Label16.Refresh()
                    Call 暫停()
                    Return 1
                Else
                    Label13.Text = "能量不足"
                    Call 暫停()
                    Return 2
                End If
            ElseIf cha(1) = 16 Then
                If power(1) >= 2 Then
                    power(1) -= 2
                    Call 鬼才()
                    Label16.Text = "司馬懿發動技能:鬼才"
                    Label16.Refresh()
                    Call 暫停()
                    Return 1
                Else
                    Label13.Text = "能量不足"
                    Call 暫停()
                    Return 2
                End If
            End If
        Else
            Return 2
        End If
    End Function
    Public Sub 瀕死()
        Call 資訊重製()
        Label13.Text = "P" & death & "進入瀕死狀態!!!"
        Label15.Text = "你生命危急，需要    " & 1 - abi(death - 1) & "個酒?"
        PictureBox18.Visible = False
        Label21.Visible = False
        If death = 1 Then
            Label22.Visible = True
        ElseIf death = 2 Then
            PictureBox40.Visible = True
        End If
    End Sub

    Public Sub 勝利()
        If se = True Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\獲勝.wav", AudioPlayMode.Background)
        End If
        PictureBox46.Visible = True
        PictureBox47.Visible = True
        PictureBox47.Image = ImageList3.Images(cha(champion - 1))
        Label54.Visible = True
        Label54.Text = "Player" & champion & "獲勝!!!"
        Button1.Visible = True
        Me.BackgroundImage = PictureBox45.Image
        PictureBox45.Visible = True
        For i = 22 To 30
            CType(Me.Controls.Find("Label" & i.ToString(), True)(0), Label).Visible = False
            CType(Me.Controls.Find("Label" & i.ToString(), True)(0), Label).Refresh()
        Next
        Label17.Visible = False
        Label17.Refresh()
        Label18.Visible = False
        Label18.Refresh()
        PictureBox40.Visible = False
        PictureBox40.Refresh()
    End Sub

    Public Sub 卡牌出現()
        For i = 21 To 39
            CType(Me.Controls.Find("PictureBox" & i.ToString(), True)(0), PictureBox).Visible = True
        Next
        PictureBox20.Visible = True
    End Sub
    Public Sub 卡牌消失()
        For i = 20 To 39
            CType(Me.Controls.Find("PictureBox" & i.ToString(), True)(0), PictureBox).Visible = False
        Next
        For i = 35 To 53
            CType(Me.Controls.Find("Label" & i.ToString(), True)(0), Label).Visible = False
        Next
    End Sub

    Public Sub 過拆中()
        If 誰過拆 = 1 Then
            If 諸葛弩(0) = True Then
                PictureBox42.Visible = True
            End If
            If 八卦(0) Then
                PictureBox43.Visible = True
                PictureBox43.Image = ImageList6.Images(2)
            ElseIf 藤甲(0) Then
                PictureBox43.Visible = True
                PictureBox43.Image = ImageList6.Images(36)
            End If
        ElseIf 誰過拆 = 2 Then
            Label31.Visible = True
            If 諸葛弩(1) = True Then
                PictureBox42.Visible = True
                Label32.Visible = True
            End If
            If 八卦(1) Then
                PictureBox43.Visible = True
                Label33.Visible = True
                PictureBox43.Image = ImageList6.Images(2)
            ElseIf 藤甲(1) Then
                PictureBox43.Visible = True
                Label33.Visible = True
                PictureBox43.Image = ImageList6.Images(36)
            End If
        End If
        PictureBox44.Visible = True
        PictureBox41.Visible = True
    End Sub

    Public Sub 過拆結束()
        For i = 41 To 44
            CType(Me.Controls.Find("PictureBox" & i.ToString(), True)(0), PictureBox).Visible = False
        Next
        For i = 31 To 33
            CType(Me.Controls.Find("Label" & i.ToString(), True)(0), Label).Visible = False
        Next
        過河拆橋 = False
        順手牽羊 = False
        If 誰過拆 = 1 Then
            PictureBox18.Visible = True
        Else
            Label21.Visible = True
        End If
        誰過拆 = 0
    End Sub

    Public Function 無懈1()
        無懈 = MsgBox("是否使用無懈可擊", 4 + 64, "Player1")
        If 無懈 = 6 Then
            If power(0) >= 3 Then
                power(0) -= 3
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\無懈可擊.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                無懈回傳 = 無懈2()
                If 無懈回傳 = False Then
                    Return True
                Else
                    Return False
                End If
            Else
                Label13.Text = "能量不足"
                Call 暫停()
                Return False
            End If
        ElseIf 無懈 = 7 Then
            Return False
        End If
    End Function
    Public Function 無懈2()
        無懈 = MsgBox("是否使用無懈可擊", 4 + 64, "Player2")
        If 無懈 = 6 Then
            If power(1) >= 3 Then
                power(1) -= 3
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\無懈可擊.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                無懈回傳 = 無懈1()
                If 無懈回傳 = False Then
                    Return True
                Else
                    Return False
                End If
            Else
                Label13.Text = "能量不足"
                Call 暫停()
                Return False
            End If
        ElseIf 無懈 = 7 Then
            Return False
        End If
    End Function
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        If se = True Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\開戰.wav", AudioPlayMode.Background)
        End If
        '背景
        PictureBox14.Image = ImageList5.Images(bgi)

        Call 角色初始化()
        For i = 0 To 1
            樂(i) = False
            兵(i) = False
            閃(i) = False
            death = 0
            諸葛弩(i) = False
            八卦(i) = False
            藤甲(i) = False
            南蠻中(i) = False
            空城中(i) = False
        Next
        Timer2.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        '退出
        Call 重要按鈕音效()
        back = MsgBox("是否要回到主畫面?", 1 + 64, "退出")
        If back = 1 Then
            Me.Close()
            Form2.Show()
            player2.close()
            If music = True Then
                player1.controls.play()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '體力能量變化
        Label7.Text = abi(0) * 2
        Label10.Text = abi(1) * 2
        Label3.Text = power(0)
        Label8.Text = power(1)
        For i = 1 To 2
            If abi(i - 1) = 4 Then
                CType(Me.Controls.Find("PictureBox" & i + 5.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
                CType(Me.Controls.Find("PictureBox" & i + 7.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
                CType(Me.Controls.Find("PictureBox" & i + 9.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
                CType(Me.Controls.Find("PictureBox" & i + 11.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
            End If
            If abi(i - 1) = 3 Then
                CType(Me.Controls.Find("PictureBox" & i + 5.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 7.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
                CType(Me.Controls.Find("PictureBox" & i + 9.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
                CType(Me.Controls.Find("PictureBox" & i + 11.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
            End If
            If abi(i - 1) = 2 Then
                CType(Me.Controls.Find("PictureBox" & i + 5.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 7.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 9.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
                CType(Me.Controls.Find("PictureBox" & i + 11.ToString(), True)(0), PictureBox).Image = ImageList2.Images(2)
            End If
            If abi(i - 1) = 1 Then
                CType(Me.Controls.Find("PictureBox" & i + 5.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 7.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 9.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 11.ToString(), True)(0), PictureBox).Image = ImageList2.Images(1)
            End If
            If abi(i - 1) <= 0 Then
                CType(Me.Controls.Find("PictureBox" & i + 5.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 7.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 9.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                CType(Me.Controls.Find("PictureBox" & i + 11.ToString(), True)(0), PictureBox).Image = ImageList2.Images(0)
                If 瀕死執行 = False Then
                    瀕死執行 = True
                    death = i
                    Call 瀕死()
                End If
            End If
        Next
    End Sub

    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '鍵盤事件
        If 觀星偵測 = True Then
            If game = 1 Then
                If e.KeyCode = Keys.D4 Then
                    觀星點數 = 4
                    觀星偵測 = False
                    Timer4.Enabled = True
                ElseIf e.KeyCode = Keys.D5 Then
                    觀星點數 = 5
                    觀星偵測 = False
                    Timer4.Enabled = True
                ElseIf e.KeyCode = Keys.D6 Then
                    觀星點數 = 6
                    觀星偵測 = False
                    Timer4.Enabled = True
                End If
            Else
                If e.KeyCode = Keys.NumPad4 Then
                    觀星點數 = 4
                    觀星偵測 = False
                    Timer4.Enabled = True
                ElseIf e.KeyCode = Keys.NumPad5 Then
                    觀星點數 = 5
                    觀星偵測 = False
                    Timer4.Enabled = True
                ElseIf e.KeyCode = Keys.NumPad6 Then
                    觀星點數 = 6
                    觀星偵測 = False
                    Timer4.Enabled = True
                End If
            End If
        End If

        '開啟選單
        If e.KeyCode = Keys.Escape And list = 0 Then
            list = 1
            For i = 35 To 53
                CType(Me.Controls.Find("Label" & i.ToString(), True)(0), Label).Visible = True
            Next
            Call 卡牌出現()
            Label19.Text = "按esc關閉選單"
        ElseIf e.KeyCode = Keys.Escape And list = 1 Then
            list = 0
            Call 卡牌消失()
            Label19.Text = "按esc開啟選單"
        End If
        '結束出牌
        If Label21.Visible = True Then
            If e.KeyCode = Keys.Space Then
                Timer10.Enabled = True
                Label21.Visible = False
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
            End If
        End If

        '殺
        If e.KeyCode = Keys.D1 Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And 南蠻中(0) = False And 反間中 = False And game = 1 And 空城中(1) = False And cha(0) <> 14 And cha(0) <> 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.WaitToComplete)
                End If
                Call 暫停()
                If cha(game - 1) = 9 Then
                    Call 咆嘯()
                    Label16.Text = "張飛發動技能:咆哮"
                    Label16.Refresh()
                ElseIf cha(game - 1) = 3 Then
                    Call 無雙()
                    Label16.Text = "呂布發動技能:無雙"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    無雙中 = True
                    無雙次數 = 0
                ElseIf cha(game - 1) = 10 Then
                    Call 破軍()
                    Label16.Text = "界徐盛發動技能:破軍"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    If power(1) > 2 * abi(1) Then
                        破軍點數 += 2 * abi(1)
                        power(1) -= 2 * abi(1)
                    Else
                        破軍點數 += power(1)
                        power(1) = 0
                    End If
                ElseIf cha(game - 1) = 1 Then
                    Call 鐵騎()
                    Label16.Text = "馬超發動技能:鐵騎"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    Call 一判()
                    If 總判定 = True Then
                        Label13.Text = "鐵騎:成功"
                        Label13.Refresh()
                        鐵騎結果 = True
                    Else
                        Label13.Text = "鐵騎:失敗"
                        Label13.Refresh()
                        鐵騎結果 = False
                    End If
                    Call 暫停()
                ElseIf cha(game - 1) = 8 And power(1) > abi(0) Then
                    Call 烈弓()
                    Label16.Text = "黃忠發動技能:烈弓"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    Call 暫停()
                Else
                    kill(game - 1) += 1
                End If
                打出殺過 = True
                power(0) -= 2
                damage += 1
                Label21.Visible = False
                If 八卦(1) = True Then
                    If 無雙中 = True Then
                        For i = 1 To 2
                            Call 一判()
                            If 總判定 = True Then
                                Label13.Text = "八卦陣:成功"
                                Label13.Refresh()
                                Call 暫停()
                                If se = True Then
                                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                                End If
                                無雙次數 += 1
                                If 無雙次數 >= 2 Then
                                    Label21.Visible = True
                                    damage = 0
                                    元素傷害 = False
                                    無雙中 = False
                                End If
                            Else
                                Label13.Text = "八卦陣:失敗"
                                Label13.Refresh()
                                Call 暫停()
                                PictureBox40.Visible = True
                                Timer14.Enabled = True
                                Exit For
                            End If
                        Next
                    Else
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                Label21.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            PictureBox40.Visible = True
                            Timer14.Enabled = True
                        End If
                    End If
                ElseIf 藤甲(1) = True Then
                    Label13.Text = "藤甲免疫一般殺"
                    Label13.Refresh()
                    Label21.Visible = True
                    damage = 0
                    元素傷害 = False
                Else
                    PictureBox40.Visible = True
                    Timer14.Enabled = True
                End If
                If cha(0) = 1 And 鐵騎結果 = True Or cha(game - 1) = 8 And power(1) > abi(0) Then
                    Timer14.Enabled = False
                    PictureBox40.Visible = False
                    Label21.Visible = True
                    If 元素傷害 = True Then
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\元素傷害.wav", AudioPlayMode.Background)
                        End If
                        If 藤甲(1) = True Then
                            damage += 1
                        End If
                    Else
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
                        End If
                    End If
                    If cha(0) = 10 Then
                        If power(0) >= power(1) And armor(0) >= armor(1) Then
                            damage += 1
                        End If
                    End If
                    abi(1) -= damage
                    If cha(1) = 16 And power(0) >= 1 Then
                        Call 反饋()
                        Label16.Text = "司馬懿發動技能:反饋"
                        Label16.Refresh()
                        power(1) += 1
                        power(0) -= 1
                        Call 暫停()
                    End If
                    If cha(1) = 0 Then
                        Call 奸雄()
                        Label16.Text = "曹操發動技能:奸雄"
                        Label16.Refresh()
                        power(1) += 2
                        Call 暫停()
                    End If
                    If cha(1) = 13 Then
                        Call 遺計()
                        Label16.Text = "郭嘉發動技能:遺計"
                        Label16.Refresh()
                        power(1) += 1
                        Call 暫停()
                    End If
                    damage = 0
                    元素傷害 = False
                End If
            ElseIf Label14.Text = "P" & game & "出牌階段" And list = 1 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 1 And 南蠻中(0) = False And 反間中 = False And game = 1 And 空城中(1) = False And cha(0) = 14 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                kill(game - 1) += 1
                打出殺過 = True
                power(0) -= 1
                damage += 1
                Label21.Visible = False
                Call 龍膽()
                Label16.Text = "趙雲發動技能:龍膽"
                Label16.Refresh()
                If 八卦(1) = True Then
                    If 無雙中 = True Then
                        For i = 1 To 2
                            Call 一判()
                            If 總判定 = True Then
                                Label13.Text = "八卦陣:成功"
                                Label13.Refresh()
                                Call 暫停()
                                If se = True Then
                                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                                End If
                                無雙次數 += 1
                                If 無雙次數 >= 2 Then
                                    Label21.Visible = True
                                    damage = 0
                                    元素傷害 = False
                                    無雙中 = False
                                End If
                            Else
                                Label13.Text = "八卦陣:失敗"
                                Label13.Refresh()
                                Call 暫停()
                                PictureBox40.Visible = True
                                Timer14.Enabled = True
                                Exit For
                            End If
                        Next
                    Else
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                Label21.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            PictureBox40.Visible = True
                            Timer14.Enabled = True
                        End If
                    End If
                ElseIf 藤甲(1) = True Then
                    Label13.Text = "藤甲免疫一般殺"
                    Label13.Refresh()
                    Label21.Visible = True
                    damage = 0
                    元素傷害 = False
                Else
                    PictureBox40.Visible = True
                    Timer14.Enabled = True
                End If
            ElseIf Label14.Text = "P" & game & "出牌階段" And list = 1 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 1 And 南蠻中(0) = False And 反間中 = False And game = 1 And 空城中(1) = False And cha(0) = 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                kill(game - 1) += 1
                打出殺過 = True
                power(0) -= 1
                damage += 1
                Label21.Visible = False
                Call 武聖()
                Label16.Text = "關羽發動技能:武聖"
                Label16.Refresh()
                If 八卦(1) = True Then
                    If 無雙中 = True Then
                        For i = 1 To 2
                            Call 一判()
                            If 總判定 = True Then
                                Label13.Text = "八卦陣:成功"
                                Label13.Refresh()
                                Call 暫停()
                                If se = True Then
                                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                                End If
                                無雙次數 += 1
                                If 無雙次數 >= 2 Then
                                    Label21.Visible = True
                                    damage = 0
                                    元素傷害 = False
                                    無雙中 = False
                                End If
                            Else
                                Label13.Text = "八卦陣:失敗"
                                Label13.Refresh()
                                Call 暫停()
                                PictureBox40.Visible = True
                                Timer14.Enabled = True
                                Exit For
                            End If
                        Next
                    Else
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                Label21.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            PictureBox40.Visible = True
                            Timer14.Enabled = True
                        End If
                    End If
                ElseIf 藤甲(1) = True Then
                    Label13.Text = "藤甲免疫一般殺"
                    Label13.Refresh()
                    Label21.Visible = True
                    damage = 0
                    元素傷害 = False
                Else
                    PictureBox40.Visible = True
                    Timer14.Enabled = True
                End If
            ElseIf 南蠻中(0) = True And list = 1 And power(0) >= 2 And 反間中 = False And cha(0) <> 14 And cha(0) <> 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                power(0) -= 2
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            ElseIf 南蠻中(0) = True And list = 1 And power(0) >= 1 And 反間中 = False And cha(0) = 14 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                Call 龍膽()
                Label16.Text = "趙雲發動技能:龍膽"
                Label16.Refresh()
                power(0) -= 1
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            ElseIf 南蠻中(0) = True And list = 1 And power(0) >= 1 And 反間中 = False And cha(0) = 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                Call 武聖()
                Label16.Text = "關羽發動技能:武聖"
                Label16.Refresh()
                power(0) -= 1
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            ElseIf 反間中 = True Then
                反間1 = 1
                反間確認 = True
            End If
        End If

        '閃
        If e.KeyCode = Keys.D2 Then
            If Timer14.Enabled = True And list = 1 And power(0) >= 2 And 無雙中 = False And 反間中 = False And cha(0) <> 14 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                power(0) -= 2
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            ElseIf Timer14.Enabled = True And list = 1 And power(0) >= 1 And 無雙中 = False And 反間中 = False And cha(0) = 14 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                Call 龍膽()
                Label16.Text = "趙雲發動技能:龍膽"
                Label16.Refresh()
                power(0) -= 1
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            ElseIf Timer14.Enabled = True And list = 1 And power(0) >= 2 And 無雙中 = True And 反間中 = False And cha(0) <> 14 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                power(0) -= 2
                無雙次數 += 1
                If 無雙次數 >= 2 Then
                    Timer14.Enabled = False
                    Label22.Visible = False
                    PictureBox18.Visible = True
                    damage = 0
                    元素傷害 = False
                    無雙中 = False
                End If
            ElseIf Timer14.Enabled = True And list = 1 And power(0) >= 1 And 無雙中 = True And 反間中 = False And cha(0) = 14 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                Call 龍膽()
                Label16.Text = "趙雲發動技能:龍膽"
                Label16.Refresh()
                power(0) -= 1
                無雙次數 += 1
                If 無雙次數 >= 2 Then
                    Timer14.Enabled = False
                    Label22.Visible = False
                    PictureBox18.Visible = True
                    damage = 0
                    元素傷害 = False
                    無雙中 = False
                End If
            ElseIf 反間中 = True Then
                反間1 = 2
                反間確認 = True
            End If
        End If

        '取消
        If e.KeyCode = Keys.B Then
            If Timer14.Enabled = True Then
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                If 元素傷害 = True Then
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\元素傷害.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                    If 藤甲(0) = True Then
                        damage += 1
                    End If
                Else
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                End If
                If cha(1) = 10 Then
                    If power(1) >= power(0) And armor(1) >= armor(0) Then
                        damage += 1
                    End If
                End If
                abi(0) -= damage
                If cha(0) = 16 And power(1) >= 1 Then
                    Call 反饋()
                    Label16.Text = "司馬懿發動技能:反饋"
                    Label16.Refresh()
                    power(0) += 1
                    power(1) -= 1
                    Call 暫停()
                End If
                If cha(0) = 0 Then
                    Call 奸雄()
                    Label16.Text = "曹操發動技能:奸雄"
                    Label16.Refresh()
                    power(0) += 2
                    Call 暫停()
                End If
                If cha(0) = 13 Then
                    Call 遺計()
                    Label16.Text = "郭嘉發動技能:遺計"
                    Label16.Refresh()
                    power(0) += 1
                    Call 暫停()
                End If
                damage = 0
                元素傷害 = False
            ElseIf death = 1 Then
                champion = 2
                Call 勝利()
            ElseIf 南蠻中(0) = True Then
                南蠻中(0) = False
                Label22.Visible = False
                PictureBox18.Visible = True
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                abi(0) -= damage
                If cha(0) = 16 And power(1) >= 1 Then
                    Call 反饋()
                    Label16.Text = "司馬懿發動技能:反饋"
                    Label16.Refresh()
                    power(0) += 1
                    power(1) -= 1
                    Call 暫停()
                End If
                If cha(0) = 0 Then
                    Call 奸雄()
                    Label16.Text = "曹操發動技能:奸雄"
                    Label16.Refresh()
                    power(0) += 2
                    Call 暫停()
                End If
                If cha(0) = 13 Then
                    Call 遺計()
                    Label16.Text = "郭嘉發動技能:遺計"
                    Label16.Refresh()
                    power(0) += 1
                    Call 暫停()
                End If
                damage = 0
                元素傷害 = False
            End If
        End If

        '桃
        If e.KeyCode = Keys.D3 Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 3 And abi(game - 1) < abi_up(game - 1) And 反間中 = False And game = 1 Then
                power(0) -= 3
                abi(game - 1) += 1
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\桃.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
            ElseIf 反間中 = True Then
                反間1 = 3
                反間確認 = True
            End If
        End If

        '酒
        If e.KeyCode = Keys.D4 Then
            If Label14.Text = "P" & game & "出牌階段" And beer = 0 And power(game - 1) >= 2 And list = 1 And 反間中 = False And game = 1 Then
                power(0) -= 2
                beer += 1
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\酒.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                damage += 1
            ElseIf death = 1 And 反間中 = False Then
                If power(death - 1) >= 2 Then
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\酒.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                    power(0) -= 2
                    abi(death - 1) += 1
                    If abi(death - 1) >= 1 Then
                        瀕死執行 = False
                        If Timer8.Enabled = True Then
                            Call 資訊重製()
                            Label14.Text = "P" & game & "出牌階段"
                            death = 0
                            If game = 1 Then
                                Label21.Visible = True
                            Else
                                PictureBox18.Visible = True
                            End If
                            Label22.Visible = False
                        Else
                            Timer8.Enabled = True
                        End If
                    End If
                End If
            ElseIf 反間中 = True Then
                反間1 = 4
                反間確認 = True
            End If
        End If

        '元素殺
        If e.KeyCode = Keys.D5 Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 3 And 南蠻中(0) = False And game = 1 And 空城中(1) = False And cha(0) <> 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                If cha(game - 1) = 9 Then
                    Call 咆嘯()
                    Label16.Text = "張飛發動技能:咆哮"
                    Label16.Refresh()
                ElseIf cha(game - 1) = 3 Then
                    Call 無雙()
                    Label16.Text = "呂布發動技能:無雙"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    無雙中 = True
                    無雙次數 = 0
                ElseIf cha(game - 1) = 10 Then
                    Call 破軍()
                    Label16.Text = "界徐盛發動技能:破軍"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    If power(1) > 2 * abi(1) Then
                        破軍點數 += 2 * abi(1)
                        power(1) -= 2 * abi(1)
                    Else
                        破軍點數 += power(1)
                        power(1) = 0
                    End If
                ElseIf cha(game - 1) = 1 Then
                    Call 鐵騎()
                    Label16.Text = "馬超發動技能:鐵騎"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    Call 一判()
                    If 總判定 = True Then
                        Label13.Text = "鐵騎:成功"
                        Label13.Refresh()
                        鐵騎結果 = True
                    Else
                        Label13.Text = "鐵騎:失敗"
                        Label13.Refresh()
                        鐵騎結果 = False
                    End If
                    Call 暫停()
                ElseIf cha(game - 1) = 8 And power(1) > abi(0) Then
                    Call 烈弓()
                    Label16.Text = "黃忠發動技能:烈弓"
                    Label16.Refresh()
                    kill(game - 1) += 1
                    Call 暫停()
                Else
                    kill(game - 1) += 1
                End If
                power(0) -= 3
                打出殺過 = True
                damage += 1
                Label21.Visible = False
                元素傷害 = True
                If 八卦(1) = True Then
                    If 無雙中 = True Then
                        For i = 1 To 2
                            Call 一判()
                            If 總判定 = True Then
                                Label13.Text = "八卦陣:成功"
                                Label13.Refresh()
                                Call 暫停()
                                If se = True Then
                                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                                End If
                                無雙次數 += 1
                                If 無雙次數 >= 2 Then
                                    Label21.Visible = True
                                    damage = 0
                                    元素傷害 = False
                                    無雙中 = False
                                End If
                            Else
                                Label13.Text = "八卦陣:失敗"
                                Label13.Refresh()
                                Call 暫停()
                                PictureBox40.Visible = True
                                Timer14.Enabled = True
                                Exit For
                            End If
                        Next
                    Else
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                Label21.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            PictureBox40.Visible = True
                            Timer14.Enabled = True
                        End If
                    End If
                Else
                    PictureBox40.Visible = True
                    Timer14.Enabled = True
                End If
                If cha(0) = 1 And 鐵騎結果 = True Or cha(game - 1) = 8 And power(1) > abi(0) Then
                    Timer14.Enabled = False
                    PictureBox40.Visible = False
                    Label21.Visible = True
                    If 元素傷害 = True Then
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\元素傷害.wav", AudioPlayMode.Background)
                        End If
                        Call 暫停()
                        If 藤甲(1) = True Then
                            damage += 1
                        End If
                    Else
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
                        End If
                        Call 暫停()
                    End If
                    If cha(0) = 10 Then
                        If power(0) >= power(1) And armor(0) >= armor(1) Then
                            damage += 1
                        End If
                    End If
                    abi(1) -= damage
                    If cha(1) = 16 And power(0) >= 1 Then
                        Call 反饋()
                        Label16.Text = "司馬懿發動技能:反饋"
                        Label16.Refresh()
                        power(1) += 1
                        power(0) -= 1
                        Call 暫停()
                    End If
                    If cha(1) = 0 Then
                        Call 奸雄()
                        Label16.Text = "曹操發動技能:奸雄"
                        Label16.Refresh()
                        power(1) += 2
                        Call 暫停()
                    End If
                    If cha(1) = 13 Then
                        Call 遺計()
                        Label16.Text = "郭嘉發動技能:遺計"
                        Label16.Refresh()
                        power(1) += 1
                        Call 暫停()
                    End If
                    damage = 0
                    元素傷害 = False
                End If
            ElseIf Label14.Text = "P" & game & "出牌階段" And list = 1 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And 南蠻中(0) = False And game = 1 And 空城中(1) = False And cha(0) = 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                Call 武聖()
                Label16.Text = "關羽發動技能:武聖"
                Label16.Refresh()
                kill(game - 1) += 1
                power(0) -= 2
                打出殺過 = True
                damage += 1
                Label21.Visible = False
                元素傷害 = True
                If 八卦(1) = True Then
                    If 無雙中 = True Then
                        For i = 1 To 2
                            Call 一判()
                            If 總判定 = True Then
                                Label13.Text = "八卦陣:成功"
                                Label13.Refresh()
                                Call 暫停()
                                If se = True Then
                                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                                End If
                                無雙次數 += 1
                                If 無雙次數 >= 2 Then
                                    Label21.Visible = True
                                    damage = 0
                                    元素傷害 = False
                                    無雙中 = False
                                End If
                            Else
                                Label13.Text = "八卦陣:失敗"
                                Label13.Refresh()
                                Call 暫停()
                                PictureBox40.Visible = True
                                Timer14.Enabled = True
                                Exit For
                            End If
                        Next
                    Else
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                Label21.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            PictureBox40.Visible = True
                            Timer14.Enabled = True
                        End If
                    End If
                Else
                    PictureBox40.Visible = True
                    Timer14.Enabled = True
                End If
            ElseIf 南蠻中(0) = True And list = 1 And power(0) >= 3 And cha(0) <> 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                power(0) -= 3
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            ElseIf 南蠻中(0) = True And list = 1 And power(0) >= 2 And cha(0) = 2 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                Call 武聖()
                Label16.Text = "關羽發動技能:武聖"
                Label16.Refresh()
                power(0) -= 2
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            End If
        End If

        '諸葛弩
        If e.KeyCode = Keys.Q Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 5 And game = 1 Then
                諸葛弩(game - 1) = True
                power(game - 1) -= 5
            End If
        End If

        '八卦
        If e.KeyCode = Keys.W Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 4 And game = 1 Then
                八卦(game - 1) = True
                藤甲(game - 1) = False
                power(game - 1) -= 4
            End If
        End If

        '藤甲
        If e.KeyCode = Keys.E Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 4 And game = 1 Then
                八卦(game - 1) = False
                藤甲(game - 1) = True
                power(game - 1) -= 4
            End If
        End If

        '樂不思蜀
        If e.KeyCode = Keys.A Then
            If game = 1 Then
                If 樂(1) = False Then
                    If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 4 And game = 1 And cha(1) <> 11 Then
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\樂不思蜀.wav", AudioPlayMode.Background)
                        End If
                        Call 暫停()
                        樂(1) = True
                        power(game - 1) -= 4
                    End If
                End If
            End If
        End If

        '兵糧寸斷
        If e.KeyCode = Keys.C Then
            If game = 1 Then
                If 兵(1) = False Then
                    If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 4 And game = 1 Then
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\兵糧寸斷.wav", AudioPlayMode.Background)
                        End If
                        Call 暫停()
                        兵(1) = True
                        power(game - 1) -= 4
                    End If
                End If
            End If
        End If

        '閃電
        If e.KeyCode = Keys.S Then
            If 閃(game - 1) = False Then
                If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 3 And game = 1 Then
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃電.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                    閃(game - 1) = True
                    power(game - 1) -= 3
                End If
            End If
        End If

        '五股
        If e.KeyCode = Keys.D Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 1 And game = 1 Then
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\五穀豐登.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                power(0) += 1
                power(1) += 1
                If cha(game - 1) = 6 Then
                    Call 集智()
                    Label16.Text = "黃月英發動技能:集智"
                    Label16.Refresh()
                    Randomize()
                    power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
                    Call 暫停()
                End If
            End If
        End If

        '過拆
        If e.KeyCode = Keys.G Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 4 And game = 1 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\過河拆橋.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                過河拆橋 = True
                誰過拆 = 2
                Label21.Visible = False
                Call 過拆中()
                power(game - 1) -= 4
                If cha(game - 1) = 6 Then
                    Call 集智()
                    Label16.Text = "黃月英發動技能:集智"
                    Label16.Refresh()
                    Randomize()
                    power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
                    Call 暫停()
                End If
            End If
        End If

        '過拆中
        If 過河拆橋 = True And 誰過拆 = 2 And game = 1 Then
            If e.KeyCode = Keys.H Then
                power(1) -= 2
                Call 過拆結束()
            ElseIf e.KeyCode = Keys.J Then
                諸葛弩(1) = False
                Call 過拆結束()
            ElseIf e.KeyCode = Keys.K Then
                八卦(1) = False
                藤甲(1) = False
                Call 過拆結束()
            End If
        End If

        '順手
        If e.KeyCode = Keys.Z Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 5 And game = 1 And cha(1) <> 11 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\順手牽羊.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                順手牽羊 = True
                誰過拆 = 2
                Label21.Visible = False
                Call 過拆中()
                power(game - 1) -= 5
                If cha(game - 1) = 6 Then
                    Call 集智()
                    Label16.Text = "黃月英發動技能:集智"
                    Label16.Refresh()
                    Randomize()
                    power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
                    Call 暫停()
                End If
            End If
        End If

        '順手中
        If 順手牽羊 = True And 誰過拆 = 2 And game = 1 Then
            If e.KeyCode = Keys.H Then
                power(1) -= 2
                power(0) += 2
                Call 過拆結束()
            ElseIf e.KeyCode = Keys.J Then
                諸葛弩(1) = False
                諸葛弩(0) = True
                Call 過拆結束()
            ElseIf e.KeyCode = Keys.K Then
                If 八卦(1) = True Then
                    八卦(1) = False
                    八卦(0) = True
                Else
                    藤甲(1) = False
                    藤甲(0) = True
                End If
                Call 過拆結束()
            End If
        End If

        '南蠻
        If e.KeyCode = Keys.X Then
            If Label14.Text = "P" & game & "出牌階段" And list = 1 And power(game - 1) >= 3 And game = 1 Then
                list = 0
                Call 卡牌消失()
                Label19.Text = "按esc開啟選單"
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\南蠻入侵.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                power(0) -= 3
                damage += 1
                Label21.Visible = False
                If 藤甲(1) = True Then
                    Label13.Text = "藤甲免疫南蠻"
                    Label13.Refresh()
                    Label21.Visible = True
                    damage = 0
                    元素傷害 = False
                Else
                    PictureBox40.Visible = True
                    南蠻中(1) = True
                End If
                If cha(game - 1) = 6 Then
                    Call 集智()
                    Label16.Text = "黃月英發動技能:集智"
                    Label16.Refresh()
                    Randomize()
                    power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
                    Call 暫停()
                End If
            End If
        End If

        '反間
        If e.KeyCode = Keys.P Then
            If Label14.Text = "P" & game & "出牌階段" And cha(0) = 4 And 反間過 = False And game = 1 Then
                Call 反間()
                Label16.Text = "周瑜發動技能:反間"
                Label16.Refresh()
                反間過 = True
                Label21.Visible = False
                反間中 = True
                反間確認 = False
                反間確認2 = False
                Label15.Text = "請雙方選擇1-4"
            End If
        End If

        If 反間中 = True Then
            If e.KeyCode = Keys.NumPad1 Then
                反間2 = 1
                反間確認2 = True
            ElseIf e.KeyCode = Keys.NumPad2 Then
                反間2 = 2
                反間確認2 = True
            ElseIf e.KeyCode = Keys.NumPad3 Then
                反間2 = 3
                反間確認2 = True
            ElseIf e.KeyCode = Keys.NumPad4 Then
                反間2 = 4
                反間確認2 = True
            End If
        End If

        '制衡
        If e.KeyCode = Keys.P Then
            If Label14.Text = "P" & game & "出牌階段" And cha(0) = 15 And 制衡過 = False And game = 1 Then
                Call 制衡()
                Label16.Text = "孫權發動技能:制衡"
                Label16.Refresh()
                制衡過 = True
                power(0) = Int(power(0) * 1.5)
            End If
        End If

        '苦肉
        If e.KeyCode = Keys.P Then
            If Label14.Text = "P" & game & "出牌階段" And cha(0) = 5 And abi(0) > 0 And game = 1 Then
                Call 苦肉()
                Label16.Text = "黃蓋發動技能:苦肉"
                Label16.Refresh()
                abi(0) -= 1
                Randomize()
                power(0) += Int(1 + Rnd() * 3 - 1 + 1)
            End If
        End If

        '仁德
        If e.KeyCode = Keys.P Then
            If Label14.Text = "P" & game & "出牌階段" And cha(0) = 12 And 仁德過 = False And game = 1 And power(0) >= 1 And abi(0) < 4 Then
                Call 仁德()
                Label16.Text = "劉備發動技能:仁德"
                Label16.Refresh()
                仁德過 = True
                power(0) -= 1
                power(1) += 1
                abi(0) += 1
            End If
        End If
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox15.Visible = False
        Timer2.Enabled = False
        Timer3.Enabled = True
        Timer12.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        '準備
        Timer3.Enabled = False
        kill(game - 1) = 0
        kill_up(game - 1) = 1
        beer = 0
        打出殺過 = False
        Call 資訊重製()
        Label14.Text = "P" & game & "準備階段"
        Call 暫停()
        If cha(game - 1) = 7 Then
            Label16.Text = "諸葛亮發動技能:觀星"
            Call 觀星()
            Label15.Text = "點選4-6來決定你要獲得的能量"
            觀星偵測 = True
            觀星減少 = True
        Else
            Timer4.Enabled = True
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        '判定
        Timer4.Enabled = False
        Call 資訊重製()
        Label14.Text = "P" & game & "判定階段"
        Call 暫停()
        If 樂(game - 1) = True Then
            Timer5.Enabled = True
        ElseIf 兵(game - 1) = True Then
            Timer6.Enabled = True
        ElseIf 閃(game - 1) = True Then
            Timer7.Enabled = True
        Else
            Timer8.Enabled = True
        End If
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        '樂不思蜀
        Timer5.Enabled = False
        Call 資訊重製()
        Call 二判()
        If 總判定 = True Then
            Label13.Text = "樂不思蜀:成功"
            Label13.Refresh()
            樂生效 = True
        Else
            Label13.Text = "樂不思蜀:失敗"
            Label13.Refresh()
        End If
        樂(game - 1) = False
        If cha(game - 1) = 13 Then
            Call 天妒()
            Label16.Text = "郭嘉發動技能:天妒"
            Label16.Refresh()
            power(0) += 1
            Call 暫停()
        End If
        Call 暫停()
        If 兵(game - 1) = True Then
            Timer6.Enabled = True
        ElseIf 閃(game - 1) = True Then
            Timer7.Enabled = True
        Else
            Timer8.Enabled = True
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        '兵糧寸斷
        Timer6.Enabled = False
        Call 資訊重製()
        Call 二判()
        If 總判定 = True Then
            Label13.Text = "兵糧寸斷:成功"
            Label13.Refresh()
            兵生效 = True
        Else
            Label13.Text = "兵糧寸斷:失敗"
            Label13.Refresh()
        End If
        兵(game - 1) = False
        If cha(game - 1) = 13 Then
            Call 天妒()
            Label16.Text = "郭嘉發動技能:天妒"
            Label16.Refresh()
            power(0) += 1
            Call 暫停()
        End If
        Call 暫停()
        If 閃(game - 1) = True Then
            Timer7.Enabled = True
        Else
            Timer8.Enabled = True
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        '閃電
        Timer7.Enabled = False
        Call 資訊重製()
        Call 三判()
        If 總判定 = True Then
            Label13.Text = "閃電:失敗"
            Label13.Refresh()
            If game = 1 Then
                閃(1) = True
            Else
                閃(0) = True
            End If
        Else
            Label13.Text = "閃電:成功"
            Label13.Refresh()
            abi(game - 1) -= 3
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃電發動.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
        End If
        閃(game - 1) = False
        If cha(game - 1) = 13 Then
            Call 天妒()
            Label16.Text = "郭嘉發動技能:天妒"
            Label16.Refresh()
            power(0) += 1
            Call 暫停()
        End If
        Call 暫停()
        If death = 0 Then
            Timer8.Enabled = True
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        '摸點
        Timer8.Enabled = False
        Call 資訊重製()
        Label14.Text = "P" & game & "摸點階段"
        Label14.Refresh()
        Thread.Sleep(2000)
        If 兵生效 = True Then
            Timer9.Enabled = True
            兵生效 = False
        Else
            If cha(game - 1) = 7 Then
                power(game - 1) += 觀星點數
                point_all += 觀星點數
                觀星點數 = 0
            Else
                For i = 1 To 2
                    Randomize()
                    point = Int(Rnd() * 2)
                    If point = 0 Then
                        power(game - 1) += 2
                        point_all += 2
                    ElseIf point = 1 Then
                        power(game - 1) += 3
                        point_all += 3
                    End If
                Next
                If cha(game - 1) = 4 Then
                    Label16.Text = "周瑜發動技能:英姿"
                    Label16.Refresh()
                    Call 英姿()
                    power(game - 1) += 2
                    point_all += 2
                End If
                If 觀星減少 = True And cha(game - 1) <> 7 Then
                    Label16.Text = "諸葛亮發動技能:觀星"
                    Label16.Refresh()
                    Call 觀星()
                    power(game - 1) -= 1
                    point_all -= 1
                    觀星減少 = False
                End If
            End If
            Label13.Text = "P" & game & "獲得了" & point_all & "點能量"
            Label13.Refresh()
            Thread.Sleep(2000)
            point_all = 0
            Timer9.Enabled = True
        End If
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        '出牌
        反間過 = False
        制衡過 = False
        仁德過 = False
        Timer9.Enabled = False
        damage = 0
        Call 資訊重製()
        Label14.Text = "P" & game & "出牌階段"
        If 樂生效 = True Then
            Timer10.Enabled = True
            樂生效 = False
        Else
            If game = 1 Then
                Label21.Visible = True
            Else
                PictureBox18.Visible = True
            End If
        End If
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        '棄點
        Timer10.Enabled = False
        Call 資訊重製()
        Label14.Text = "P" & game & "棄點階段"
        If cha(game - 1) = 17 And 打出殺過 = False Then
            Call 克己()
            Label16.Text = "呂蒙發動技能:克己"
            Label16.Refresh()
        Else
            If power(game - 1) > 2 * abi(game - 1) Then
                power(game - 1) = 2 * abi(game - 1)
            End If
        End If
        Timer11.Enabled = True
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        '結束階段
        Timer11.Enabled = False
        Call 資訊重製()
        Label14.Text = "P" & game & "結束階段"
        If cha(0) = 10 And game = 1 Then
            power(1) += 破軍點數
            破軍點數 = 0
        ElseIf cha(1) = 10 And game = 2 Then
            power(0) += 破軍點數
            破軍點數 = 0
        End If
        If game = 1 Then
            game = 2
        Else
            game = 1
        End If
        Call 暫停()
        Timer3.Enabled = True
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        '被動技能

        '空城
        If cha(0) = 7 Then
            If power(0) <= 0 And 空城中(0) = False Then
                Label16.Text = "諸葛亮發動技能:空城"
                Label16.Refresh()
                Call 空城()
                空城中(0) = True
            ElseIf power(0) > 0 Then
                空城中(0) = False
            End If
        Else
            空城中(0) = False
        End If
        If cha(1) = 7 Then
            If power(1) <= 0 And 空城中(1) = False Then
                Label16.Text = "諸葛亮發動技能:空城"
                Label16.Refresh()
                Call 空城()
                空城中(1) = True
            ElseIf power(1) > 0 Then
                空城中(1) = False
            End If
        Else
            空城中(1) = False
        End If

        '諸葛弩
        For i = 1 To 2
            If 諸葛弩(i - 1) = True Then
                CType(Me.Controls.Find("Label" & i + 22.ToString(), True)(0), Label).Visible = True
                kill_up(i - 1) = 3
            Else
                CType(Me.Controls.Find("Label" & i + 22.ToString(), True)(0), Label).Visible = False
                kill_up(i - 1) = 1
            End If
        Next

        '八卦
        For i = 1 To 2
            If 八卦(i - 1) = True Then
                CType(Me.Controls.Find("Label" & i + 24.ToString(), True)(0), Label).Visible = True
                CType(Me.Controls.Find("Label" & i + 24.ToString(), True)(0), Label).Text = "八卦陣"
            End If
        Next

        '藤甲
        For i = 1 To 2
            If 藤甲(i - 1) = True Then
                CType(Me.Controls.Find("Label" & i + 24.ToString(), True)(0), Label).Visible = True
                CType(Me.Controls.Find("Label" & i + 24.ToString(), True)(0), Label).Text = "藤甲"
            End If
        Next

        '空裝備
        For i = 1 To 2
            If 八卦(i - 1) = False And 藤甲(i - 1) = False Then
                CType(Me.Controls.Find("Label" & i + 24.ToString(), True)(0), Label).Visible = False
            End If
        Next

        '反間
        If Label14.Text = "P" & game & "出牌階段" Then
            If cha(0) = 4 And game = 1 Then
                If 反間過 = True Then
                    Label17.BackColor = Color.Transparent
                Else
                    Label17.BackColor = Color.Green
                End If
            ElseIf cha(1) = 4 And game = 2 Then
                If 反間過 = True Then
                    Label18.BackColor = Color.Transparent
                Else
                    Label18.BackColor = Color.Green
                End If
            End If
        End If

        '反間結束
        If 反間中 = True Then
            If 反間確認 = True And 反間確認2 = True Then
                Label13.Text = "P1:" & 反間1 & " P2:" & 反間2
                If 反間1 <> 反間2 Then
                    If game = 1 Then
                        abi(1) -= 1
                    Else
                        abi(0) -= 1
                    End If
                End If
                反間中 = False
                If game = 1 Then
                    Label21.Visible = True
                Else
                    PictureBox18.Visible = True
                End If
            End If
        End If

        '裝備數量
        For i = 0 To 1
            If 諸葛弩(i) = True Then
                armor(i) += 1
            End If
            If 八卦(i) = True Then
                armor(i) += 1
            End If
            If 藤甲(i) = True Then
                armor(i) += 1
            End If
        Next
        For i = 0 To 1
            armor(i) = 0
        Next

        '制衡
        If Label14.Text = "P" & game & "出牌階段" Then
            If cha(0) = 15 And game = 1 Then
                If 制衡過 = True Then
                    Label17.BackColor = Color.Transparent
                Else
                    Label17.BackColor = Color.Green
                End If
            ElseIf cha(1) = 15 And game = 2 Then
                If 制衡過 = True Then
                    Label18.BackColor = Color.Transparent
                Else
                    Label18.BackColor = Color.Green
                End If
            End If
        End If

        '連營
        For i = 1 To 2
            If cha(i - 1) = 11 And power(i - 1) <= 0 Then
                power(i - 1) += 2
                Call 連營()
                Label16.Text = "陸遜發動技能:連營"
                Label16.Refresh()
            End If
        Next

        '苦肉
        If Label14.Text = "P" & game & "出牌階段" Then
            If cha(0) = 5 And game = 1 Then
                If abi(0) <= 0 Then
                    Label17.BackColor = Color.Transparent
                Else
                    Label17.BackColor = Color.Green
                End If
            ElseIf cha(1) = 5 And game = 2 Then
                If abi(1) <= 0 Then
                    Label18.BackColor = Color.Transparent
                Else
                    Label18.BackColor = Color.Green
                End If
            End If
        End If

        '仁德
        If Label14.Text = "P" & game & "出牌階段" Then
            If cha(0) = 12 And game = 1 Then
                If 仁德過 = True Or power(0) < 1 Or abi(0) >= 4 Then
                    Label17.BackColor = Color.Transparent
                Else
                    Label17.BackColor = Color.Green
                End If
            ElseIf cha(1) = 12 And game = 2 Then
                If 仁德過 = True Or power(1) < 1 Or abi(1) >= 4 Then
                    Label18.BackColor = Color.Transparent
                Else
                    Label18.BackColor = Color.Green
                End If
            End If
        End If
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        '卡牌效果
        '刷新
        For i = 20 To 39
            CType(Me.Controls.Find("PictureBox" & i.ToString(), True)(0), PictureBox).Refresh()
        Next
        '殺
        For i = 1 To 2
            If Label14.Text = "P" & game & "出牌階段" And list = game And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And cha(game - 1) <> 14 And cha(game - 1) <> 2 Then
                PictureBox21.Image = ImageList6.Images(24)
            ElseIf 南蠻中(0) = True Then
                If power(0) >= 2 And cha(0) <> 14 And cha(0) <> 2 Then
                    PictureBox21.Image = ImageList6.Images(24)
                ElseIf power(0) >= 1 And cha(0) = 14 Or power(0) >= 1 And cha(0) = 2 Then
                    PictureBox21.Image = ImageList6.Images(24)
                End If
            ElseIf 南蠻中(1) = True Then
                If power(1) >= 2 And cha(1) <> 14 And cha(1) <> 2 Then
                    PictureBox21.Image = ImageList6.Images(24)
                ElseIf power(1) >= 1 And cha(1) = 14 Or power(1) >= 1 And cha(1) = 2 Then
                    PictureBox21.Image = ImageList6.Images(24)
                End If
            ElseIf Label14.Text = "P" & game & "出牌階段" And list = game And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 1 And cha(game - 1) = 14 Or Label14.Text = "P" & game & "出牌階段" And list = game And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 1 And cha(game - 1) = 2 Then
                PictureBox21.Image = ImageList6.Images(24)
            Else
                PictureBox21.Image = ImageList6.Images(25)
            End If
        Next
        '閃
        For i = 1 To 2
            If game = 1 Then
                If Timer14.Enabled = True And list = 2 And power(1) >= 2 And cha(1) <> 14 Then
                    PictureBox25.Image = ImageList6.Images(22)
                ElseIf Timer14.Enabled = True And list = 2 And power(1) >= 1 And cha(1) = 14 Then
                    PictureBox25.Image = ImageList6.Images(22)
                Else
                    PictureBox25.Image = ImageList6.Images(23)
                End If
            ElseIf game = 2 Then
                If Timer14.Enabled = True And list = 1 And power(0) >= 2 And cha(0) <> 14 Then
                    PictureBox25.Image = ImageList6.Images(22)
                ElseIf Timer14.Enabled = True And list = 1 And power(0) >= 1 And cha(0) = 14 Then
                    PictureBox25.Image = ImageList6.Images(22)
                Else
                    PictureBox25.Image = ImageList6.Images(23)
                End If
            End If
        Next
        '桃
        For i = 1 To 2
            If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 3 And abi(game - 1) < abi_up(game - 1) Then
                PictureBox29.Image = ImageList6.Images(18)
            Else
                PictureBox29.Image = ImageList6.Images(19)
            End If
        Next
        '酒
        For i = 1 To 2
            If Label14.Text = "P" & game & "出牌階段" And beer = 0 And power(game - 1) >= 2 And list = game Or death = list Then
                PictureBox33.Image = ImageList6.Images(20)
            Else
                PictureBox33.Image = ImageList6.Images(21)
            End If
        Next
        '元素殺
        For i = 1 To 2
            If Label14.Text = "P" & game & "出牌階段" And list = game And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 3 And cha(game - 1) <> 2 Then
                PictureBox37.Image = ImageList6.Images(6)
            ElseIf 南蠻中(0) = True Then
                If power(0) >= 3 And cha(0) <> 2 Then
                    PictureBox37.Image = ImageList6.Images(6)
                ElseIf power(0) >= 2 And cha(0) = 2 Then
                    PictureBox37.Image = ImageList6.Images(6)
                End If
            ElseIf 南蠻中(1) = True Then
                If power(1) >= 3 And cha(1) <> 2 Then
                    PictureBox37.Image = ImageList6.Images(6)
                ElseIf power(1) >= 2 And cha(1) = 2 Then
                    PictureBox37.Image = ImageList6.Images(6)
                End If
            ElseIf Label14.Text = "P" & game & "出牌階段" And list = game And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And cha(game - 1) = 2 Then
                PictureBox37.Image = ImageList6.Images(6)
            Else
                PictureBox37.Image = ImageList6.Images(7)
            End If
        Next

        '諸葛弩
        If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 5 Then
            PictureBox22.Image = ImageList6.Images(34)
        Else
            PictureBox22.Image = ImageList6.Images(35)
        End If

        '八卦
        If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 4 Then
            PictureBox26.Image = ImageList6.Images(2)
        Else
            PictureBox26.Image = ImageList6.Images(3)
        End If

        '藤甲
        If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 4 Then
            PictureBox30.Image = ImageList6.Images(36)
        Else
            PictureBox30.Image = ImageList6.Images(37)
        End If

        '樂不思蜀
        If game = 1 Then
            If 樂(1) = False Then
                If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 4 And cha(game) <> 11 Then
                    PictureBox23.Image = ImageList6.Images(32)
                Else
                    PictureBox23.Image = ImageList6.Images(33)
                End If
            End If
        Else
            If 樂(0) = False Then
                If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 4 And cha(game) <> 11 Then
                    PictureBox23.Image = ImageList6.Images(32)
                Else
                    PictureBox23.Image = ImageList6.Images(33)
                End If
            End If
        End If

        '兵糧寸斷
        If game = 1 Then
            If 兵(1) = False Then
                If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 4 Then
                    PictureBox32.Image = ImageList6.Images(10)
                Else
                    PictureBox32.Image = ImageList6.Images(11)
                End If
            End If
        Else
            If 兵(0) = False Then
                If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 4 Then
                    PictureBox32.Image = ImageList6.Images(10)
                Else
                    PictureBox32.Image = ImageList6.Images(11)
                End If
            End If
        End If

        '閃電
        If 閃(game - 1) = False Then
            If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 3 Then
                PictureBox27.Image = ImageList6.Images(0)
            Else
                PictureBox27.Image = ImageList6.Images(1)
            End If
        End If

        '五股
        If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 1 Then
            PictureBox31.Image = ImageList6.Images(4)
        Else
            PictureBox31.Image = ImageList6.Images(5)
        End If

        '過拆
        If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 4 Then
            PictureBox39.Image = ImageList6.Images(30)
        Else
            PictureBox39.Image = ImageList6.Images(31)
        End If

        '順手
        If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 5 And cha(game) <> 11 Then
            PictureBox24.Image = ImageList6.Images(28)
        Else
            PictureBox24.Image = ImageList6.Images(29)
        End If

        '南蠻
        If Label14.Text = "P" & game & "出牌階段" And list = game And power(game - 1) >= 3 Then
            PictureBox28.Image = ImageList6.Images(14)
        Else
            PictureBox28.Image = ImageList6.Images(15)
        End If

        '無懈
        If list = 無懈 And list = 1 And power(0) >= 3 Then
            PictureBox36.Image = ImageList6.Images(26)
        ElseIf list = 無懈 And list = 2 And power(1) >= 3 Then
            PictureBox36.Image = ImageList6.Images(26)
        Else
            PictureBox36.Image = ImageList6.Images(27)
        End If
    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        If game = 1 Then

        Else

        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Call 按鈕音效()
        '設定
        If setting = True Then
            PictureBox16.Image = ImageList1.Images(1)
            setting = False
            PictureBox19.Visible = True
            PictureBox5.Visible = True
        Else
            PictureBox16.Image = ImageList1.Images(0)
            setting = True
            PictureBox19.Visible = False
            PictureBox5.Visible = False
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Timer10.Enabled = True
        PictureBox18.Visible = False
        list = 0
        Call 卡牌消失()
        Label20.Text = "點擊開啟選單"
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        '退出
        Call 重要按鈕音效()
        back = MsgBox("是否要回到主畫面?", 1 + 64, "退出")
        If back = 1 Then
            Me.Close()
            Form2.Show()
            player2.close()
            If music = True Then
                player1.controls.play()
            End If
        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        '選單
        If list = 0 Then
            list = 2
            Call 卡牌出現()
            Label20.Text = "點擊關閉選單"
        ElseIf list = 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        '殺
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And 南蠻中(1) = False And game = 2 And 空城中(0) = False And cha(1) <> 14 And cha(1) <> 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            If cha(game - 1) = 9 Then
                Call 咆嘯()
                Label16.Text = "張飛發動技能:咆哮"
                Label16.Refresh()
            ElseIf cha(game - 1) = 3 Then
                Call 無雙()
                Label16.Text = "呂布發動技能:無雙"
                Label16.Refresh()
                kill(game - 1) += 1
                無雙中 = True
                無雙次數 = 0
            ElseIf cha(game - 1) = 10 Then
                Call 破軍()
                Label16.Text = "界徐盛發動技能:破軍"
                Label16.Refresh()
                kill(game - 1) += 1
                If power(0) > 2 * abi(0) Then
                    破軍點數 += 2 * abi(0)
                    power(0) -= 2 * abi(0)
                Else
                    破軍點數 += power(0)
                    power(0) = 0
                End If
            ElseIf cha(game - 1) = 1 Then
                Call 鐵騎()
                Label16.Text = "馬超發動技能:鐵騎"
                Label16.Refresh()
                kill(game - 1) += 1
                Call 一判()
                If 總判定 = True Then
                    Label13.Text = "鐵騎:成功"
                    Label13.Refresh()
                    鐵騎結果 = True
                Else
                    Label13.Text = "鐵騎:失敗"
                    Label13.Refresh()
                    鐵騎結果 = False
                End If
                Call 暫停()
            ElseIf cha(game - 1) = 8 And power(0) > abi(1) Then
                Call 烈弓()
                Label16.Text = "黃忠發動技能:烈弓"
                Label16.Refresh()
                kill(game - 1) += 1
                Call 暫停()
            Else
                kill(game - 1) += 1
            End If
            power(1) -= 2
            打出殺過 = True
            damage += 1
            PictureBox18.Visible = False
            PictureBox18.Refresh()
            If 八卦(0) = True Then
                If 無雙中 = True Then
                    For i = 1 To 2
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                PictureBox18.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            Label22.Visible = True
                            Timer14.Enabled = True
                            Exit For
                        End If
                    Next
                Else
                    Call 一判()
                    If 總判定 = True Then
                        Label13.Text = "八卦陣:成功"
                        Label13.Refresh()
                        Call 暫停()
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                        End If
                        PictureBox18.Visible = True
                        damage = 0
                        元素傷害 = False
                    Else
                        Label13.Text = "八卦陣:失敗"
                        Label13.Refresh()
                        Call 暫停()
                        Label22.Visible = True
                        Timer14.Enabled = True
                    End If
                End If
            ElseIf 藤甲(0) = True Then
                Label13.Text = "藤甲免疫一般殺"
                Label13.Refresh()
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            Else
                Label22.Visible = True
                Timer14.Enabled = True
            End If
            If cha(1) = 1 And 鐵騎結果 = True Or cha(game - 1) = 8 And power(0) > abi(1) Then
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                If 元素傷害 = True Then
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\元素傷害.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                    If 藤甲(0) = True Then
                        damage += 1
                    End If
                Else
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                End If
                If cha(1) = 10 Then
                    If power(1) >= power(0) And armor(1) >= armor(0) Then
                        damage += 1
                    End If
                End If
                abi(0) -= damage
                If cha(0) = 16 And power(1) >= 1 Then
                    Call 反饋()
                    Label16.Text = "司馬懿發動技能:反饋"
                    Label16.Refresh()
                    power(0) += 1
                    power(1) -= 1
                    Call 暫停()
                End If
                If cha(0) = 0 Then
                    Call 奸雄()
                    Label16.Text = "曹操發動技能:奸雄"
                    Label16.Refresh()
                    power(0) += 2
                    Call 暫停()
                End If
                If cha(0) = 13 Then
                    Call 遺計()
                    Label16.Text = "郭嘉發動技能:遺計"
                    Label16.Refresh()
                    power(0) += 1
                    Call 暫停()
                End If
                damage = 0
                元素傷害 = False
            End If
        ElseIf Label14.Text = "P" & game & "出牌階段" And list = 2 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And 南蠻中(1) = False And game = 2 And 空城中(0) = False And cha(1) = 14 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            kill(game - 1) += 1
            power(1) -= 1
            打出殺過 = True
            damage += 1
            Call 龍膽()
            Label16.Text = "趙雲發動技能:龍膽"
            Label16.Refresh()
            PictureBox18.Visible = False
            PictureBox18.Refresh()
            If 八卦(0) = True Then
                If 無雙中 = True Then
                    For i = 1 To 2
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                PictureBox18.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            Label22.Visible = True
                            Timer14.Enabled = True
                            Exit For
                        End If
                    Next
                Else
                    Call 一判()
                    If 總判定 = True Then
                        Label13.Text = "八卦陣:成功"
                        Label13.Refresh()
                        Call 暫停()
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                        End If
                        PictureBox18.Visible = True
                        damage = 0
                        元素傷害 = False
                    Else
                        Label13.Text = "八卦陣:失敗"
                        Label13.Refresh()
                        Call 暫停()
                        Label22.Visible = True
                        Timer14.Enabled = True
                    End If
                End If
            ElseIf 藤甲(0) = True Then
                Label13.Text = "藤甲免疫一般殺"
                Label13.Refresh()
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            Else
                Label22.Visible = True
                Timer14.Enabled = True
            End If
        ElseIf Label14.Text = "P" & game & "出牌階段" And list = 2 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And 南蠻中(1) = False And game = 2 And 空城中(0) = False And cha(1) = 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            kill(game - 1) += 1
            power(1) -= 1
            打出殺過 = True
            damage += 1
            Call 武聖()
            Label16.Text = "關羽發動技能:武聖"
            Label16.Refresh()
            PictureBox18.Visible = False
            PictureBox18.Refresh()
            If 八卦(0) = True Then
                If 無雙中 = True Then
                    For i = 1 To 2
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                PictureBox18.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            Label22.Visible = True
                            Timer14.Enabled = True
                            Exit For
                        End If
                    Next
                Else
                    Call 一判()
                    If 總判定 = True Then
                        Label13.Text = "八卦陣:成功"
                        Label13.Refresh()
                        Call 暫停()
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                        End If
                        PictureBox18.Visible = True
                        damage = 0
                        元素傷害 = False
                    Else
                        Label13.Text = "八卦陣:失敗"
                        Label13.Refresh()
                        Call 暫停()
                        Label22.Visible = True
                        Timer14.Enabled = True
                    End If
                End If
            ElseIf 藤甲(0) = True Then
                Label13.Text = "藤甲免疫一般殺"
                Label13.Refresh()
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            Else
                Label22.Visible = True
                Timer14.Enabled = True
            End If
        ElseIf 南蠻中(1) = True And list = 2 And power(1) >= 2 And cha(1) <> 14 And cha(1) <> 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            power(1) -= 2
            南蠻中(1) = False
            PictureBox40.Visible = False
            Label21.Visible = True
            damage = 0
            元素傷害 = False
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
        ElseIf 南蠻中(1) = True And list = 2 And power(1) >= 1 And cha(1) = 14 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            Call 龍膽()
            Label16.Text = "趙雲發動技能:龍膽"
            Label16.Refresh()
            power(1) -= 1
            南蠻中(1) = False
            PictureBox40.Visible = False
            Label21.Visible = True
            damage = 0
            元素傷害 = False
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
        ElseIf 南蠻中(1) = True And list = 2 And power(1) >= 1 And cha(1) = 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            Call 武聖()
            Label16.Text = "關羽發動技能:武聖"
            Label16.Refresh()
            power(1) -= 1
            南蠻中(1) = False
            PictureBox40.Visible = False
            Label21.Visible = True
            damage = 0
            元素傷害 = False
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        '閃
        If Timer14.Enabled = True And list = 2 And power(1) >= 2 And 無雙中 = False And cha(1) <> 14 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            power(1) -= 2
            Timer14.Enabled = False
            PictureBox40.Visible = False
            Label21.Visible = True
            damage = 0
            元素傷害 = False
        ElseIf Timer14.Enabled = True And list = 2 And power(1) >= 1 And 無雙中 = False And cha(1) = 14 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            power(1) -= 1
            Call 龍膽()
            Label16.Text = "趙雲發動技能:龍膽"
            Label16.Refresh()
            Timer14.Enabled = False
            PictureBox40.Visible = False
            Label21.Visible = True
            damage = 0
            元素傷害 = False
        ElseIf Timer14.Enabled = True And list = 2 And power(1) >= 2 And 無雙中 = True And cha(1) <> 14 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            power(1) -= 2
            無雙次數 += 1
            If 無雙次數 >= 2 Then
                Timer14.Enabled = False
                PictureBox40.Visible = False
                Label21.Visible = True
                damage = 0
                元素傷害 = False
                list = 0
            End If
        ElseIf Timer14.Enabled = True And list = 2 And power(1) >= 1 And 無雙中 = True And cha(1) = 14 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            Call 龍膽()
            Label16.Text = "趙雲發動技能:龍膽"
            Label16.Refresh()
            power(1) -= 1
            無雙次數 += 1
            If 無雙次數 >= 2 Then
                Timer14.Enabled = False
                PictureBox40.Visible = False
                Label21.Visible = True
                damage = 0
                元素傷害 = False
                list = 0
            End If
        End If
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        '取消
        If Timer14.Enabled = True Then
            Timer14.Enabled = False
            PictureBox40.Visible = False
            Label21.Visible = True
            If 元素傷害 = True Then
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\元素傷害.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                If 藤甲(1) = True Then
                    damage += 1
                End If
            Else
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
            End If
            If cha(0) = 10 Then
                If power(0) >= power(1) And armor(0) >= armor(1) Then
                    damage += 1
                End If
            End If
            abi(1) -= damage
            If cha(1) = 16 And power(0) >= 1 Then
                Call 反饋()
                Label16.Text = "司馬懿發動技能:反饋"
                Label16.Refresh()
                power(1) += 1
                power(0) -= 1
                Call 暫停()
            End If
            If cha(1) = 0 Then
                Call 奸雄()
                Label16.Text = "曹操發動技能:奸雄"
                Label16.Refresh()
                power(1) += 2
                Call 暫停()
            End If
            If cha(1) = 13 Then
                Call 遺計()
                Label16.Text = "郭嘉發動技能:遺計"
                Label16.Refresh()
                power(1) += 1
                Call 暫停()
            End If
            damage = 0
            元素傷害 = False
        ElseIf death = 2 Then
            champion = 1
            Call 勝利()
        ElseIf 南蠻中(1) = True Then
            南蠻中(1) = False
            PictureBox40.Visible = False
            Label21.Visible = True
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            abi(1) -= damage
            If cha(1) = 16 And power(0) >= 1 Then
                Call 反饋()
                Label16.Text = "司馬懿發動技能:反饋"
                Label16.Refresh()
                power(1) += 1
                power(0) -= 1
                Call 暫停()
            End If
            If cha(1) = 0 Then
                Call 奸雄()
                Label16.Text = "曹操發動技能:奸雄"
                Label16.Refresh()
                power(1) += 2
                Call 暫停()
            End If
            If cha(1) = 13 Then
                Call 遺計()
                Label16.Text = "郭嘉發動技能:遺計"
                Label16.Refresh()
                power(1) += 1
                Call 暫停()
            End If
            damage = 0
            元素傷害 = False
        End If
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        '桃
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 3 And abi(game - 1) < abi_up(game - 1) And game = 2 Then
            power(1) -= 3
            abi(game - 1) += 1
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\桃.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
        End If
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        '酒
        If Label14.Text = "P" & game & "出牌階段" And beer = 0 And power(1) >= 2 And list = 2 And game = 2 Then
            power(1) -= 2
            beer += 1
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\酒.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            damage += 1
        ElseIf death = 2 Then
            If power(death - 1) >= 2 Then
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\酒.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                power(1) -= 2
                abi(death - 1) += 1
                If abi(death - 1) >= 1 Then
                    瀕死執行 = False
                    If Timer8.Enabled = True Then
                        Call 資訊重製()
                        Label14.Text = "P" & game & "出牌階段"
                        death = 0
                        If game = 1 Then
                            Label21.Visible = True
                        Else
                            PictureBox18.Visible = True
                        End If
                        PictureBox40.Visible = False
                    Else
                        Timer8.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        '元素殺
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 3 And 南蠻中(1) = False And game = 2 And 空城中(0) = False And cha(1) <> 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            If cha(game - 1) = 9 Then
                Call 咆嘯()
                Label16.Text = "張飛發動技能:咆哮"
                Label16.Refresh()
            ElseIf cha(game - 1) = 3 Then
                Call 無雙()
                Label16.Text = "呂布發動技能:無雙"
                Label16.Refresh()
                kill(game - 1) += 1
                無雙中 = True
                無雙次數 = 0
            ElseIf cha(game - 1) = 10 Then
                Call 破軍()
                Label16.Text = "界徐盛發動技能:破軍"
                Label16.Refresh()
                kill(game - 1) += 1
                If power(0) > 2 * abi(0) Then
                    破軍點數 += 2 * abi(0)
                    power(0) -= 2 * abi(0)
                Else
                    破軍點數 += power(0)
                    power(0) = 0
                End If
            ElseIf cha(game - 1) = 1 Then
                Call 鐵騎()
                Label16.Text = "馬超發動技能:鐵騎"
                Label16.Refresh()
                kill(game - 1) += 1
                Call 一判()
                If 總判定 = True Then
                    Label13.Text = "鐵騎:成功"
                    Label13.Refresh()
                    鐵騎結果 = True
                Else
                    Label13.Text = "鐵騎:失敗"
                    Label13.Refresh()
                    鐵騎結果 = False
                End If
                Call 暫停()
            ElseIf cha(game - 1) = 8 And power(0) > abi(1) Then
                Call 烈弓()
                Label16.Text = "黃忠發動技能:烈弓"
                Label16.Refresh()
                kill(game - 1) += 1
                Call 暫停()
            Else
                kill(game - 1) += 1
            End If
            power(1) -= 3
            打出殺過 = True
            damage += 1
            PictureBox18.Visible = False
            元素傷害 = True
            If 八卦(0) = True Then
                If 無雙中 = True Then
                    For i = 1 To 2
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                PictureBox18.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            Label22.Visible = True
                            Timer14.Enabled = True
                            Exit For
                        End If
                    Next
                Else
                    Call 一判()
                    If 總判定 = True Then
                        Label13.Text = "八卦陣:成功"
                        Label13.Refresh()
                        Call 暫停()
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                        End If
                        PictureBox18.Visible = True
                        damage = 0
                        元素傷害 = False
                    Else
                        Label13.Text = "八卦陣:失敗"
                        Label13.Refresh()
                        Call 暫停()
                        Label22.Visible = True
                        Timer14.Enabled = True
                    End If
                End If
            Else
                Label22.Visible = True
                Timer14.Enabled = True
            End If
            If cha(1) = 1 And 鐵騎結果 = True Or cha(game - 1) = 8 And power(0) > abi(1) Then
                Timer14.Enabled = False
                Label22.Visible = False
                PictureBox18.Visible = True
                If 元素傷害 = True Then
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\元素傷害.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                    If 藤甲(0) = True Then
                        damage += 1
                    End If
                Else
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\傷害.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                End If
                If cha(1) = 10 Then
                    If power(1) >= power(0) And armor(1) >= armor(0) Then
                        damage += 1
                    End If
                End If
                abi(0) -= damage
                If cha(0) = 16 And power(1) >= 1 Then
                    Call 反饋()
                    Label16.Text = "司馬懿發動技能:反饋"
                    Label16.Refresh()
                    power(0) += 1
                    power(1) -= 1
                    Call 暫停()
                End If
                If cha(0) = 0 Then
                    Call 奸雄()
                    Label16.Text = "曹操發動技能:奸雄"
                    Label16.Refresh()
                    power(0) += 2
                    Call 暫停()
                End If
                If cha(0) = 13 Then
                    Call 遺計()
                    Label16.Text = "郭嘉發動技能:遺計"
                    Label16.Refresh()
                    power(0) += 1
                    Call 暫停()
                End If
                damage = 0
                元素傷害 = False
            End If
        ElseIf Label14.Text = "P" & game & "出牌階段" And list = 2 And kill(game - 1) < kill_up(game - 1) And power(game - 1) >= 2 And 南蠻中(1) = False And game = 2 And 空城中(0) = False And cha(1) = 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            Call 武聖()
            Label16.Text = "關羽發動技能:武聖"
            Label16.Refresh()
            kill(game - 1) += 1
            power(1) -= 2
            打出殺過 = True
            damage += 1
            PictureBox18.Visible = False
            元素傷害 = True
            If 八卦(0) = True Then
                If 無雙中 = True Then
                    For i = 1 To 2
                        Call 一判()
                        If 總判定 = True Then
                            Label13.Text = "八卦陣:成功"
                            Label13.Refresh()
                            Call 暫停()
                            If se = True Then
                                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                            End If
                            無雙次數 += 1
                            If 無雙次數 >= 2 Then
                                PictureBox18.Visible = True
                                damage = 0
                                元素傷害 = False
                                無雙中 = False
                            End If
                        Else
                            Label13.Text = "八卦陣:失敗"
                            Label13.Refresh()
                            Call 暫停()
                            Label22.Visible = True
                            Timer14.Enabled = True
                            Exit For
                        End If
                    Next
                Else
                    Call 一判()
                    If 總判定 = True Then
                        Label13.Text = "八卦陣:成功"
                        Label13.Refresh()
                        Call 暫停()
                        If se = True Then
                            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃.wav", AudioPlayMode.Background)
                        End If
                        PictureBox18.Visible = True
                        damage = 0
                        元素傷害 = False
                    Else
                        Label13.Text = "八卦陣:失敗"
                        Label13.Refresh()
                        Call 暫停()
                        Label22.Visible = True
                        Timer14.Enabled = True
                    End If
                End If
            Else
                Label22.Visible = True
                Timer14.Enabled = True
            End If
        ElseIf 南蠻中(1) = True And list = 2 And power(1) >= 3 And cha(1) <> 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            power(1) -= 3
            南蠻中(1) = False
            PictureBox40.Visible = False
            Label21.Visible = True
            damage = 0
            元素傷害 = False
        ElseIf 南蠻中(1) = True And list = 2 And power(1) >= 2 And cha(1) = 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\雷殺.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            Call 武聖()
            Label16.Text = "關羽發動技能:武聖"
            Label16.Refresh()
            power(1) -= 2
            南蠻中(1) = False
            PictureBox40.Visible = False
            Label21.Visible = True
            damage = 0
            元素傷害 = False
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        '諸葛弩
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 5 And game = 2 Then
            諸葛弩(game - 1) = True
            power(game - 1) -= 5
        End If
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        '八卦
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 4 And game = 2 Then
            八卦(game - 1) = True
            藤甲(game - 1) = False
            power(game - 1) -= 4
        End If
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        '藤甲
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 4 And game = 2 Then
            八卦(game - 1) = False
            藤甲(game - 1) = True
            power(game - 1) -= 4
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        '樂不思蜀
        If game = 2 Then
            If 樂(0) = False Then
                If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 4 And game = 2 And cha(0) <> 11 Then
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\樂不思蜀.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                    樂(0) = True
                    power(game - 1) -= 4
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        '兵糧寸斷
        If game = 2 Then
            If 兵(0) = False Then
                If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 4 And game = 2 Then
                    If se = True Then
                        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\兵糧寸斷.wav", AudioPlayMode.Background)
                    End If
                    Call 暫停()
                    兵(0) = True
                    power(game - 1) -= 4
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        '閃電
        If 閃(game - 1) = False Then
            If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 3 And game = 2 Then
                If se = True Then
                    My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\閃電.wav", AudioPlayMode.Background)
                End If
                Call 暫停()
                閃(game - 1) = True
                power(game - 1) -= 3
            End If
        End If
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 1 And game = 2 Then
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\五穀豐登.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            power(0) += 1
            power(1) += 1
        End If
        If cha(game - 1) = 6 Then
            Call 集智()
            Label16.Text = "黃月英發動技能:集智"
            Label16.Refresh()
            Randomize()
            power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
            Call 暫停()
        End If
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        '過拆
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 4 And game = 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\過河拆橋.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            PictureBox18.Visible = False
            過河拆橋 = True
            誰過拆 = 1
            Call 過拆中()
            power(game - 1) -= 4
            If cha(game - 1) = 6 Then
                Call 集智()
                Label16.Text = "黃月英發動技能:集智"
                Label16.Refresh()
                Randomize()
                power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
                Call 暫停()
            End If
        End If
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        If 過河拆橋 = True And 誰過拆 = 1 Then
            power(0) -= 2
            Call 過拆結束()
        End If
        If 順手牽羊 = True And 誰過拆 = 1 Then
            power(0) -= 2
            power(1) += 2
            Call 過拆結束()
        End If
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        If 過河拆橋 = True And 誰過拆 = 1 Then
            諸葛弩(0) = False
            Call 過拆結束()
        End If
        If 順手牽羊 = True And 誰過拆 = 1 Then
            諸葛弩(0) = False
            諸葛弩(1) = True
            Call 過拆結束()
        End If
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        If 過河拆橋 = True And 誰過拆 = 1 Then
            八卦(0) = False
            藤甲(0) = False
            Call 過拆結束()
        End If
        If 順手牽羊 = True And 誰過拆 = 1 Then
            If 八卦(0) = True Then
                八卦(0) = False
                八卦(1) = True
            Else
                藤甲(0) = False
                藤甲(1) = True
            End If
            Call 過拆結束()
        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        '順手
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 5 And game = 2 And cha(0) <> 11 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\順手牽羊.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            PictureBox18.Visible = False
            順手牽羊 = True
            誰過拆 = 1
            Call 過拆中()
            power(game - 1) -= 5
            If cha(game - 1) = 6 Then
                Call 集智()
                Label16.Text = "黃月英發動技能:集智"
                Label16.Refresh()
                Randomize()
                power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
                Call 暫停()
            End If
        End If
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        '南蠻
        If Label14.Text = "P" & game & "出牌階段" And list = 2 And power(game - 1) >= 3 And game = 2 Then
            list = 0
            Call 卡牌消失()
            Label20.Text = "點擊開啟選單"
            If se = True Then
                My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\南蠻入侵.wav", AudioPlayMode.Background)
            End If
            Call 暫停()
            power(1) -= 3
            damage += 1
            PictureBox18.Visible = False
            If 藤甲(0) = True Then
                Label13.Text = "藤甲免疫南蠻"
                Label13.Refresh()
                PictureBox18.Visible = True
                damage = 0
                元素傷害 = False
            Else
                Label22.Visible = True
                南蠻中(0) = True
            End If
            If cha(game - 1) = 6 Then
                Call 集智()
                Label16.Text = "黃月英發動技能:集智"
                Label16.Refresh()
                Randomize()
                power(game - 1) += Int(1 + Rnd() * 2 - 1 + 1)
                Call 暫停()
            End If
        End If
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click

    End Sub

    Private Sub Label34_Click(sender As Object, e As EventArgs) Handles Label34.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        If Label14.Text = "P" & game & "出牌階段" And cha(1) = 4 And 反間過 = False And game = 2 Then
            Call 反間()
            Label16.Text = "周瑜發動技能:反間"
            Label16.Refresh()
            反間過 = True
            PictureBox18.Visible = False
            反間中 = True
            反間確認 = False
            反間確認2 = False
            Label15.Text = "請雙方選擇1-4"
        End If
        If Label14.Text = "P" & game & "出牌階段" And cha(1) = 15 And 制衡過 = False And game = 2 Then
            Call 制衡()
            Label16.Text = "孫權發動技能:制衡"
            Label16.Refresh()
            制衡過 = True
            power(1) = Int(power(1) * 1.5)
        End If
        If Label14.Text = "P" & game & "出牌階段" And cha(1) = 5 And abi(1) > 0 And game = 2 Then
            Call 苦肉()
            Label16.Text = "黃蓋發動技能:苦肉"
            Label16.Refresh()
            abi(1) -= 1
            Randomize()
            power(1) += Int(1 + Rnd() * 3 - 1 + 1)
        End If
        If Label14.Text = "P" & game & "出牌階段" And cha(1) = 12 And 仁德過 = False And game = 2 And power(1) >= 1 And abi(1) < 4 Then
            Call 仁德()
            Label16.Text = "劉備發動技能:仁德"
            Label16.Refresh()
            仁德過 = True
            power(1) -= 1
            power(0) += 1
            abi(1) += 1
        End If
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call 重要按鈕音效()
        Me.Close()
        Form2.Show()
        player2.close()
        If music = True Then
            player1.controls.play()
        End If
    End Sub
End Class