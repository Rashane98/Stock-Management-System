<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendMessages
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SupplierDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Tel_NoTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AllowUserToAddRows = False
        Me.SupplierDataGridView.AllowUserToDeleteRows = False
        Me.SupplierDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.SupplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SupplierDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SupplierDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SupplierDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SupplierDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.SupplierDataGridView.ColumnHeadersHeight = 30
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SupplierDataGridView.DefaultCellStyle = DataGridViewCellStyle18
        Me.SupplierDataGridView.EnableHeadersVisualStyles = False
        Me.SupplierDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.Location = New System.Drawing.Point(3, 46)
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        Me.SupplierDataGridView.ReadOnly = True
        Me.SupplierDataGridView.RowHeadersVisible = False
        Me.SupplierDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SupplierDataGridView.Size = New System.Drawing.Size(941, 580)
        Me.SupplierDataGridView.TabIndex = 271
        Me.SupplierDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SupplierDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SupplierDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.SupplierDataGridView.ThemeStyle.HeaderStyle.Height = 30
        Me.SupplierDataGridView.ThemeStyle.ReadOnly = True
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SupplierDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Tel_NoTextBox
        '
        Me.Tel_NoTextBox.BorderRadius = 6
        Me.Tel_NoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Tel_NoTextBox.DefaultText = ""
        Me.Tel_NoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Tel_NoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Tel_NoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Tel_NoTextBox.DisabledState.Parent = Me.Tel_NoTextBox
        Me.Tel_NoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Tel_NoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tel_NoTextBox.FocusedState.Parent = Me.Tel_NoTextBox
        Me.Tel_NoTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tel_NoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Tel_NoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tel_NoTextBox.HoverState.Parent = Me.Tel_NoTextBox
        Me.Tel_NoTextBox.Location = New System.Drawing.Point(957, 129)
        Me.Tel_NoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tel_NoTextBox.Name = "Tel_NoTextBox"
        Me.Tel_NoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Tel_NoTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Tel_NoTextBox.PlaceholderText = ""
        Me.Tel_NoTextBox.SelectedText = ""
        Me.Tel_NoTextBox.ShadowDecoration.Parent = Me.Tel_NoTextBox
        Me.Tel_NoTextBox.Size = New System.Drawing.Size(378, 27)
        Me.Tel_NoTextBox.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(953, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "TelephoneNo :"
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderRadius = 6
        Me.NameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameTextBox.DefaultText = ""
        Me.NameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTextBox.DisabledState.Parent = Me.NameTextBox
        Me.NameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTextBox.FocusedState.Parent = Me.NameTextBox
        Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.NameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTextBox.HoverState.Parent = Me.NameTextBox
        Me.NameTextBox.Location = New System.Drawing.Point(957, 72)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.NameTextBox.PlaceholderText = ""
        Me.NameTextBox.SelectedText = ""
        Me.NameTextBox.ShadowDecoration.Parent = Me.NameTextBox
        Me.NameTextBox.Size = New System.Drawing.Size(378, 27)
        Me.NameTextBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(956, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(273, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Send Messages to suppliers"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.Label12)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1350, 43)
        Me.Guna2Panel4.TabIndex = 272
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Image = Global.StockmanageTouchSystem.My.Resources.Resources.sign_out_option
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(1302, 5)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(41, 35)
        Me.Guna2Button4.TabIndex = 4
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 6
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(7, 125)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2TextBox1.PlaceholderText = "City Search"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(377, 33)
        Me.Guna2TextBox1.TabIndex = 275
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 276
        Me.Label8.Text = "City :"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderRadius = 6
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(7, 56)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2TextBox2.PlaceholderText = "Name Search"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(377, 33)
        Me.Guna2TextBox2.TabIndex = 273
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 274
        Me.Label9.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guna2TextBox2)
        Me.GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(951, 446)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 180)
        Me.GroupBox1.TabIndex = 277
        Me.GroupBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(960, 164)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(375, 224)
        Me.RichTextBox1.TabIndex = 278
        Me.RichTextBox1.Text = ""
        '
        'AddBtn
        '
        Me.AddBtn.CheckedState.Parent = Me.AddBtn
        Me.AddBtn.CustomImages.Parent = Me.AddBtn
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.HoverState.Parent = Me.AddBtn
        Me.AddBtn.Location = New System.Drawing.Point(1103, 394)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(232, 46)
        Me.AddBtn.TabIndex = 279
        Me.AddBtn.Text = "Send Message"
        '
        'SendMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 638)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tel_NoTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SupplierDataGridView)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SendMessages"
        Me.Text = "SendMessages"
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SupplierDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Tel_NoTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
End Class
