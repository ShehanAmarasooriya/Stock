<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CurrentStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrentStock))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CurrentStockView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CurrentStockView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(3, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 451)
        Me.Panel2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources._22233_21
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Location = New System.Drawing.Point(156, 394)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 37)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox4.Controls.Add(Me.CurrentStockView)
        Me.GroupBox4.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(17, 8)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(423, 375)
        Me.GroupBox4.TabIndex = 54
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current Stock"
        '
        'CurrentStockView
        '
        Me.CurrentStockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CurrentStockView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.CurrentStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CurrentStockView.Location = New System.Drawing.Point(14, 31)
        Me.CurrentStockView.Name = "CurrentStockView"
        Me.CurrentStockView.Size = New System.Drawing.Size(383, 318)
        Me.CurrentStockView.TabIndex = 51
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 124)
        Me.Panel1.TabIndex = 0
        '
        'CurrentStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 575)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CurrentStock"
        Me.Text = "CurrentStock"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.CurrentStockView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CurrentStockView As DataGridView
    Friend WithEvents btnCancel As Button
End Class
