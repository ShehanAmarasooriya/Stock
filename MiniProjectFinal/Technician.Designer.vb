<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Technician
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Technician))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnDeleteR = New System.Windows.Forms.Button()
        Me.BtnNewR = New System.Windows.Forms.Button()
        Me.btnUpdateR = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnViewCurrentStock = New System.Windows.Forms.Button()
        Me.TxtItemQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RequestView = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddR = New System.Windows.Forms.Button()
        Me.DateTimeRequest = New System.Windows.Forms.DateTimePicker()
        Me.TxtRequestID = New System.Windows.Forms.TextBox()
        Me.CmbItemCode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RequestView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BtnDeleteR)
        Me.Panel2.Controls.Add(Me.BtnNewR)
        Me.Panel2.Controls.Add(Me.btnUpdateR)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnViewCurrentStock)
        Me.Panel2.Controls.Add(Me.TxtItemQuantity)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnAddR)
        Me.Panel2.Controls.Add(Me.DateTimeRequest)
        Me.Panel2.Controls.Add(Me.TxtRequestID)
        Me.Panel2.Controls.Add(Me.CmbItemCode)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(-4, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 542)
        Me.Panel2.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(468, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 20)
        Me.Label7.TabIndex = 65
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(460, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 49)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Item Quantity"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnDeleteR
        '
        Me.BtnDeleteR.BackColor = System.Drawing.Color.Transparent
        Me.BtnDeleteR.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources.Delete__2
        Me.BtnDeleteR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDeleteR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeleteR.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteR.Location = New System.Drawing.Point(133, 388)
        Me.BtnDeleteR.Name = "BtnDeleteR"
        Me.BtnDeleteR.Size = New System.Drawing.Size(106, 52)
        Me.BtnDeleteR.TabIndex = 62
        Me.BtnDeleteR.UseVisualStyleBackColor = False
        '
        'BtnNewR
        '
        Me.BtnNewR.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources._11_2_2_2
        Me.BtnNewR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnNewR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewR.Location = New System.Drawing.Point(28, 388)
        Me.BtnNewR.Name = "BtnNewR"
        Me.BtnNewR.Size = New System.Drawing.Size(93, 52)
        Me.BtnNewR.TabIndex = 61
        Me.BtnNewR.UseVisualStyleBackColor = True
        '
        'btnUpdateR
        '
        Me.btnUpdateR.BackgroundImage = CType(resources.GetObject("btnUpdateR.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdateR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdateR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdateR.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnUpdateR.Location = New System.Drawing.Point(372, 388)
        Me.btnUpdateR.Name = "btnUpdateR"
        Me.btnUpdateR.Size = New System.Drawing.Size(95, 52)
        Me.btnUpdateR.TabIndex = 15
        Me.btnUpdateR.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 20)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Maximum Available Item ="
        '
        'btnViewCurrentStock
        '
        Me.btnViewCurrentStock.BackColor = System.Drawing.Color.Maroon
        Me.btnViewCurrentStock.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources.view1
        Me.btnViewCurrentStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewCurrentStock.Location = New System.Drawing.Point(1107, 31)
        Me.btnViewCurrentStock.Name = "btnViewCurrentStock"
        Me.btnViewCurrentStock.Size = New System.Drawing.Size(181, 54)
        Me.btnViewCurrentStock.TabIndex = 59
        Me.btnViewCurrentStock.Text = "VIEW CURRENT STOCK"
        Me.btnViewCurrentStock.UseVisualStyleBackColor = False
        '
        'TxtItemQuantity
        '
        Me.TxtItemQuantity.Location = New System.Drawing.Point(260, 214)
        Me.TxtItemQuantity.Name = "TxtItemQuantity"
        Me.TxtItemQuantity.Size = New System.Drawing.Size(83, 27)
        Me.TxtItemQuantity.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(72, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Item Quantity"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.RequestView)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(601, 117)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 306)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Request"
        '
        'RequestView
        '
        Me.RequestView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RequestView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.RequestView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequestView.Location = New System.Drawing.Point(21, 29)
        Me.RequestView.Name = "RequestView"
        Me.RequestView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.RequestView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RequestView.Size = New System.Drawing.Size(633, 259)
        Me.RequestView.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(308, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ITEM REQUITION"
        '
        'btnAddR
        '
        Me.btnAddR.BackColor = System.Drawing.Color.Transparent
        Me.btnAddR.BackgroundImage = CType(resources.GetObject("btnAddR.BackgroundImage"), System.Drawing.Image)
        Me.btnAddR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddR.Location = New System.Drawing.Point(249, 388)
        Me.btnAddR.Name = "btnAddR"
        Me.btnAddR.Size = New System.Drawing.Size(95, 52)
        Me.btnAddR.TabIndex = 8
        Me.btnAddR.UseVisualStyleBackColor = False
        '
        'DateTimeRequest
        '
        Me.DateTimeRequest.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeRequest.Location = New System.Drawing.Point(257, 271)
        Me.DateTimeRequest.Name = "DateTimeRequest"
        Me.DateTimeRequest.Size = New System.Drawing.Size(258, 27)
        Me.DateTimeRequest.TabIndex = 7
        '
        'TxtRequestID
        '
        Me.TxtRequestID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRequestID.Location = New System.Drawing.Point(257, 96)
        Me.TxtRequestID.Name = "TxtRequestID"
        Me.TxtRequestID.Size = New System.Drawing.Size(100, 27)
        Me.TxtRequestID.TabIndex = 6
        '
        'CmbItemCode
        '
        Me.CmbItemCode.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbItemCode.FormattingEnabled = True
        Me.CmbItemCode.Location = New System.Drawing.Point(257, 147)
        Me.CmbItemCode.Name = "CmbItemCode"
        Me.CmbItemCode.Size = New System.Drawing.Size(173, 28)
        Me.CmbItemCode.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(80, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Request Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(98, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Request ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(106, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Code"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(-4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 157)
        Me.Panel1.TabIndex = 4
        '
        'Technician
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 675)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Technician"
        Me.Text = "ORDER REQUEST"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.RequestView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAddR As System.Windows.Forms.Button
    Friend WithEvents DateTimeRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtRequestID As System.Windows.Forms.TextBox
    Friend WithEvents CmbItemCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RequestView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtItemQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnViewCurrentStock As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateR As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteR As System.Windows.Forms.Button
    Friend WithEvents BtnNewR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
