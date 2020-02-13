<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.lblArrowKeys = New System.Windows.Forms.Label()
        Me.lblSpacebar = New System.Windows.Forms.Label()
        Me.lblMouse = New System.Windows.Forms.Label()
        Me.picMouse = New System.Windows.Forms.PictureBox()
        Me.picSpacebar = New System.Windows.Forms.PictureBox()
        Me.picArrowKeys = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picMouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpacebar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArrowKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblArrowKeys
        '
        Me.lblArrowKeys.AutoSize = True
        Me.lblArrowKeys.Location = New System.Drawing.Point(17, 325)
        Me.lblArrowKeys.Name = "lblArrowKeys"
        Me.lblArrowKeys.Size = New System.Drawing.Size(198, 21)
        Me.lblArrowKeys.TabIndex = 2
        Me.lblArrowKeys.Text = "Arrow Keys for navigation!"
        '
        'lblSpacebar
        '
        Me.lblSpacebar.AutoSize = True
        Me.lblSpacebar.Location = New System.Drawing.Point(253, 325)
        Me.lblSpacebar.Name = "lblSpacebar"
        Me.lblSpacebar.Size = New System.Drawing.Size(184, 21)
        Me.lblSpacebar.TabIndex = 3
        Me.lblSpacebar.Text = "Spacebar for interacting!"
        '
        'lblMouse
        '
        Me.lblMouse.Location = New System.Drawing.Point(496, 325)
        Me.lblMouse.Name = "lblMouse"
        Me.lblMouse.Size = New System.Drawing.Size(156, 45)
        Me.lblMouse.TabIndex = 5
        Me.lblMouse.Text = "Mouse control for everything else!"
        '
        'picMouse
        '
        Me.picMouse.Image = Global.Elysium.My.Resources.Resources.mousemd
        Me.picMouse.Location = New System.Drawing.Point(489, 169)
        Me.picMouse.Name = "picMouse"
        Me.picMouse.Size = New System.Drawing.Size(163, 124)
        Me.picMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMouse.TabIndex = 4
        Me.picMouse.TabStop = False
        '
        'picSpacebar
        '
        Me.picSpacebar.Image = Global.Elysium.My.Resources.Resources.computer_key_Space_bar
        Me.picSpacebar.Location = New System.Drawing.Point(219, 212)
        Me.picSpacebar.Name = "picSpacebar"
        Me.picSpacebar.Size = New System.Drawing.Size(256, 81)
        Me.picSpacebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpacebar.TabIndex = 1
        Me.picSpacebar.TabStop = False
        '
        'picArrowKeys
        '
        Me.picArrowKeys.Image = Global.Elysium.My.Resources.Resources.arrowKeys
        Me.picArrowKeys.Location = New System.Drawing.Point(21, 169)
        Me.picArrowKeys.Name = "picArrowKeys"
        Me.picArrowKeys.Size = New System.Drawing.Size(163, 124)
        Me.picArrowKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArrowKeys.TabIndex = 0
        Me.picArrowKeys.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(220, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(255, 47)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "How To Play:"
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(17, 483)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(485, 42)
        Me.lblCopyright.TabIndex = 7
        Me.lblCopyright.Text = "© 2015 Johnson Zhong Ahsan Khalid All Rights Reserved" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fair use, we do not own an" & _
            "y of the resources used in this software."
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(539, 482)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 56)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(667, 550)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblMouse)
        Me.Controls.Add(Me.picMouse)
        Me.Controls.Add(Me.lblSpacebar)
        Me.Controls.Add(Me.lblArrowKeys)
        Me.Controls.Add(Me.picSpacebar)
        Me.Controls.Add(Me.picArrowKeys)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        CType(Me.picMouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpacebar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArrowKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picArrowKeys As System.Windows.Forms.PictureBox
    Friend WithEvents picSpacebar As System.Windows.Forms.PictureBox
    Friend WithEvents lblArrowKeys As System.Windows.Forms.Label
    Friend WithEvents lblSpacebar As System.Windows.Forms.Label
    Friend WithEvents picMouse As System.Windows.Forms.PictureBox
    Friend WithEvents lblMouse As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
