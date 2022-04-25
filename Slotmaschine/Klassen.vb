Imports System.Drawing.Drawing2D
Public Class FormattedNumericUpDown
    Inherits NumericUpDown
    Private _Format As String = "{0}"
    Public Property Format As String
        Get
            Return _Format
        End Get
        Set(value As String)
            _Format = value
            Me.Text = String.Format(_Format, Me.Value)
        End Set
    End Property
    Dim RefreshText As Boolean = False
    Protected Overrides Sub OnValueChanged(e As EventArgs)
        RefreshText = True
        MyBase.OnValueChanged(e)
    End Sub
    Protected Overrides Sub OnTextBoxTextChanged(source As Object, e As EventArgs)
        If RefreshText Then
            RefreshText = False
            DirectCast(source, TextBox).Text = String.Format(_Format, Me.Text)
        End If
    End Sub
End Class
Public Class RoundButton
    Inherits Button
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(grPath)
        MyBase.OnPaint(e)
    End Sub
End Class


