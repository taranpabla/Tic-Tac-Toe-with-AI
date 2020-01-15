Public Class Form2

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        '1 player
        Form1.Show()
        Me.Visible = False
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        '2 player
        Form3.Show()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    
End Class