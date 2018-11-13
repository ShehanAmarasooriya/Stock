<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysAdmin))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AdminDisplay = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.CmbUserType = New System.Windows.Forms.ComboBox()
        Me.CmbRank = New System.Windows.Forms.ComboBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AdminDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.CmbUserType)
        Me.Panel2.Controls.Add(Me.CmbRank)
        Me.Panel2.Controls.Add(Me.TxtPassword)
        Me.Panel2.Controls.Add(Me.TxtUserName)
        Me.Panel2.Controls.Add(Me.TxtName)
        Me.Panel2.Controls.Add(Me.TxtUserID)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(-6, 142)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1313, 585)
        Me.Panel2.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.AdminDisplay)
        Me.GroupBox1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(544, 107)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 377)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Registration"
        '
        'AdminDisplay
        '
        Me.AdminDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AdminDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDisplay.Location = New System.Drawing.Point(16, 26)
        Me.AdminDisplay.Name = "AdminDisplay"
        Me.AdminDisplay.Size = New System.Drawing.Size(712, 331)
        Me.AdminDisplay.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources._11_2_2
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button1.Location = New System.Drawing.Point(71, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 52)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackgroundImage = Global.MiniProjectFinal.My.Resources.Resources.Delete_
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnDelete.Location = New System.Drawing.Point(185, 492)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(84, 52)
        Me.BtnDelete.TabIndex = 21
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnAdd.Location = New System.Drawing.Point(293, 492)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 52)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(243, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "User Registration"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnUpdate.Location = New System.Drawing.Point(400, 490)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 52)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'CmbUserType
        '
        Me.CmbUserType.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUserType.FormattingEnabled = True
        Me.CmbUserType.Items.AddRange(New Object() {"Technician", "Officier", "Inventory Holder"})
        Me.CmbUserType.Location = New System.Drawing.Point(242, 269)
        Me.CmbUserType.Name = "CmbUserType"
        Me.CmbUserType.Size = New System.Drawing.Size(209, 28)
        Me.CmbUserType.TabIndex = 12
        '
        'CmbRank
        '
        Me.CmbRank.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbRank.FormattingEnabled = True
        Me.CmbRank.Items.AddRange(New Object() {"WG SDR", "SQN LDR", "FLT LT", "FG OFF", "PLT OFF", "MWO", "WO", "F/SGT", "SGT", "CPL", "LAC", "AC"})
        Me.CmbRank.Location = New System.Drawing.Point(242, 148)
        Me.CmbRank.Name = "CmbRank"
        Me.CmbRank.Size = New System.Drawing.Size(209, 28)
        Me.CmbRank.TabIndex = 11
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(242, 395)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(276, 27)
        Me.TxtPassword.TabIndex = 10
        '
        'TxtUserName
        '
        Me.TxtUserName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(242, 331)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(276, 27)
        Me.TxtUserName.TabIndex = 9
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(242, 210)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(276, 27)
        Me.TxtName.TabIndex = 8
        '
        'TxtUserID
        '
        Me.TxtUserID.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserID.Location = New System.Drawing.Point(242, 89)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(166, 27)
        Me.TxtUserID.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(55, 402)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(40, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(54, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "User Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(84, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(88, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rank"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(67, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1296, 137)
        Me.Panel1.TabIndex = 6
        '
        'SysAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 713)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SysAdmin"
        Me.Text = "ADMIN"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AdminDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents CmbRank As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AdminDisplay As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
