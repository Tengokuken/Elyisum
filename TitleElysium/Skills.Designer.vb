<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSkills
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
        Me.pnlChar = New System.Windows.Forms.Panel()
        Me.lstSkills = New System.Windows.Forms.ListBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpTargetChar = New System.Windows.Forms.GroupBox()
        Me.btnTargetBoth = New System.Windows.Forms.Button()
        Me.btnTargetFemale = New System.Windows.Forms.Button()
        Me.btnTargetMale = New System.Windows.Forms.Button()
        Me.btnUseSpell = New System.Windows.Forms.Button()
        Me.grpTargetChar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlChar
        '
        Me.pnlChar.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlChar.Location = New System.Drawing.Point(12, 62)
        Me.pnlChar.Name = "pnlChar"
        Me.pnlChar.Size = New System.Drawing.Size(568, 115)
        Me.pnlChar.TabIndex = 1
        '
        'lstSkills
        '
        Me.lstSkills.BackColor = System.Drawing.SystemColors.Control
        Me.lstSkills.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSkills.FormattingEnabled = True
        Me.lstSkills.ItemHeight = 21
        Me.lstSkills.Location = New System.Drawing.Point(12, 183)
        Me.lstSkills.Name = "lstSkills"
        Me.lstSkills.Size = New System.Drawing.Size(251, 151)
        Me.lstSkills.TabIndex = 0
        '
        'lblDesc
        '
        Me.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(281, 183)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(299, 151)
        Me.lblDesc.TabIndex = 2
        '
        'btnFemale
        '
        Me.btnFemale.ForeColor = System.Drawing.Color.Black
        Me.btnFemale.Location = New System.Drawing.Point(406, 12)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(105, 36)
        Me.btnFemale.TabIndex = 12
        Me.btnFemale.Tag = "2"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'btnMale
        '
        Me.btnMale.ForeColor = System.Drawing.Color.Black
        Me.btnMale.Location = New System.Drawing.Point(87, 12)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(105, 36)
        Me.btnMale.TabIndex = 13
        Me.btnMale.Tag = "1"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(247, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 36)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpTargetChar
        '
        Me.grpTargetChar.Controls.Add(Me.btnTargetBoth)
        Me.grpTargetChar.Controls.Add(Me.btnTargetFemale)
        Me.grpTargetChar.Controls.Add(Me.btnTargetMale)
        Me.grpTargetChar.Controls.Add(Me.btnUseSpell)
        Me.grpTargetChar.Location = New System.Drawing.Point(12, 363)
        Me.grpTargetChar.Name = "grpTargetChar"
        Me.grpTargetChar.Size = New System.Drawing.Size(568, 112)
        Me.grpTargetChar.TabIndex = 15
        Me.grpTargetChar.TabStop = False
        '
        'btnTargetBoth
        '
        Me.btnTargetBoth.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTargetBoth.ForeColor = System.Drawing.Color.Black
        Me.btnTargetBoth.Location = New System.Drawing.Point(212, 70)
        Me.btnTargetBoth.Name = "btnTargetBoth"
        Me.btnTargetBoth.Size = New System.Drawing.Size(146, 36)
        Me.btnTargetBoth.TabIndex = 3
        Me.btnTargetBoth.Tag = "3"
        Me.btnTargetBoth.Text = "Both players"
        Me.btnTargetBoth.UseVisualStyleBackColor = True
        Me.btnTargetBoth.Visible = False
        '
        'btnTargetFemale
        '
        Me.btnTargetFemale.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTargetFemale.ForeColor = System.Drawing.Color.Black
        Me.btnTargetFemale.Location = New System.Drawing.Point(394, 70)
        Me.btnTargetFemale.Name = "btnTargetFemale"
        Me.btnTargetFemale.Size = New System.Drawing.Size(105, 36)
        Me.btnTargetFemale.TabIndex = 2
        Me.btnTargetFemale.Tag = "2"
        Me.btnTargetFemale.UseVisualStyleBackColor = True
        Me.btnTargetFemale.Visible = False
        '
        'btnTargetMale
        '
        Me.btnTargetMale.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTargetMale.ForeColor = System.Drawing.Color.Black
        Me.btnTargetMale.Location = New System.Drawing.Point(75, 70)
        Me.btnTargetMale.Name = "btnTargetMale"
        Me.btnTargetMale.Size = New System.Drawing.Size(105, 36)
        Me.btnTargetMale.TabIndex = 1
        Me.btnTargetMale.Tag = "1"
        Me.btnTargetMale.UseVisualStyleBackColor = True
        Me.btnTargetMale.Visible = False
        '
        'btnUseSpell
        '
        Me.btnUseSpell.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseSpell.ForeColor = System.Drawing.Color.Black
        Me.btnUseSpell.Location = New System.Drawing.Point(235, 21)
        Me.btnUseSpell.Name = "btnUseSpell"
        Me.btnUseSpell.Size = New System.Drawing.Size(105, 36)
        Me.btnUseSpell.TabIndex = 0
        Me.btnUseSpell.Text = "Use spell"
        Me.btnUseSpell.UseVisualStyleBackColor = True
        Me.btnUseSpell.Visible = False
        '
        'frmSkills
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 529)
        Me.Controls.Add(Me.grpTargetChar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lstSkills)
        Me.Controls.Add(Me.pnlChar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSkills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skills"
        Me.grpTargetChar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlChar As Panel
    Friend WithEvents lstSkills As ListBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnFemale As Button
    Friend WithEvents btnMale As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpTargetChar As GroupBox
    Friend WithEvents btnUseSpell As Button
    Friend WithEvents btnTargetBoth As Button
    Friend WithEvents btnTargetFemale As Button
    Friend WithEvents btnTargetMale As Button
End Class
