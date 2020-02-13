<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInGameMenu
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
        Me.pnlMoney = New System.Windows.Forms.Panel()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblFHP = New System.Windows.Forms.Label()
        Me.lblFLevel = New System.Windows.Forms.Label()
        Me.lblFemaleName = New System.Windows.Forms.Label()
        Me.lblMHP = New System.Windows.Forms.Label()
        Me.lblMLevel = New System.Windows.Forms.Label()
        Me.lblMaleName = New System.Windows.Forms.Label()
        Me.pnlPlayTime = New System.Windows.Forms.Panel()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.pnlControlButtons = New System.Windows.Forms.Panel()
        Me.btnQuitGame = New System.Windows.Forms.Button()
        Me.btnGoToSave = New System.Windows.Forms.Button()
        Me.btnGoToSkills = New System.Windows.Forms.Button()
        Me.btnGoToOptions = New System.Windows.Forms.Button()
        Me.btnGoToStatus = New System.Windows.Forms.Button()
        Me.btnGoToItems = New System.Windows.Forms.Button()
        Me.picFemale = New System.Windows.Forms.PictureBox()
        Me.picMale = New System.Windows.Forms.PictureBox()
        Me.pnlMoney.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlControlButtons.SuspendLayout()
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMoney
        '
        Me.pnlMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMoney.Controls.Add(Me.lblMoney)
        Me.pnlMoney.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMoney.ForeColor = System.Drawing.Color.White
        Me.pnlMoney.Location = New System.Drawing.Point(4, 454)
        Me.pnlMoney.Name = "pnlMoney"
        Me.pnlMoney.Size = New System.Drawing.Size(178, 72)
        Me.pnlMoney.TabIndex = 2
        '
        'lblMoney
        '
        Me.lblMoney.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.Location = New System.Drawing.Point(3, 10)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(170, 42)
        Me.lblMoney.TabIndex = 0
        Me.lblMoney.Text = "12323G"
        Me.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlStatus
        '
        Me.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatus.Controls.Add(Me.lblFHP)
        Me.pnlStatus.Controls.Add(Me.lblFLevel)
        Me.pnlStatus.Controls.Add(Me.lblFemaleName)
        Me.pnlStatus.Controls.Add(Me.lblMHP)
        Me.pnlStatus.Controls.Add(Me.lblMLevel)
        Me.pnlStatus.Controls.Add(Me.lblMaleName)
        Me.pnlStatus.Controls.Add(Me.picFemale)
        Me.pnlStatus.Controls.Add(Me.picMale)
        Me.pnlStatus.ForeColor = System.Drawing.Color.White
        Me.pnlStatus.Location = New System.Drawing.Point(184, 12)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(404, 346)
        Me.pnlStatus.TabIndex = 2
        '
        'lblFHP
        '
        Me.lblFHP.AutoSize = True
        Me.lblFHP.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFHP.Location = New System.Drawing.Point(288, 186)
        Me.lblFHP.Name = "lblFHP"
        Me.lblFHP.Size = New System.Drawing.Size(82, 21)
        Me.lblFHP.TabIndex = 6
        Me.lblFHP.Text = "FemaleHP"
        '
        'lblFLevel
        '
        Me.lblFLevel.AutoSize = True
        Me.lblFLevel.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLevel.Location = New System.Drawing.Point(173, 242)
        Me.lblFLevel.Name = "lblFLevel"
        Me.lblFLevel.Size = New System.Drawing.Size(99, 21)
        Me.lblFLevel.TabIndex = 5
        Me.lblFLevel.Text = "FemaleLevel"
        '
        'lblFemaleName
        '
        Me.lblFemaleName.AutoSize = True
        Me.lblFemaleName.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemaleName.Location = New System.Drawing.Point(173, 186)
        Me.lblFemaleName.Name = "lblFemaleName"
        Me.lblFemaleName.Size = New System.Drawing.Size(104, 21)
        Me.lblFemaleName.TabIndex = 4
        Me.lblFemaleName.Text = "FemaleName"
        '
        'lblMHP
        '
        Me.lblMHP.AutoSize = True
        Me.lblMHP.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMHP.Location = New System.Drawing.Point(288, 33)
        Me.lblMHP.Name = "lblMHP"
        Me.lblMHP.Size = New System.Drawing.Size(66, 21)
        Me.lblMHP.TabIndex = 2
        Me.lblMHP.Text = "MaleHP"
        '
        'lblMLevel
        '
        Me.lblMLevel.AutoSize = True
        Me.lblMLevel.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMLevel.Location = New System.Drawing.Point(173, 89)
        Me.lblMLevel.Name = "lblMLevel"
        Me.lblMLevel.Size = New System.Drawing.Size(83, 21)
        Me.lblMLevel.TabIndex = 1
        Me.lblMLevel.Text = "MaleLevel"
        '
        'lblMaleName
        '
        Me.lblMaleName.AutoSize = True
        Me.lblMaleName.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaleName.Location = New System.Drawing.Point(173, 33)
        Me.lblMaleName.Name = "lblMaleName"
        Me.lblMaleName.Size = New System.Drawing.Size(88, 21)
        Me.lblMaleName.TabIndex = 0
        Me.lblMaleName.Text = "MaleName"
        '
        'pnlPlayTime
        '
        Me.pnlPlayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPlayTime.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlPlayTime.ForeColor = System.Drawing.Color.White
        Me.pnlPlayTime.Location = New System.Drawing.Point(188, 454)
        Me.pnlPlayTime.Name = "pnlPlayTime"
        Me.pnlPlayTime.Size = New System.Drawing.Size(400, 72)
        Me.pnlPlayTime.TabIndex = 3
        '
        'lblArea
        '
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArea.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.White
        Me.lblArea.Location = New System.Drawing.Point(4, 370)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(584, 81)
        Me.lblArea.TabIndex = 0
        Me.lblArea.Text = "yea"
        Me.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlControlButtons
        '
        Me.pnlControlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlControlButtons.Controls.Add(Me.btnQuitGame)
        Me.pnlControlButtons.Controls.Add(Me.btnGoToSave)
        Me.pnlControlButtons.Controls.Add(Me.btnGoToSkills)
        Me.pnlControlButtons.Controls.Add(Me.btnGoToOptions)
        Me.pnlControlButtons.Controls.Add(Me.btnGoToStatus)
        Me.pnlControlButtons.Controls.Add(Me.btnGoToItems)
        Me.pnlControlButtons.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlControlButtons.ForeColor = System.Drawing.Color.White
        Me.pnlControlButtons.Location = New System.Drawing.Point(4, 12)
        Me.pnlControlButtons.Name = "pnlControlButtons"
        Me.pnlControlButtons.Size = New System.Drawing.Size(178, 346)
        Me.pnlControlButtons.TabIndex = 4
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitGame.ForeColor = System.Drawing.Color.Black
        Me.btnQuitGame.Location = New System.Drawing.Point(3, 276)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(174, 65)
        Me.btnQuitGame.TabIndex = 6
        Me.btnQuitGame.TabStop = False
        Me.btnQuitGame.Tag = "6"
        Me.btnQuitGame.Text = "Quit to Menu"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'btnGoToSave
        '
        Me.btnGoToSave.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToSave.ForeColor = System.Drawing.Color.Black
        Me.btnGoToSave.Location = New System.Drawing.Point(3, 196)
        Me.btnGoToSave.Name = "btnGoToSave"
        Me.btnGoToSave.Size = New System.Drawing.Size(174, 54)
        Me.btnGoToSave.TabIndex = 5
        Me.btnGoToSave.TabStop = False
        Me.btnGoToSave.Tag = "5"
        Me.btnGoToSave.Text = "Save"
        Me.btnGoToSave.UseVisualStyleBackColor = True
        '
        'btnGoToSkills
        '
        Me.btnGoToSkills.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToSkills.ForeColor = System.Drawing.Color.Black
        Me.btnGoToSkills.Location = New System.Drawing.Point(3, 50)
        Me.btnGoToSkills.Name = "btnGoToSkills"
        Me.btnGoToSkills.Size = New System.Drawing.Size(174, 54)
        Me.btnGoToSkills.TabIndex = 4
        Me.btnGoToSkills.TabStop = False
        Me.btnGoToSkills.Tag = "2"
        Me.btnGoToSkills.Text = "Skills"
        Me.btnGoToSkills.UseVisualStyleBackColor = True
        '
        'btnGoToOptions
        '
        Me.btnGoToOptions.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToOptions.ForeColor = System.Drawing.Color.Black
        Me.btnGoToOptions.Location = New System.Drawing.Point(3, 153)
        Me.btnGoToOptions.Name = "btnGoToOptions"
        Me.btnGoToOptions.Size = New System.Drawing.Size(174, 54)
        Me.btnGoToOptions.TabIndex = 3
        Me.btnGoToOptions.TabStop = False
        Me.btnGoToOptions.Tag = "4"
        Me.btnGoToOptions.Text = "Options"
        Me.btnGoToOptions.UseVisualStyleBackColor = True
        '
        'btnGoToStatus
        '
        Me.btnGoToStatus.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToStatus.ForeColor = System.Drawing.Color.Black
        Me.btnGoToStatus.Location = New System.Drawing.Point(3, 101)
        Me.btnGoToStatus.Name = "btnGoToStatus"
        Me.btnGoToStatus.Size = New System.Drawing.Size(174, 54)
        Me.btnGoToStatus.TabIndex = 2
        Me.btnGoToStatus.TabStop = False
        Me.btnGoToStatus.Tag = "3"
        Me.btnGoToStatus.Text = "Status"
        Me.btnGoToStatus.UseVisualStyleBackColor = True
        '
        'btnGoToItems
        '
        Me.btnGoToItems.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToItems.ForeColor = System.Drawing.Color.Black
        Me.btnGoToItems.Location = New System.Drawing.Point(3, 3)
        Me.btnGoToItems.Name = "btnGoToItems"
        Me.btnGoToItems.Size = New System.Drawing.Size(174, 54)
        Me.btnGoToItems.TabIndex = 1
        Me.btnGoToItems.TabStop = False
        Me.btnGoToItems.Tag = "1"
        Me.btnGoToItems.Text = "Items"
        Me.btnGoToItems.UseVisualStyleBackColor = True
        '
        'picFemale
        '
        Me.picFemale.Image = Global.Elysium.My.Resources.Resources.heroineBig
        Me.picFemale.Location = New System.Drawing.Point(44, 186)
        Me.picFemale.Name = "picFemale"
        Me.picFemale.Size = New System.Drawing.Size(106, 147)
        Me.picFemale.TabIndex = 1
        Me.picFemale.TabStop = False
        '
        'picMale
        '
        Me.picMale.Image = Global.Elysium.My.Resources.Resources.heroBig
        Me.picMale.Location = New System.Drawing.Point(44, 17)
        Me.picMale.Name = "picMale"
        Me.picMale.Size = New System.Drawing.Size(106, 147)
        Me.picMale.TabIndex = 0
        Me.picMale.TabStop = False
        '
        'frmInGameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 529)
        Me.Controls.Add(Me.pnlControlButtons)
        Me.Controls.Add(Me.pnlPlayTime)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlMoney)
        Me.Controls.Add(Me.lblArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInGameMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elysium"
        Me.pnlMoney.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlControlButtons.ResumeLayout(False)
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnStatus As Button
    Friend WithEvents btnEquip As Button
    Friend WithEvents btnSkills As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents pnlMoney As Panel
    Friend WithEvents lblMoney As Label
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblFHP As Label
    Friend WithEvents lblFLevel As Label
    Friend WithEvents lblFemaleName As Label
    Friend WithEvents lblMHP As Label
    Friend WithEvents lblMLevel As Label
    Friend WithEvents lblMaleName As Label
    Friend WithEvents picFemale As PictureBox
    Friend WithEvents picMale As PictureBox
    Friend WithEvents pnlPlayTime As Panel
    Friend WithEvents lblArea As Label
    Friend WithEvents pnlControlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnGoToItems As System.Windows.Forms.Button
    Friend WithEvents btnGoToSave As System.Windows.Forms.Button
    Friend WithEvents btnGoToSkills As System.Windows.Forms.Button
    Friend WithEvents btnGoToOptions As System.Windows.Forms.Button
    Friend WithEvents btnGoToStatus As System.Windows.Forms.Button
    Friend WithEvents btnQuitGame As System.Windows.Forms.Button
End Class
