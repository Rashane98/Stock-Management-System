<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuplierPayments
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
        Dim Label8 As System.Windows.Forms.Label
        Dim PayTypeLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.creditDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.AmountTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaymentsDataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Label8 = New System.Windows.Forms.Label()
        PayTypeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.creditDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(1004, 42)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(67, 20)
        Label8.TabIndex = 258
        Label8.Text = "PDate:"
        '
        'PayTypeLabel
        '
        PayTypeLabel.AutoSize = True
        PayTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PayTypeLabel.Location = New System.Drawing.Point(1003, 157)
        PayTypeLabel.Name = "PayTypeLabel"
        PayTypeLabel.Size = New System.Drawing.Size(92, 20)
        PayTypeLabel.TabIndex = 267
        PayTypeLabel.Text = "Pay Type:"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BorderRadius = 6
        Me.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTxt.DefaultText = ""
        Me.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.DisabledState.Parent = Me.PasswordTxt
        Me.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.FocusedState.Parent = Me.PasswordTxt
        Me.PasswordTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.HoverState.Parent = Me.PasswordTxt
        Me.PasswordTxt.Location = New System.Drawing.Point(1111, 387)
        Me.PasswordTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PasswordTxt.PlaceholderText = ""
        Me.PasswordTxt.SelectedText = ""
        Me.PasswordTxt.ShadowDecoration.Parent = Me.PasswordTxt
        Me.PasswordTxt.Size = New System.Drawing.Size(232, 29)
        Me.PasswordTxt.TabIndex = 266
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(1004, 308)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(170, 33)
        Me.Guna2Button3.TabIndex = 265
        Me.Guna2Button3.Text = "Delete"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1004, 351)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(339, 28)
        Me.ComboBox1.TabIndex = 263
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(1180, 308)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(163, 33)
        Me.Guna2Button1.TabIndex = 262
        Me.Guna2Button1.Text = "Print"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1004, 588)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 38)
        Me.Label4.TabIndex = 261
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchTxt
        '
        Me.SearchTxt.BorderRadius = 6
        Me.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTxt.DefaultText = ""
        Me.SearchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTxt.DisabledState.Parent = Me.SearchTxt
        Me.SearchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTxt.FocusedState.Parent = Me.SearchTxt
        Me.SearchTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SearchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTxt.HoverState.Parent = Me.SearchTxt
        Me.SearchTxt.Location = New System.Drawing.Point(1004, 542)
        Me.SearchTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SearchTxt.PlaceholderText = ""
        Me.SearchTxt.SelectedText = ""
        Me.SearchTxt.ShadowDecoration.Parent = Me.SearchTxt
        Me.SearchTxt.Size = New System.Drawing.Size(339, 33)
        Me.SearchTxt.TabIndex = 259
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1000, 517)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "Supplier Name:"
        '
        'AddDateTimePicker
        '
        Me.AddDateTimePicker.CustomFormat = "yyyy-MM-dd"
        Me.AddDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AddDateTimePicker.Location = New System.Drawing.Point(1004, 63)
        Me.AddDateTimePicker.Margin = New System.Windows.Forms.Padding(1)
        Me.AddDateTimePicker.Name = "AddDateTimePicker"
        Me.AddDateTimePicker.Size = New System.Drawing.Size(339, 29)
        Me.AddDateTimePicker.TabIndex = 257
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.creditDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 460)
        Me.Panel1.TabIndex = 256
        '
        'creditDataGridView
        '
        Me.creditDataGridView.AllowUserToAddRows = False
        Me.creditDataGridView.AllowUserToDeleteRows = False
        Me.creditDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.creditDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.creditDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.creditDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.creditDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.creditDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.creditDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.creditDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.creditDataGridView.ColumnHeadersHeight = 30
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.creditDataGridView.DefaultCellStyle = DataGridViewCellStyle15
        Me.creditDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.creditDataGridView.EnableHeadersVisualStyles = False
        Me.creditDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.creditDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.creditDataGridView.Name = "creditDataGridView"
        Me.creditDataGridView.ReadOnly = True
        Me.creditDataGridView.RowHeadersVisible = False
        Me.creditDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.creditDataGridView.Size = New System.Drawing.Size(984, 460)
        Me.creditDataGridView.TabIndex = 3
        Me.creditDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.creditDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.creditDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.creditDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.creditDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.creditDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.creditDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.creditDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.creditDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.creditDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.creditDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.creditDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.creditDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.creditDataGridView.ThemeStyle.HeaderStyle.Height = 30
        Me.creditDataGridView.ThemeStyle.ReadOnly = True
        Me.creditDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.creditDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.creditDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.creditDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.creditDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.creditDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.creditDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SaveBtn
        '
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(1180, 269)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(163, 33)
        Me.SaveBtn.TabIndex = 255
        Me.SaveBtn.Text = "Save"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1003, 460)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 20)
        Me.Label14.TabIndex = 254
        Me.Label14.Text = "End Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1000, 403)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 253
        Me.Label13.Text = "Start Date"
        '
        'EndDate
        '
        Me.EndDate.CustomFormat = "yyyy-MM-dd"
        Me.EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDate.Location = New System.Drawing.Point(1004, 485)
        Me.EndDate.Margin = New System.Windows.Forms.Padding(1)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(339, 29)
        Me.EndDate.TabIndex = 252
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "yyyy-MM-dd"
        Me.StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDate.Location = New System.Drawing.Point(1004, 430)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(1)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(339, 29)
        Me.StartDate.TabIndex = 251
        '
        'AmountTxt
        '
        Me.AmountTxt.BorderRadius = 6
        Me.AmountTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AmountTxt.DefaultText = ""
        Me.AmountTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AmountTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AmountTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AmountTxt.DisabledState.Parent = Me.AmountTxt
        Me.AmountTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AmountTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AmountTxt.FocusedState.Parent = Me.AmountTxt
        Me.AmountTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AmountTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AmountTxt.HoverState.Parent = Me.AmountTxt
        Me.AmountTxt.Location = New System.Drawing.Point(1004, 232)
        Me.AmountTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AmountTxt.Name = "AmountTxt"
        Me.AmountTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AmountTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AmountTxt.PlaceholderText = ""
        Me.AmountTxt.SelectedText = ""
        Me.AmountTxt.ShadowDecoration.Parent = Me.AmountTxt
        Me.AmountTxt.Size = New System.Drawing.Size(339, 33)
        Me.AmountTxt.TabIndex = 249
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1006, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 250
        Me.Label2.Text = "Amount:"
        '
        'NameTxt
        '
        Me.NameTxt.BorderRadius = 6
        Me.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameTxt.DefaultText = ""
        Me.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxt.DisabledState.Parent = Me.NameTxt
        Me.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxt.FocusedState.Parent = Me.NameTxt
        Me.NameTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxt.HoverState.Parent = Me.NameTxt
        Me.NameTxt.Location = New System.Drawing.Point(1004, 119)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.NameTxt.PlaceholderText = ""
        Me.NameTxt.SelectedText = ""
        Me.NameTxt.ShadowDecoration.Parent = Me.NameTxt
        Me.NameTxt.Size = New System.Drawing.Size(339, 33)
        Me.NameTxt.TabIndex = 247
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1003, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 248
        Me.Label1.Text = "Supplier Name:"
        '
        'PaymentsDataGridView1
        '
        Me.PaymentsDataGridView1.AllowUserToAddRows = False
        Me.PaymentsDataGridView1.AllowUserToDeleteRows = False
        Me.PaymentsDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.PaymentsDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.PaymentsDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PaymentsDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.PaymentsDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PaymentsDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PaymentsDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PaymentsDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.PaymentsDataGridView1.ColumnHeadersHeight = 30
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PaymentsDataGridView1.DefaultCellStyle = DataGridViewCellStyle18
        Me.PaymentsDataGridView1.EnableHeadersVisualStyles = False
        Me.PaymentsDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentsDataGridView1.Location = New System.Drawing.Point(0, 49)
        Me.PaymentsDataGridView1.Name = "PaymentsDataGridView1"
        Me.PaymentsDataGridView1.ReadOnly = True
        Me.PaymentsDataGridView1.RowHeadersVisible = False
        Me.PaymentsDataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PaymentsDataGridView1.Size = New System.Drawing.Size(997, 577)
        Me.PaymentsDataGridView1.TabIndex = 246
        Me.PaymentsDataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.PaymentsDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PaymentsDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PaymentsDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PaymentsDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PaymentsDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PaymentsDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PaymentsDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentsDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentsDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PaymentsDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.PaymentsDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.PaymentsDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PaymentsDataGridView1.ThemeStyle.HeaderStyle.Height = 30
        Me.PaymentsDataGridView1.ThemeStyle.ReadOnly = True
        Me.PaymentsDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PaymentsDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PaymentsDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.PaymentsDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PaymentsDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.PaymentsDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentsDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Cash", "Chaque"})
        Me.ComboBox2.Location = New System.Drawing.Point(1008, 179)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(335, 28)
        Me.ComboBox2.TabIndex = 268
        Me.ComboBox2.Text = "Cash"
        '
        'AddBtn
        '
        Me.AddBtn.CheckedState.Parent = Me.AddBtn
        Me.AddBtn.CustomImages.Parent = Me.AddBtn
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.HoverState.Parent = Me.AddBtn
        Me.AddBtn.Location = New System.Drawing.Point(1004, 269)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(170, 31)
        Me.AddBtn.TabIndex = 269
        Me.AddBtn.Text = "Add"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Supplier Payments"
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
        Me.Guna2Panel4.TabIndex = 271
        '
        'SuplierPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 638)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(PayTypeLabel)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.AddDateTimePicker)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.AmountTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PaymentsDataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuplierPayments"
        Me.Text = "SuplierPayments"
        Me.Panel1.ResumeLayout(False)
        CType(Me.creditDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddDateTimePicker As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents creditDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents AmountTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PaymentsDataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
End Class
