<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitle
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPressEnter = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnLoadGame = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picElysium = New System.Windows.Forms.PictureBox()
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.picElysium, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPressEnter
        '
        Me.lblPressEnter.AutoSize = True
        Me.lblPressEnter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPressEnter.ForeColor = System.Drawing.Color.Silver
        Me.lblPressEnter.Location = New System.Drawing.Point(186, 256)
        Me.lblPressEnter.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPressEnter.Name = "lblPressEnter"
        Me.lblPressEnter.Size = New System.Drawing.Size(172, 24)
        Me.lblPressEnter.TabIndex = 0
        Me.lblPressEnter.Text = "Press Enter to Start"
        '
        'btnNewGame
        '
        Me.btnNewGame.BackColor = System.Drawing.Color.Silver
        Me.btnNewGame.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewGame.ForeColor = System.Drawing.Color.Black
        Me.btnNewGame.Location = New System.Drawing.Point(206, 197)
        Me.btnNewGame.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(137, 43)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Tag = "1"
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = False
        Me.btnNewGame.Visible = False
        '
        'btnLoadGame
        '
        Me.btnLoadGame.BackColor = System.Drawing.Color.Silver
        Me.btnLoadGame.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadGame.ForeColor = System.Drawing.Color.Black
        Me.btnLoadGame.Location = New System.Drawing.Point(206, 276)
        Me.btnLoadGame.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnLoadGame.Name = "btnLoadGame"
        Me.btnLoadGame.Size = New System.Drawing.Size(137, 43)
        Me.btnLoadGame.TabIndex = 2
        Me.btnLoadGame.Tag = "2"
        Me.btnLoadGame.Text = "Load Game"
        Me.btnLoadGame.UseVisualStyleBackColor = False
        Me.btnLoadGame.Visible = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.Silver
        Me.btnOptions.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.Black
        Me.btnOptions.Location = New System.Drawing.Point(206, 378)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(137, 43)
        Me.btnOptions.TabIndex = 3
        Me.btnOptions.Tag = "4"
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        Me.btnOptions.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(206, 429)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 43)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Tag = "5"
        Me.btnExit.Text = " Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'picElysium
        '
        Me.picElysium.BackColor = System.Drawing.Color.Transparent
        Me.picElysium.Image = Global.Elysium.My.Resources.Resources.BetterElysiumTitle
        Me.picElysium.Location = New System.Drawing.Point(33, 28)
        Me.picElysium.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.picElysium.Name = "picElysium"
        Me.picElysium.Size = New System.Drawing.Size(475, 137)
        Me.picElysium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picElysium.TabIndex = 5
        Me.picElysium.TabStop = False
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 500
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Silver
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.Black
        Me.btnHelp.Location = New System.Drawing.Point(206, 327)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(137, 43)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Tag = "3"
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = False
        Me.btnHelp.Visible = False
        '
        'frmTitle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(543, 494)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.picElysium)
        Me.Controls.Add(Me.lblPressEnter)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnLoadGame)
        Me.Controls.Add(Me.btnNewGame)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmTitle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elysium"
        CType(Me.picElysium, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPressEnter As System.Windows.Forms.Label
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnLoadGame As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picElysium As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFlash As Timer
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
