Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
    'Open's A File Dialog So User Can Select Picture
    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click
        PictureBox2.Visible = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox2.Load(OpenFileDialog1.FileName)
            PictureBox2.Visible = True
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        PictureBox2.Image = Nothing
        PictureBox2.Visible = False
    End Sub

    Private Sub bgButton_Click(sender As Object, e As EventArgs) Handles bgButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox2.BackColor = ColorDialog1.Color
            TableLayoutPanel1.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Close()
    End Sub


    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
