<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlCharStats = New System.Windows.Forms.Panel()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblAgi = New System.Windows.Forms.Label()
        Me.lblEXP = New System.Windows.Forms.Label()
        Me.picMale = New System.Windows.Forms.PictureBox()
        Me.lblInt = New System.Windows.Forms.Label()
        Me.lblStr = New System.Windows.Forms.Label()
        Me.lblVit = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.pnlCharStats.SuspendLayout()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlCharStats
        '
        Me.pnlCharStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCharStats.Controls.Add(Me.lblHP)
        Me.pnlCharStats.Controls.Add(Me.lblAgi)
        Me.pnlCharStats.Controls.Add(Me.lblEXP)
        Me.pnlCharStats.Controls.Add(Me.picMale)
        Me.pnlCharStats.Controls.Add(Me.lblInt)
        Me.pnlCharStats.Controls.Add(Me.lblStr)
        Me.pnlCharStats.Controls.Add(Me.lblVit)
        Me.pnlCharStats.Location = New System.Drawing.Point(3, 73)
        Me.pnlCharStats.Name = "pnlCharStats"
        Me.pnlCharStats.Size = New System.Drawing.Size(588, 171)
        Me.pnlCharStats.TabIndex = 0
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.ForeColor = System.Drawing.Color.White
        Me.lblHP.Location = New System.Drawing.Point(413, 9)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(28, 17)
        Me.lblHP.TabIndex = 8
        Me.lblHP.Text = "HP:"
        '
        'lblAgi
        '
        Me.lblAgi.AutoSize = True
        Me.lblAgi.ForeColor = System.Drawing.Color.White
        Me.lblAgi.Location = New System.Drawing.Point(23, 140)
        Me.lblAgi.Name = "lblAgi"
        Me.lblAgi.Size = New System.Drawing.Size(44, 17)
        Me.lblAgi.TabIndex = 7
        Me.lblAgi.Text = "Agility"
        '
        'lblEXP
        '
        Me.lblEXP.AutoSize = True
        Me.lblEXP.ForeColor = System.Drawing.Color.White
        Me.lblEXP.Location = New System.Drawing.Point(413, 99)
        Me.lblEXP.Name = "lblEXP"
        Me.lblEXP.Size = New System.Drawing.Size(34, 17)
        Me.lblEXP.TabIndex = 5
        Me.lblEXP.Text = "EXP:"
        '
        'picMale
        '
        Me.picMale.Location = New System.Drawing.Point(208, 9)
        Me.picMale.Name = "picMale"
        Me.picMale.Size = New System.Drawing.Size(165, 148)
        Me.picMale.TabIndex = 4
        Me.picMale.TabStop = False
        '
        'lblInt
        '
        Me.lblInt.AutoSize = True
        Me.lblInt.ForeColor = System.Drawing.Color.White
        Me.lblInt.Location = New System.Drawing.Point(23, 93)
        Me.lblInt.Name = "lblInt"
        Me.lblInt.Size = New System.Drawing.Size(76, 17)
        Me.lblInt.TabIndex = 3
        Me.lblInt.Text = "Intelligence"
        '
        'lblStr
        '
        Me.lblStr.AutoSize = True
        Me.lblStr.ForeColor = System.Drawing.Color.White
        Me.lblStr.Location = New System.Drawing.Point(23, 50)
        Me.lblStr.Name = "lblStr"
        Me.lblStr.Size = New System.Drawing.Size(60, 17)
        Me.lblStr.TabIndex = 1
        Me.lblStr.Text = "Strength"
        '
        'lblVit
        '
        Me.lblVit.AutoSize = True
        Me.lblVit.ForeColor = System.Drawing.Color.White
        Me.lblVit.Location = New System.Drawing.Point(23, 6)
        Me.lblVit.Name = "lblVit"
        Me.lblVit.Size = New System.Drawing.Size(49, 17)
        Me.lblVit.TabIndex = 0
        Me.lblVit.Text = "Vitality"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 484)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 33)
        Me.btnExit.TabIndex = 9
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMale
        '
        Me.btnMale.Location = New System.Drawing.Point(101, 22)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(105, 36)
        Me.btnMale.TabIndex = 10
        Me.btnMale.Tag = "1"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnFemale
        '
        Me.btnFemale.Location = New System.Drawing.Point(386, 22)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(105, 36)
        Me.btnFemale.TabIndex = 11
        Me.btnFemale.Tag = "2"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'frmStatus
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 529)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlCharStats)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStatus"
        Me.pnlCharStats.ResumeLayout(False)
        Me.pnlCharStats.PerformLayout()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCharStats As Panel
    Friend WithEvents lblInt As Label
    Friend WithEvents lblStr As Label
    Friend WithEvents lblVit As Label
    Friend WithEvents lblAgi As Label
    Friend WithEvents lblEXP As Label
    Friend WithEvents picMale As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMale As Button
    Friend WithEvents btnFemale As Button
    Friend WithEvents lblHP As Label
End Class
