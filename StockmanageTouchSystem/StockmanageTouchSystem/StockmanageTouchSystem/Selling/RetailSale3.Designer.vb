<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetailSale3
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BrandTxt = New System.Windows.Forms.TextBox()
        Me.BarCodeTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BalanceGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ItemsShow = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.TimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DeleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.NextBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NetAmountTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.InvLbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InvSaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.AmountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DiscountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Unit_PriceTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QutTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DesTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RetailDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CNameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BillTypeCombo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.BalanceGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.RetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Retail Sale 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(573, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 400
        Me.Label8.Text = "Brand :"
        '
        'BrandTxt
        '
        Me.BrandTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BrandTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BrandTxt.Location = New System.Drawing.Point(577, 88)
        Me.BrandTxt.Multiline = True
        Me.BrandTxt.Name = "BrandTxt"
        Me.BrandTxt.Size = New System.Drawing.Size(217, 30)
        Me.BrandTxt.TabIndex = 399
        '
        'BarCodeTxt
        '
        Me.BarCodeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BarCodeTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BarCodeTxt.Location = New System.Drawing.Point(16, 147)
        Me.BarCodeTxt.Name = "BarCodeTxt"
        Me.BarCodeTxt.Size = New System.Drawing.Size(263, 22)
        Me.BarCodeTxt.TabIndex = 398
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BalanceGridView)
        Me.Panel1.Controls.Add(Me.ItemsShow)
        Me.Panel1.Location = New System.Drawing.Point(16, 180)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 457)
        Me.Panel1.TabIndex = 375
        '
        'BalanceGridView
        '
        Me.BalanceGridView.AllowUserToAddRows = False
        Me.BalanceGridView.AllowUserToDeleteRows = False
        Me.BalanceGridView.AllowUserToResizeColumns = False
        Me.BalanceGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.BalanceGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.BalanceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BalanceGridView.BackgroundColor = System.Drawing.Color.White
        Me.BalanceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BalanceGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BalanceGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BalanceGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.BalanceGridView.ColumnHeadersHeight = 30
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BalanceGridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.BalanceGridView.EnableHeadersVisualStyles = False
        Me.BalanceGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BalanceGridView.Location = New System.Drawing.Point(78, 3)
        Me.BalanceGridView.Name = "BalanceGridView"
        Me.BalanceGridView.ReadOnly = True
        Me.BalanceGridView.RowHeadersVisible = False
        Me.BalanceGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BalanceGridView.Size = New System.Drawing.Size(1077, 344)
        Me.BalanceGridView.TabIndex = 14
        Me.BalanceGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.BalanceGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BalanceGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BalanceGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BalanceGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BalanceGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BalanceGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.BalanceGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BalanceGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BalanceGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BalanceGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BalanceGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BalanceGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BalanceGridView.ThemeStyle.HeaderStyle.Height = 30
        Me.BalanceGridView.ThemeStyle.ReadOnly = True
        Me.BalanceGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BalanceGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BalanceGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BalanceGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BalanceGridView.ThemeStyle.RowsStyle.Height = 22
        Me.BalanceGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BalanceGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ItemsShow
        '
        Me.ItemsShow.AllowUserToAddRows = False
        Me.ItemsShow.AllowUserToDeleteRows = False
        Me.ItemsShow.AllowUserToResizeColumns = False
        Me.ItemsShow.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.ItemsShow.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.ItemsShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ItemsShow.BackgroundColor = System.Drawing.Color.White
        Me.ItemsShow.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemsShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemsShow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ItemsShow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.ItemsShow.ColumnHeadersHeight = 30
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ItemsShow.DefaultCellStyle = DataGridViewCellStyle15
        Me.ItemsShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsShow.EnableHeadersVisualStyles = False
        Me.ItemsShow.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemsShow.Location = New System.Drawing.Point(0, 0)
        Me.ItemsShow.Name = "ItemsShow"
        Me.ItemsShow.ReadOnly = True
        Me.ItemsShow.RowHeadersVisible = False
        Me.ItemsShow.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ItemsShow.Size = New System.Drawing.Size(1338, 457)
        Me.ItemsShow.TabIndex = 13
        Me.ItemsShow.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.ItemsShow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemsShow.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ItemsShow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ItemsShow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ItemsShow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ItemsShow.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ItemsShow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemsShow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemsShow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ItemsShow.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ItemsShow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ItemsShow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ItemsShow.ThemeStyle.HeaderStyle.Height = 30
        Me.ItemsShow.ThemeStyle.ReadOnly = True
        Me.ItemsShow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ItemsShow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ItemsShow.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.ItemsShow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ItemsShow.ThemeStyle.RowsStyle.Height = 22
        Me.ItemsShow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ItemsShow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.Label12)
        Me.Guna2Panel4.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(1362, 43)
        Me.Guna2Panel4.TabIndex = 397
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Image = Global.StockmanageTouchSystem.My.Resources.Resources.sign_out_option
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(1314, 5)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(41, 35)
        Me.Guna2Button1.TabIndex = 4
        '
        'TimePicker1
        '
        Me.TimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimePicker1.Location = New System.Drawing.Point(963, 87)
        Me.TimePicker1.Name = "TimePicker1"
        Me.TimePicker1.Size = New System.Drawing.Size(387, 26)
        Me.TimePicker1.TabIndex = 396
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1112, 643)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(242, 28)
        Me.ComboBox1.TabIndex = 395
        '
        'DeleteBtn
        '
        Me.DeleteBtn.CheckedState.Parent = Me.DeleteBtn
        Me.DeleteBtn.CustomImages.Parent = Me.DeleteBtn
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.HoverState.Parent = Me.DeleteBtn
        Me.DeleteBtn.Location = New System.Drawing.Point(403, 622)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.ShadowDecoration.Parent = Me.DeleteBtn
        Me.DeleteBtn.Size = New System.Drawing.Size(123, 40)
        Me.DeleteBtn.TabIndex = 393
        Me.DeleteBtn.Text = "Delete"
        '
        'NextBtn
        '
        Me.NextBtn.CheckedState.Parent = Me.NextBtn
        Me.NextBtn.CustomImages.Parent = Me.NextBtn
        Me.NextBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.ForeColor = System.Drawing.Color.White
        Me.NextBtn.HoverState.Parent = Me.NextBtn
        Me.NextBtn.Location = New System.Drawing.Point(274, 622)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.ShadowDecoration.Parent = Me.NextBtn
        Me.NextBtn.Size = New System.Drawing.Size(123, 40)
        Me.NextBtn.TabIndex = 392
        Me.NextBtn.Text = "Next"
        '
        'SaveBtn
        '
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(145, 622)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(123, 40)
        Me.SaveBtn.TabIndex = 391
        Me.SaveBtn.Text = "Save"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(959, 615)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 20)
        Me.Label10.TabIndex = 390
        Me.Label10.Text = "Net Amount :"
        '
        'NetAmountTxt
        '
        Me.NetAmountTxt.BorderRadius = 6
        Me.NetAmountTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NetAmountTxt.DefaultText = ""
        Me.NetAmountTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NetAmountTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NetAmountTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NetAmountTxt.DisabledState.Parent = Me.NetAmountTxt
        Me.NetAmountTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NetAmountTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NetAmountTxt.FocusedState.Parent = Me.NetAmountTxt
        Me.NetAmountTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetAmountTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.NetAmountTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NetAmountTxt.HoverState.Parent = Me.NetAmountTxt
        Me.NetAmountTxt.Location = New System.Drawing.Point(1147, 602)
        Me.NetAmountTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NetAmountTxt.Name = "NetAmountTxt"
        Me.NetAmountTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NetAmountTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.NetAmountTxt.PlaceholderText = ""
        Me.NetAmountTxt.SelectedText = ""
        Me.NetAmountTxt.ShadowDecoration.Parent = Me.NetAmountTxt
        Me.NetAmountTxt.Size = New System.Drawing.Size(207, 27)
        Me.NetAmountTxt.TabIndex = 389
        '
        'InvLbl
        '
        Me.InvLbl.BackColor = System.Drawing.Color.Yellow
        Me.InvLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvLbl.Location = New System.Drawing.Point(90, 52)
        Me.InvLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InvLbl.Name = "InvLbl"
        Me.InvLbl.Size = New System.Drawing.Size(307, 29)
        Me.InvLbl.TabIndex = 388
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(840, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 20)
        Me.Label9.TabIndex = 387
        Me.Label9.Text = "Selling Date :"
        '
        'InvSaveBtn
        '
        Me.InvSaveBtn.CheckedState.Parent = Me.InvSaveBtn
        Me.InvSaveBtn.CustomImages.Parent = Me.InvSaveBtn
        Me.InvSaveBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvSaveBtn.ForeColor = System.Drawing.Color.White
        Me.InvSaveBtn.HoverState.Parent = Me.InvSaveBtn
        Me.InvSaveBtn.Location = New System.Drawing.Point(16, 621)
        Me.InvSaveBtn.Name = "InvSaveBtn"
        Me.InvSaveBtn.ShadowDecoration.Parent = Me.InvSaveBtn
        Me.InvSaveBtn.Size = New System.Drawing.Size(123, 40)
        Me.InvSaveBtn.TabIndex = 394
        Me.InvSaveBtn.Text = "Inv Save"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1119, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 386
        Me.Label7.Text = "Amount :"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.BorderRadius = 6
        Me.AmountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AmountTextBox.DefaultText = ""
        Me.AmountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AmountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AmountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AmountTextBox.DisabledState.Parent = Me.AmountTextBox
        Me.AmountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AmountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AmountTextBox.FocusedState.Parent = Me.AmountTextBox
        Me.AmountTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AmountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AmountTextBox.HoverState.Parent = Me.AmountTextBox
        Me.AmountTextBox.Location = New System.Drawing.Point(1123, 145)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AmountTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AmountTextBox.PlaceholderText = ""
        Me.AmountTextBox.SelectedText = ""
        Me.AmountTextBox.ShadowDecoration.Parent = Me.AmountTextBox
        Me.AmountTextBox.Size = New System.Drawing.Size(231, 27)
        Me.AmountTextBox.TabIndex = 385
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(987, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 384
        Me.Label6.Text = "Dis :"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.BorderRadius = 6
        Me.DiscountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DiscountTextBox.DefaultText = ""
        Me.DiscountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DiscountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DiscountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.DisabledState.Parent = Me.DiscountTextBox
        Me.DiscountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DiscountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.FocusedState.Parent = Me.DiscountTextBox
        Me.DiscountTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscountTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DiscountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DiscountTextBox.HoverState.Parent = Me.DiscountTextBox
        Me.DiscountTextBox.Location = New System.Drawing.Point(991, 145)
        Me.DiscountTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DiscountTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DiscountTextBox.PlaceholderText = ""
        Me.DiscountTextBox.SelectedText = ""
        Me.DiscountTextBox.ShadowDecoration.Parent = Me.DiscountTextBox
        Me.DiscountTextBox.Size = New System.Drawing.Size(130, 27)
        Me.DiscountTextBox.TabIndex = 383
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(851, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 382
        Me.Label5.Text = "Unit Price :"
        '
        'Unit_PriceTextBox
        '
        Me.Unit_PriceTextBox.BorderRadius = 6
        Me.Unit_PriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Unit_PriceTextBox.DefaultText = ""
        Me.Unit_PriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Unit_PriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Unit_PriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Unit_PriceTextBox.DisabledState.Parent = Me.Unit_PriceTextBox
        Me.Unit_PriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Unit_PriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Unit_PriceTextBox.FocusedState.Parent = Me.Unit_PriceTextBox
        Me.Unit_PriceTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_PriceTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Unit_PriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Unit_PriceTextBox.HoverState.Parent = Me.Unit_PriceTextBox
        Me.Unit_PriceTextBox.Location = New System.Drawing.Point(855, 145)
        Me.Unit_PriceTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Unit_PriceTextBox.Name = "Unit_PriceTextBox"
        Me.Unit_PriceTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Unit_PriceTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Unit_PriceTextBox.PlaceholderText = ""
        Me.Unit_PriceTextBox.SelectedText = ""
        Me.Unit_PriceTextBox.ShadowDecoration.Parent = Me.Unit_PriceTextBox
        Me.Unit_PriceTextBox.Size = New System.Drawing.Size(133, 27)
        Me.Unit_PriceTextBox.TabIndex = 381
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(749, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 380
        Me.Label4.Text = "Qty :"
        '
        'QutTextBox
        '
        Me.QutTextBox.BorderRadius = 6
        Me.QutTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QutTextBox.DefaultText = ""
        Me.QutTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QutTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QutTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QutTextBox.DisabledState.Parent = Me.QutTextBox
        Me.QutTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QutTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QutTextBox.FocusedState.Parent = Me.QutTextBox
        Me.QutTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QutTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.QutTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QutTextBox.HoverState.Parent = Me.QutTextBox
        Me.QutTextBox.Location = New System.Drawing.Point(753, 145)
        Me.QutTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QutTextBox.Name = "QutTextBox"
        Me.QutTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QutTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.QutTextBox.PlaceholderText = ""
        Me.QutTextBox.SelectedText = ""
        Me.QutTextBox.ShadowDecoration.Parent = Me.QutTextBox
        Me.QutTextBox.Size = New System.Drawing.Size(98, 27)
        Me.QutTextBox.TabIndex = 379
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "Description :"
        '
        'DesTxt
        '
        Me.DesTxt.BorderRadius = 6
        Me.DesTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DesTxt.DefaultText = ""
        Me.DesTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DesTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DesTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DesTxt.DisabledState.Parent = Me.DesTxt
        Me.DesTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DesTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DesTxt.FocusedState.Parent = Me.DesTxt
        Me.DesTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DesTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DesTxt.HoverState.Parent = Me.DesTxt
        Me.DesTxt.Location = New System.Drawing.Point(286, 145)
        Me.DesTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DesTxt.Name = "DesTxt"
        Me.DesTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DesTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DesTxt.PlaceholderText = ""
        Me.DesTxt.SelectedText = ""
        Me.DesTxt.ShadowDecoration.Parent = Me.DesTxt
        Me.DesTxt.Size = New System.Drawing.Size(459, 27)
        Me.DesTxt.TabIndex = 377
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 374
        Me.Label2.Text = "Barcode :"
        '
        'RetailDataGridView
        '
        Me.RetailDataGridView.AllowUserToAddRows = False
        Me.RetailDataGridView.AllowUserToDeleteRows = False
        Me.RetailDataGridView.AllowUserToResizeColumns = False
        Me.RetailDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        Me.RetailDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.RetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RetailDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.RetailDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RetailDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RetailDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RetailDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.RetailDataGridView.ColumnHeadersHeight = 30
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RetailDataGridView.DefaultCellStyle = DataGridViewCellStyle18
        Me.RetailDataGridView.EnableHeadersVisualStyles = False
        Me.RetailDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RetailDataGridView.Location = New System.Drawing.Point(15, 180)
        Me.RetailDataGridView.Name = "RetailDataGridView"
        Me.RetailDataGridView.ReadOnly = True
        Me.RetailDataGridView.RowHeadersVisible = False
        Me.RetailDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RetailDataGridView.Size = New System.Drawing.Size(1339, 414)
        Me.RetailDataGridView.TabIndex = 376
        Me.RetailDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.RetailDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.RetailDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.RetailDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.RetailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.RetailDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.RetailDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.RetailDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RetailDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RetailDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.RetailDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.RetailDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.RetailDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.RetailDataGridView.ThemeStyle.HeaderStyle.Height = 30
        Me.RetailDataGridView.ThemeStyle.ReadOnly = True
        Me.RetailDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.RetailDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RetailDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.RetailDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RetailDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.RetailDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RetailDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 373
        Me.Label1.Text = "Name:"
        '
        'CNameTxt
        '
        Me.CNameTxt.BorderRadius = 6
        Me.CNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CNameTxt.DefaultText = "Cash"
        Me.CNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CNameTxt.DisabledState.Parent = Me.CNameTxt
        Me.CNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CNameTxt.FocusedState.Parent = Me.CNameTxt
        Me.CNameTxt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CNameTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.CNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CNameTxt.HoverState.Parent = Me.CNameTxt
        Me.CNameTxt.Location = New System.Drawing.Point(94, 86)
        Me.CNameTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CNameTxt.Name = "CNameTxt"
        Me.CNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CNameTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.CNameTxt.PlaceholderText = ""
        Me.CNameTxt.SelectedText = ""
        Me.CNameTxt.SelectionStart = 4
        Me.CNameTxt.ShadowDecoration.Parent = Me.CNameTxt
        Me.CNameTxt.Size = New System.Drawing.Size(475, 33)
        Me.CNameTxt.TabIndex = 372
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 371
        Me.Label15.Text = "Invo No:"
        '
        'BillTypeCombo
        '
        Me.BillTypeCombo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BillTypeCombo.FormattingEnabled = True
        Me.BillTypeCombo.Items.AddRange(New Object() {"R", "W"})
        Me.BillTypeCombo.Location = New System.Drawing.Point(494, 52)
        Me.BillTypeCombo.Name = "BillTypeCombo"
        Me.BillTypeCombo.Size = New System.Drawing.Size(69, 29)
        Me.BillTypeCombo.TabIndex = 402
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(402, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 401
        Me.Label11.Text = "Bill Type :"
        '
        'RetailSale3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 677)
        Me.Controls.Add(Me.BillTypeCombo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BrandTxt)
        Me.Controls.Add(Me.BarCodeTxt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.TimePicker1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NetAmountTxt)
        Me.Controls.Add(Me.InvLbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.InvSaveBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Unit_PriceTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.QutTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DesTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RetailDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CNameTxt)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RetailSale3"
        Me.Text = "RetailSale3"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BalanceGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.RetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BrandTxt As TextBox
    Friend WithEvents BarCodeTxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BalanceGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ItemsShow As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DeleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NextBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents NetAmountTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents InvLbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents InvSaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AmountTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DiscountTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Unit_PriceTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents QutTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DesTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RetailDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CNameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents BillTypeCombo As ComboBox
    Friend WithEvents Label11 As Label
End Class
