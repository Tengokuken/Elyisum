<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemShop
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
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblBuy = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblSell = New System.Windows.Forms.Label()
        Me.btnBuy = New System.Windows.Forms.Button()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblGold = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pnlBackground
        '
        Me.pnlBackground.Location = New System.Drawing.Point(12, 23)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(622, 189)
        Me.pnlBackground.TabIndex = 1
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.Location = New System.Drawing.Point(12, 218)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(307, 261)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Label1"
        '
        'lblBuy
        '
        Me.lblBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuy.Location = New System.Drawing.Point(342, 221)
        Me.lblBuy.Name = "lblBuy"
        Me.lblBuy.Size = New System.Drawing.Size(292, 42)
        Me.lblBuy.TabIndex = 6
        Me.lblBuy.Text = "Buy"
        Me.lblBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExit
        '
        Me.lblExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExit.Location = New System.Drawing.Point(342, 389)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(292, 42)
        Me.lblExit.TabIndex = 4
        Me.lblExit.Text = "Exit"
        Me.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSell
        '
        Me.lblSell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSell.Location = New System.Drawing.Point(342, 307)
        Me.lblSell.Name = "lblSell"
        Me.lblSell.Size = New System.Drawing.Size(292, 41)
        Me.lblSell.TabIndex = 5
        Me.lblSell.Text = "Sell"
        Me.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuy
        '
        Me.btnBuy.ForeColor = System.Drawing.Color.Black
        Me.btnBuy.Location = New System.Drawing.Point(32, 429)
        Me.btnBuy.Name = "btnBuy"
        Me.btnBuy.Size = New System.Drawing.Size(115, 32)
        Me.btnBuy.TabIndex = 7
        Me.btnBuy.Text = "Buy"
        Me.btnBuy.UseVisualStyleBackColor = True
        '
        'lstItems
        '
        Me.lstItems.BackColor = System.Drawing.SystemColors.Control
        Me.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.ItemHeight = 21
        Me.lstItems.Location = New System.Drawing.Point(342, 221)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(292, 86)
        Me.lstItems.TabIndex = 8
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(339, 462)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(0, 21)
        Me.lblQuantity.TabIndex = 9
        '
        'lblGold
        '
        Me.lblGold.AutoSize = True
        Me.lblGold.Location = New System.Drawing.Point(583, 462)
        Me.lblGold.Name = "lblGold"
        Me.lblGold.Size = New System.Drawing.Size(56, 21)
        Me.lblGold.TabIndex = 10
        Me.lblGold.Text = "Label3"
        Me.lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(182, 429)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 32)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSell
        '
        Me.btnSell.ForeColor = System.Drawing.Color.Black
        Me.btnSell.Location = New System.Drawing.Point(32, 429)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(115, 32)
        Me.btnSell.TabIndex = 12
        Me.btnSell.Text = "Sell"
        Me.btnSell.UseVisualStyleBackColor = True
        Me.btnSell.Visible = False
        '
        'frmItemShop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(646, 492)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGold)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblBuy)
        Me.Controls.Add(Me.lblSell)
        Me.Controls.Add(Me.btnBuy)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.pnlBackground)
        Me.Controls.Add(Me.lstItems)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmItemShop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlBackground As Panel
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblBuy As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblSell As Label
    Friend WithEvents btnBuy As Button
    Friend WithEvents lstItems As ListBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblGold As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSell As Button
End Class
