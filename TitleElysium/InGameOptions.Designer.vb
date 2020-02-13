<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInGameOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSound = New System.Windows.Forms.Label()
        Me.chkMute = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSound
        '
        Me.lblSound.AutoSize = True
        Me.lblSound.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSound.ForeColor = System.Drawing.Color.White
        Me.lblSound.Location = New System.Drawing.Point(29, 44)
        Me.lblSound.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSound.Name = "lblSound"
        Me.lblSound.Size = New System.Drawing.Size(114, 21)
        Me.lblSound.TabIndex = 3
        Me.lblSound.Text = "Sound Options"
        '
        'chkMute
        '
        Me.chkMute.AutoSize = True
        Me.chkMute.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMute.ForeColor = System.Drawing.Color.White
        Me.chkMute.Location = New System.Drawing.Point(33, 99)
        Me.chkMute.Margin = New System.Windows.Forms.Padding(4)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.Size = New System.Drawing.Size(71, 25)
        Me.chkMute.TabIndex = 2
        Me.chkMute.Text = "Mute"
        Me.chkMute.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(480, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmInGameOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblSound)
        Me.Controls.Add(Me.chkMute)
        Me.Name = "frmInGameOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInGameOptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSound As Label
    Friend WithEvents chkMute As CheckBox
    Friend WithEvents btnExit As Button
End Class
