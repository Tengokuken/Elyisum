<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharSelect
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.tmrChar = New System.Windows.Forms.Timer(Me.components)
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFemale = New System.Windows.Forms.PictureBox()
        Me.picMale = New System.Windows.Forms.PictureBox()
        Me.picChar1 = New System.Windows.Forms.PictureBox()
        Me.picChar4 = New System.Windows.Forms.PictureBox()
        Me.picChar3 = New System.Windows.Forms.PictureBox()
        Me.picChar2 = New System.Windows.Forms.PictureBox()
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(60, 22)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(431, 50)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Enter the name of the male hero."
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrChar
        '
        Me.tmrChar.Enabled = True
        Me.tmrChar.Interval = 500
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(175, 294)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MaxLength = 8
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(195, 28)
        Me.txtName.TabIndex = 5
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConfirm
        '
        Me.btnConfirm.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(335, 356)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(195, 44)
        Me.btnConfirm.TabIndex = 6
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblFemale
        '
        Me.lblFemale.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.ForeColor = System.Drawing.Color.White
        Me.lblFemale.Location = New System.Drawing.Point(364, 273)
        Me.lblFemale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(127, 17)
        Me.lblFemale.TabIndex = 10
        Me.lblFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFemale.Visible = False
        '
        'btnYes
        '
        Me.btnYes.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(339, 356)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(181, 44)
        Me.btnYes.TabIndex = 11
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        Me.btnYes.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(32, 356)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(181, 44)
        Me.btnNo.TabIndex = 12
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        Me.btnNo.Visible = False
        '
        'lblMale
        '
        Me.lblMale.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.ForeColor = System.Drawing.Color.White
        Me.lblMale.Location = New System.Drawing.Point(63, 274)
        Me.lblMale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(127, 16)
        Me.lblMale.TabIndex = 13
        Me.lblMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMale.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(18, 356)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(195, 44)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picFemale
        '
        Me.picFemale.Location = New System.Drawing.Point(364, 101)
        Me.picFemale.Margin = New System.Windows.Forms.Padding(4)
        Me.picFemale.Name = "picFemale"
        Me.picFemale.Size = New System.Drawing.Size(127, 148)
        Me.picFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFemale.TabIndex = 8
        Me.picFemale.TabStop = False
        Me.picFemale.Visible = False
        '
        'picMale
        '
        Me.picMale.Location = New System.Drawing.Point(63, 101)
        Me.picMale.Margin = New System.Windows.Forms.Padding(4)
        Me.picMale.Name = "picMale"
        Me.picMale.Size = New System.Drawing.Size(127, 148)
        Me.picMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMale.TabIndex = 7
        Me.picMale.TabStop = False
        Me.picMale.Visible = False
        '
        'picChar1
        '
        Me.picChar1.Location = New System.Drawing.Point(255, 158)
        Me.picChar1.Margin = New System.Windows.Forms.Padding(4)
        Me.picChar1.Name = "picChar1"
        Me.picChar1.Size = New System.Drawing.Size(33, 47)
        Me.picChar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picChar1.TabIndex = 1
        Me.picChar1.TabStop = False
        '
        'picChar4
        '
        Me.picChar4.Location = New System.Drawing.Point(254, 158)
        Me.picChar4.Margin = New System.Windows.Forms.Padding(4)
        Me.picChar4.Name = "picChar4"
        Me.picChar4.Size = New System.Drawing.Size(34, 47)
        Me.picChar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picChar4.TabIndex = 4
        Me.picChar4.TabStop = False
        '
        'picChar3
        '
        Me.picChar3.Location = New System.Drawing.Point(254, 158)
        Me.picChar3.Margin = New System.Windows.Forms.Padding(4)
        Me.picChar3.Name = "picChar3"
        Me.picChar3.Size = New System.Drawing.Size(34, 47)
        Me.picChar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picChar3.TabIndex = 3
        Me.picChar3.TabStop = False
        '
        'picChar2
        '
        Me.picChar2.Location = New System.Drawing.Point(254, 158)
        Me.picChar2.Margin = New System.Windows.Forms.Padding(4)
        Me.picChar2.Name = "picChar2"
        Me.picChar2.Size = New System.Drawing.Size(33, 47)
        Me.picChar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picChar2.TabIndex = 2
        Me.picChar2.TabStop = False
        '
        'frmCharSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(543, 451)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMale)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.lblFemale)
        Me.Controls.Add(Me.picFemale)
        Me.Controls.Add(Me.picMale)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.picChar1)
        Me.Controls.Add(Me.picChar4)
        Me.Controls.Add(Me.picChar3)
        Me.Controls.Add(Me.picChar2)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCharSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Character Selection"
        CType(Me.picFemale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents picChar1 As System.Windows.Forms.PictureBox
    Friend WithEvents picChar2 As System.Windows.Forms.PictureBox
    Friend WithEvents picChar3 As System.Windows.Forms.PictureBox
    Friend WithEvents picChar4 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrChar As System.Windows.Forms.Timer
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents picMale As System.Windows.Forms.PictureBox
    Friend WithEvents picFemale As System.Windows.Forms.PictureBox
    Friend WithEvents lblFemale As System.Windows.Forms.Label
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents lblMale As System.Windows.Forms.Label
    Friend WithEvents btnExit As Button
End Class
