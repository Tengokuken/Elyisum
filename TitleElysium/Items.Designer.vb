<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lsvItems = New System.Windows.Forms.ListView()
        Me.lsvColItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvColQuantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnUse = New System.Windows.Forms.Button()
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(463, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 36)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDesc
        '
        Me.lblDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(9, 9)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(571, 78)
        Me.lblDesc.TabIndex = 10
        Me.lblDesc.Text = "Select an item to see its description."
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lsvItems
        '
        Me.lsvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lsvColItemName, Me.lsvColQuantity})
        Me.lsvItems.Location = New System.Drawing.Point(151, 132)
        Me.lsvItems.Name = "lsvItems"
        Me.lsvItems.Scrollable = False
        Me.lsvItems.Size = New System.Drawing.Size(412, 221)
        Me.lsvItems.TabIndex = 11
        Me.lsvItems.UseCompatibleStateImageBehavior = False
        Me.lsvItems.View = System.Windows.Forms.View.Details
        '
        'lsvColItemName
        '
        Me.lsvColItemName.Text = "Item"
        Me.lsvColItemName.Width = 153
        '
        'lsvColQuantity
        '
        Me.lsvColQuantity.Text = "Quantity"
        Me.lsvColQuantity.Width = 258
        '
        'btnUse
        '
        Me.btnUse.Enabled = False
        Me.btnUse.Location = New System.Drawing.Point(9, 317)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(125, 36)
        Me.btnUse.TabIndex = 12
        Me.btnUse.Tag = ""
        Me.btnUse.Text = "Use Item"
        Me.btnUse.UseVisualStyleBackColor = True
        '
        'btnMale
        '
        Me.btnMale.Location = New System.Drawing.Point(164, 419)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(125, 36)
        Me.btnMale.TabIndex = 13
        Me.btnMale.Tag = "1"
        Me.btnMale.UseVisualStyleBackColor = True
        Me.btnMale.UseWaitCursor = True
        Me.btnMale.Visible = False
        '
        'btnFemale
        '
        Me.btnFemale.Location = New System.Drawing.Point(419, 419)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(125, 36)
        Me.btnFemale.TabIndex = 14
        Me.btnFemale.Tag = "2"
        Me.btnFemale.UseVisualStyleBackColor = True
        Me.btnFemale.UseWaitCursor = True
        Me.btnFemale.Visible = False
        '
        'frmItems
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 529)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.btnUse)
        Me.Controls.Add(Me.lsvItems)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblDesc As Label
    Friend WithEvents lsvItems As ListView
    Friend WithEvents lsvColItemName As ColumnHeader
    Friend WithEvents lsvColQuantity As ColumnHeader
    Friend WithEvents btnUse As Button
    Friend WithEvents btnMale As Button
    Friend WithEvents btnFemale As Button
End Class
