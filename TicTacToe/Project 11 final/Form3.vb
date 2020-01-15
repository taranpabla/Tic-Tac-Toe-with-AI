Public Class Form3
    Dim x As String = "X"
    Dim valx(5), valo(4) As Integer
    Dim cx, co As Integer
    Dim c As Integer = 1
    Dim win As Integer
    Dim xwin As Integer = 0
    Dim owin As Integer = 0

    Private Sub resetxo()
        cx = 0
        co = 0
        c = 0
        x = "X"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
    End Sub
    Private Sub xo(ByVal num As Integer)
        If x = "X" Then
            x = "O"
            valx(cx) = num
            cx = cx + 1
            If cx = 3 Then
                If valx(0) + valx(1) + valx(2) = 15 Then
                    MsgBox("X wins")
                    xwin = xwin + 1
                    Label3.Text = xwin
                    resetxo()
                End If
            End If
            If cx = 4 Then
                If valx(3) + valx(1) + valx(2) = 15 Or valx(0) + valx(3) + valx(2) = 15 Or valx(0) + valx(1) + valx(3) = 15 Then
                    MsgBox("X wins")
                    xwin = xwin + 1
                    Label3.Text = xwin
                    resetxo()
                End If
            End If
        ElseIf x = "O" Then
            x = "X"
            valo(co) = num
            co = co + 1
            If co = 3 Then
                If valo(0) + valo(1) + valo(2) = 15 Then
                    MsgBox("O wins")
                    owin = owin + 1
                    Label4.Text = owin
                    resetxo()
                End If
            End If
            If co = 4 Then
                If valo(0) + valo(1) + valo(3) = 15 Or valo(0) + valo(3) + valo(2) = 15 Or valo(3) + valo(1) + valo(2) = 15 Then
                    MsgBox("O wins")
                    owin = owin + 1
                    Label4.Text = owin
                    resetxo()
                End If
            End If
        End If
        If c = 9 Then
            If valx(4) + valx(1) + valx(2) = 15 Or valx(0) + valx(4) + valx(2) = 15 Or valx(0) + valx(1) + valx(4) = 15 Or valx(3) + valx(1) + valx(4) = 15 Or valx(4) + valx(3) + valx(2) = 15 Or valx(0) + valx(4) + valx(3) = 15 Then
                MsgBox("X wins")
                xwin = xwin + 1
                Label3.Text = xwin
            Else
                MsgBox("Draw")
            End If
            resetxo()
        End If
        c = c + 1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = x
        xo(8)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button2.Text = x
        xo(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button3.Text = x
        xo(6)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Button4.Text = x
        xo(3)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Button5.Text = x
        xo(5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        Button6.Text = x
        xo(7)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Button7.Text = x
        xo(4)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Enabled = False
        Button8.Text = x
        xo(9)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Enabled = False
        Button9.Text = x
        xo(2)
    End Sub
    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Form2.Show()
        Me.Visible = False
    End Sub
End Class

    
