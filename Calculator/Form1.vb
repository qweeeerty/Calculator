Public Class Form1
    Dim Count As Integer = 0
    Dim total As Integer = 0
    Dim Xi As Double = 0

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Xi += CInt(TextBox2.Text) ^ 2
        total += CInt(TextBox2.Text)
        Count += 1
        TextBox1.Text = Count
        TextBox2.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Text = total / Count
        Dim mean As Double = total / Count
        TextBox4.Text = Math.Sqrt(((Count * Xi) - (total ^ 2)) / (Count * (Count - 1)))

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text = "0"
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox2.Clear()
        total = 0 : Count = 0 : Xi = 0
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
