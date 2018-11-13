<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventoryHolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventoryHolder))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtReOrderLimit = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.TxtManufacture = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtWarrantyPeriod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtItemName = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RegisterView = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CmbItemCategroy = New System.Windows.Forms.ComboBox()
        Me.TxtItemCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbitemcode = New System.Windows.Forms.ComboBox()
        Me.CmbLocation = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnnew1 = New System.Windows.Forms.Button()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StockView = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtStockID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtIssueID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.TxQuantity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRequestID = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Issueview = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReceivedView = New System.Windows.Forms.DataGridView()
        Me.TxtITeamCode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.RegisterView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.StockView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Issueview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReceivedView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(11, 165)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1349, 727)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.TxtReOrderLimit)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.btnNew)
        Me.TabPage1.Controls.Add(Me.TxtManufacture)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtWarrantyPeriod)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TxtItemName)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.btnUpdate)
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.CmbItemCategroy)
        Me.TabPage1.Controls.Add(Me.TxtItemCode)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1341, 694)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Item Registration"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtReOrderLimit
        '
        Me.TxtReOrderLimit.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReOrderLimit.Location = New System.Drawing.Point(235, 235)
        Me.TxtReOrderLimit.Name = "TxtReOrderLimit"
        Me.TxtReOrderLimit.Size = New System.Drawing.Size(133, 26)
        Me.TxtReOrderLimit.TabIndex = 61
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(39, 232)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(135, 20)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Re Order Limit"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources._11
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNew.Location = New System.Drawing.Point(137, 393)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(117, 46)
        Me.btnNew.TabIndex = 59
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'TxtManufacture
        '
        Me.TxtManufacture.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtManufacture.Location = New System.Drawing.Point(233, 318)
        Me.TxtManufacture.Name = "TxtManufacture"
        Me.TxtManufacture.Size = New System.Drawing.Size(164, 27)
        Me.TxtManufacture.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Manufacture"
        '
        'TxtWarrantyPeriod
        '
        Me.TxtWarrantyPeriod.Font = New System.Drawing.Font("Centaur", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWarrantyPeriod.Location = New System.Drawing.Point(235, 274)
        Me.TxtWarrantyPeriod.Name = "TxtWarrantyPeriod"
        Me.TxtWarrantyPeriod.Size = New System.Drawing.Size(133, 26)
        Me.TxtWarrantyPeriod.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 20)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Warranty Period"
        '
        'TxtItemName
        '
        Me.TxtItemName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(233, 189)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(317, 27)
        Me.TxtItemName.TabIndex = 54
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox4.Controls.Add(Me.RegisterView)
        Me.GroupBox4.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(613, 13)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(700, 367)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registered Items"
        '
        'RegisterView
        '
        Me.RegisterView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RegisterView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.RegisterView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegisterView.Location = New System.Drawing.Point(14, 31)
        Me.RegisterView.Name = "RegisterView"
        Me.RegisterView.Size = New System.Drawing.Size(673, 318)
        Me.RegisterView.TabIndex = 51
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Location = New System.Drawing.Point(386, 393)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(93, 45)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Location = New System.Drawing.Point(497, 393)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 45)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(269, 394)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 45)
        Me.btnSave.TabIndex = 34
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CmbItemCategroy
        '
        Me.CmbItemCategroy.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbItemCategroy.FormattingEnabled = True
        Me.CmbItemCategroy.Items.AddRange(New Object() {"RPC", "SVP"})
        Me.CmbItemCategroy.Location = New System.Drawing.Point(233, 134)
        Me.CmbItemCategroy.Name = "CmbItemCategroy"
        Me.CmbItemCategroy.Size = New System.Drawing.Size(133, 28)
        Me.CmbItemCategroy.TabIndex = 31
        '
        'TxtItemCode
        '
        Me.TxtItemCode.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemCode.Location = New System.Drawing.Point(233, 85)
        Me.TxtItemCode.Name = "TxtItemCode"
        Me.TxtItemCode.Size = New System.Drawing.Size(133, 27)
        Me.TxtItemCode.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(85, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Item Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Item Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Item Code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ITEM REGISTRATION"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.cmbitemcode)
        Me.TabPage2.Controls.Add(Me.CmbLocation)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.btnnew1)
        Me.TabPage2.Controls.Add(Me.TxtQuantity)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.btnUpdate2)
        Me.TabPage2.Controls.Add(Me.btnDelete2)
        Me.TabPage2.Controls.Add(Me.btnSave2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TxtStockID)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1341, 694)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock In"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbitemcode
        '
        Me.cmbitemcode.FormattingEnabled = True
        Me.cmbitemcode.Location = New System.Drawing.Point(236, 127)
        Me.cmbitemcode.Name = "cmbitemcode"
        Me.cmbitemcode.Size = New System.Drawing.Size(174, 28)
        Me.cmbitemcode.TabIndex = 59
        '
        'CmbLocation
        '
        Me.CmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLocation.FormattingEnabled = True
        Me.CmbLocation.Items.AddRange(New Object() {"(A1,B2)", "(B5,C7)", "(H7,N9)", "(C5,A3)", "(I7,V8)", "(D5,M9)", "(S2,A5)", "(C6,B7)", "(Q1,5B) "})
        Me.CmbLocation.Location = New System.Drawing.Point(236, 231)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(119, 28)
        Me.CmbLocation.TabIndex = 58
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(105, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Location"
        '
        'btnnew1
        '
        Me.btnnew1.BackColor = System.Drawing.Color.Transparent
        Me.btnnew1.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources._11_3
        Me.btnnew1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnnew1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnew1.Location = New System.Drawing.Point(77, 388)
        Me.btnnew1.Name = "btnnew1"
        Me.btnnew1.Size = New System.Drawing.Size(95, 45)
        Me.btnnew1.TabIndex = 56
        Me.btnnew1.UseVisualStyleBackColor = False
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(236, 178)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(100, 27)
        Me.TxtQuantity.TabIndex = 55
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox3.Controls.Add(Me.StockView)
        Me.GroupBox3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(538, 33)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(774, 297)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock In Items"
        '
        'StockView
        '
        Me.StockView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockView.Location = New System.Drawing.Point(15, 30)
        Me.StockView.Name = "StockView"
        Me.StockView.Size = New System.Drawing.Size(747, 251)
        Me.StockView.TabIndex = 51
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(236, 287)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(263, 27)
        Me.DateTimePicker2.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(113, 292)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "In Date"
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(564, 388)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(110, 46)
        Me.Button11.TabIndex = 43
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = True
        '
        'btnUpdate2
        '
        Me.btnUpdate2.BackgroundImage = CType(resources.GetObject("btnUpdate2.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate2.Location = New System.Drawing.Point(307, 387)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(94, 46)
        Me.btnUpdate2.TabIndex = 39
        Me.btnUpdate2.UseVisualStyleBackColor = True
        '
        'btnDelete2
        '
        Me.btnDelete2.BackgroundImage = CType(resources.GetObject("btnDelete2.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete2.Location = New System.Drawing.Point(442, 388)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(97, 46)
        Me.btnDelete2.TabIndex = 38
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.BackgroundImage = CType(resources.GetObject("btnSave2.BackgroundImage"), System.Drawing.Image)
        Me.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave2.Location = New System.Drawing.Point(192, 388)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(91, 46)
        Me.btnSave2.TabIndex = 35
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(91, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Item Code"
        '
        'TxtStockID
        '
        Me.TxtStockID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockID.Location = New System.Drawing.Point(236, 70)
        Me.TxtStockID.Name = "TxtStockID"
        Me.TxtStockID.Size = New System.Drawing.Size(204, 27)
        Me.TxtStockID.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "STOCK IN REGISTER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(105, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Quantity"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(105, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 20)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Stock ID"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.txtIssueID)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.btnIssue)
        Me.TabPage3.Controls.Add(Me.TxQuantity)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txtRequestID)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.TxtITeamCode)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.DateTimePicker1)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1341, 694)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Item Issue"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtIssueID
        '
        Me.txtIssueID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssueID.Location = New System.Drawing.Point(189, 91)
        Me.txtIssueID.Name = "txtIssueID"
        Me.txtIssueID.Size = New System.Drawing.Size(199, 27)
        Me.txtIssueID.TabIndex = 64
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(55, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 20)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Issue ID"
        '
        'btnIssue
        '
        Me.btnIssue.BackColor = System.Drawing.Color.Transparent
        Me.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIssue.Location = New System.Drawing.Point(128, 358)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(118, 47)
        Me.btnIssue.TabIndex = 62
        Me.btnIssue.Text = "Item Issued"
        Me.btnIssue.UseVisualStyleBackColor = False
        '
        'TxQuantity
        '
        Me.TxQuantity.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxQuantity.Location = New System.Drawing.Point(190, 241)
        Me.TxQuantity.Name = "TxQuantity"
        Me.TxQuantity.Size = New System.Drawing.Size(248, 27)
        Me.TxQuantity.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 20)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Item Quantity"
        '
        'txtRequestID
        '
        Me.txtRequestID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestID.Location = New System.Drawing.Point(190, 141)
        Me.txtRequestID.Name = "txtRequestID"
        Me.txtRequestID.Size = New System.Drawing.Size(199, 27)
        Me.txtRequestID.TabIndex = 59
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(56, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 20)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Request ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox2.Controls.Add(Me.Issueview)
        Me.GroupBox2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(616, 245)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 226)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Issued Request"
        '
        'Issueview
        '
        Me.Issueview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Issueview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Issueview.Location = New System.Drawing.Point(21, 30)
        Me.Issueview.Name = "Issueview"
        Me.Issueview.Size = New System.Drawing.Size(604, 183)
        Me.Issueview.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.ReceivedView)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(616, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 216)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Received  Request"
        '
        'ReceivedView
        '
        Me.ReceivedView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceivedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceivedView.Location = New System.Drawing.Point(21, 30)
        Me.ReceivedView.Name = "ReceivedView"
        Me.ReceivedView.Size = New System.Drawing.Size(604, 175)
        Me.ReceivedView.TabIndex = 51
        '
        'TxtITeamCode
        '
        Me.TxtITeamCode.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtITeamCode.Location = New System.Drawing.Point(190, 191)
        Me.TxtITeamCode.Name = "TxtITeamCode"
        Me.TxtITeamCode.Size = New System.Drawing.Size(248, 27)
        Me.TxtITeamCode.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(55, 198)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 20)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Item Code"
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(295, 358)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(130, 53)
        Me.Button10.TabIndex = 43
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(190, 290)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(268, 27)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(145, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(280, 25)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "ITEM ISSUE REGISTER"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(61, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Issue Date"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 157)
        Me.Panel1.TabIndex = 4
        '
        'inventoryHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 675)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "inventoryHolder"
        Me.Text = "Inventory Holder"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.RegisterView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.StockView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Issueview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ReceivedView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtStockID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CmbItemCategroy As System.Windows.Forms.ComboBox
    Friend WithEvents TxtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave2 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate2 As System.Windows.Forms.Button
    Friend WithEvents btnDelete2 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtITeamCode As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ReceivedView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Issueview As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents StockView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RegisterView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtItemName As System.Windows.Forms.TextBox
    Friend WithEvents TxtWarrantyPeriod As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtManufacture As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents TxtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnnew1 As System.Windows.Forms.Button
    Friend WithEvents CmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbitemcode As System.Windows.Forms.ComboBox
    Friend WithEvents txtRequestID As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnIssue As System.Windows.Forms.Button
    Friend WithEvents txtIssueID As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtReOrderLimit As TextBox
    Friend WithEvents Label19 As Label
End Class
