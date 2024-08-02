Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports LATIHAN_SATRIA_1.Uji_coba

Public Class RoundedTextbox
    Inherits TextBox

    Private _cornerRadius As Integer = 10000

    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(ByVal value As Integer)
            _cornerRadius = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20 ' WS_EX_COMPOSITED
            Return cp
        End Get
    End Property

    Protected Overrides Sub OnPaintBackground(ByVal pevent As PaintEventArgs)
        ' No operation to prevent flickering
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Using backgroundImage As New Bitmap(Me.Width, Me.Height)
            Using g As Graphics = Graphics.FromImage(backgroundImage)
                DrawRoundedTextBox(g)
            End Using

            e.Graphics.DrawImage(backgroundImage, Point.Empty)
        End Using

        MyBase.OnPaint(e)
    End Sub

    Private Sub DrawRoundedTextBox(ByVal g As Graphics)
        Dim radius As Integer = CornerRadius
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

        Using path As New Drawing2D.GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
            path.AddArc(rect.X + rect.Width - 2 * radius, rect.Y, radius * 2, radius * 2, 270, 90)
            path.AddArc(rect.X + rect.Width - 2 * radius, rect.Y + rect.Height - 2 * radius, radius * 2, radius * 2, 0, 90)
            path.AddArc(rect.X, rect.Y + rect.Height - 2 * radius, radius * 2, radius * 2, 90, 90)
            path.CloseFigure()

            Using brush As New TextureBrush(My.Resources.wallpapersden_com_one_piece_hd_luffy_cool_art_3200x1800)
                g.FillPath(brush, path)
            End Using
        End Using
    End Sub
End Class
