Public Class Form1

    Dim G As Graphics
    Dim b As Bitmap
    Dim p, p2 As Point
    Dim x As Integer
    Dim bb As Brush = New SolidBrush(Color.FromArgb(51, 153, 255))
    Dim pp As Pen = New Pen(bb)
    Dim h

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
        Me.Top = 0
        G = PictureBox1.CreateGraphics
        b = My.Resources.table
        b.MakeTransparent(Color.White)
        Timer1.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ToolStripMenuItem1.Checked Then
            Me.TopMost = False
            ToolStripMenuItem1.Checked = False
        Else
            Me.TopMost = True
            ToolStripMenuItem1.Checked = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        h = PictureBox1.Height * (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory
        G.Clear(Color.FromArgb(18, 53, 84))
        G.FillRectangle(bb, New Rectangle(New Point(0, PictureBox1.Height - h), New Size(PictureBox1.Width, h)))
        G.DrawImage(b, 0, 0)
        Label1.Text = Int(100 * (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory) & "%"
        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width
        Me.Top = 0
    End Sub
End Class
