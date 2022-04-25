<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlayer
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblSpielerInfo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblSpielerName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLevelInt = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblGuthabenName = New System.Windows.Forms.Label()
        Me.lblGuthaben = New System.Windows.Forms.Label()
        Me.TlpPlayerinfo = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpPlayerinfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSpielerInfo
        '
        Me.LblSpielerInfo.AutoSize = True
        Me.LblSpielerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.LblSpielerInfo.Location = New System.Drawing.Point(49, 9)
        Me.LblSpielerInfo.Name = "LblSpielerInfo"
        Me.LblSpielerInfo.Size = New System.Drawing.Size(292, 39)
        Me.LblSpielerInfo.TabIndex = 0
        Me.LblSpielerInfo.Text = "Spielerinformation"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lblSpielerName
        '
        Me.lblSpielerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSpielerName.AutoSize = True
        Me.lblSpielerName.Location = New System.Drawing.Point(3, 11)
        Me.lblSpielerName.Name = "lblSpielerName"
        Me.lblSpielerName.Size = New System.Drawing.Size(140, 13)
        Me.lblSpielerName.TabIndex = 1
        Me.lblSpielerName.Text = "Spielername:"
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(149, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(140, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Label1"
        '
        'lblLevelInt
        '
        Me.lblLevelInt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLevelInt.AutoSize = True
        Me.lblLevelInt.Location = New System.Drawing.Point(149, 46)
        Me.lblLevelInt.Name = "lblLevelInt"
        Me.lblLevelInt.Size = New System.Drawing.Size(140, 13)
        Me.lblLevelInt.TabIndex = 4
        Me.lblLevelInt.Text = "25"
        '
        'lblLevel
        '
        Me.lblLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(3, 46)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(140, 13)
        Me.lblLevel.TabIndex = 3
        Me.lblLevel.Text = "Level:"
        '
        'lblGuthabenName
        '
        Me.lblGuthabenName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGuthabenName.AutoSize = True
        Me.lblGuthabenName.Location = New System.Drawing.Point(3, 81)
        Me.lblGuthabenName.Name = "lblGuthabenName"
        Me.lblGuthabenName.Size = New System.Drawing.Size(140, 13)
        Me.lblGuthabenName.TabIndex = 5
        Me.lblGuthabenName.Text = "Aktuelles Guthaben:"
        '
        'lblGuthaben
        '
        Me.lblGuthaben.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGuthaben.AutoSize = True
        Me.lblGuthaben.Location = New System.Drawing.Point(149, 81)
        Me.lblGuthaben.Name = "lblGuthaben"
        Me.lblGuthaben.Size = New System.Drawing.Size(140, 13)
        Me.lblGuthaben.TabIndex = 6
        Me.lblGuthaben.Text = "25 €"
        '
        'TlpPlayerinfo
        '
        Me.TlpPlayerinfo.ColumnCount = 2
        Me.TlpPlayerinfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpPlayerinfo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpPlayerinfo.Controls.Add(Me.lblSpielerName, 0, 0)
        Me.TlpPlayerinfo.Controls.Add(Me.lblName, 1, 0)
        Me.TlpPlayerinfo.Controls.Add(Me.lblGuthaben, 1, 2)
        Me.TlpPlayerinfo.Controls.Add(Me.lblLevel, 0, 1)
        Me.TlpPlayerinfo.Controls.Add(Me.lblLevelInt, 1, 1)
        Me.TlpPlayerinfo.Controls.Add(Me.lblGuthabenName, 0, 2)
        Me.TlpPlayerinfo.Location = New System.Drawing.Point(49, 64)
        Me.TlpPlayerinfo.Name = "TlpPlayerinfo"
        Me.TlpPlayerinfo.RowCount = 3
        Me.TlpPlayerinfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpPlayerinfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpPlayerinfo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TlpPlayerinfo.Size = New System.Drawing.Size(292, 106)
        Me.TlpPlayerinfo.TabIndex = 7
        '
        'FrmPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 232)
        Me.Controls.Add(Me.TlpPlayerinfo)
        Me.Controls.Add(Me.LblSpielerInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(413, 271)
        Me.MinimumSize = New System.Drawing.Size(413, 271)
        Me.Name = "FrmPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spielerinfos"
        Me.TlpPlayerinfo.ResumeLayout(False)
        Me.TlpPlayerinfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSpielerInfo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblSpielerName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblLevelInt As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblGuthabenName As Label
    Friend WithEvents lblGuthaben As Label
    Friend WithEvents TlpPlayerinfo As TableLayoutPanel
End Class
