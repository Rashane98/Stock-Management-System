<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfitCalculate
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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Prift_tblGrid_View = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.NextBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ProfitLbl = New System.Windows.Forms.Label()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.CostLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.CodeTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label7 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Prift_tblGrid_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(941, 600)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(102, 24)
        Label7.TabIndex = 367
        Label7.Text = "Total Profit:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(941, 561)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(104, 24)
        Label5.TabIndex = 365
        Label5.Text = "Total Price:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(941, 521)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(98, 24)
        Label3.TabIndex = 363
        Label3.Text = "Total Cost:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label10.ForeColor = System.Drawing.Color.White
        Label10.Location = New System.Drawing.Point(232, 526)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(121, 24)
        Label10.TabIndex = 373
        Label10.Text = "SelectPrinter:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Prift_tblGrid_View)
        Me.Panel1.Location = New System.Drawing.Point(3, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1347, 465)
        Me.Panel1.TabIndex = 0
        '
        'Prift_tblGrid_View
        '
        Me.Prift_tblGrid_View.AllowUserToAddRows = False
        Me.Prift_tblGrid_View.AllowUserToDeleteRows = False
        Me.Prift_tblGrid_View.AllowUserToResizeColumns = False
        Me.Prift_tblGrid_View.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.Prift_tblGrid_View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Prift_tblGrid_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Prift_tblGrid_View.BackgroundColor = System.Drawing.Color.White
        Me.Prift_tblGrid_View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Prift_tblGrid_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Prift_tblGrid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Prift_tblGrid_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Prift_tblGrid_View.ColumnHeadersHeight = 30
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Prift_tblGrid_View.DefaultCellStyle = DataGridViewCellStyle9
        Me.Prift_tblGrid_View.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Prift_tblGrid_View.EnableHeadersVisualStyles = False
        Me.Prift_tblGrid_View.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Prift_tblGrid_View.Location = New System.Drawing.Point(0, 0)
        Me.Prift_tblGrid_View.Name = "Prift_tblGrid_View"
        Me.Prift_tblGrid_View.ReadOnly = True
        Me.Prift_tblGrid_View.RowHeadersVisible = False
        Me.Prift_tblGrid_View.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prift_tblGrid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Prift_tblGrid_View.Size = New System.Drawing.Size(1347, 465)
        Me.Prift_tblGrid_View.TabIndex = 14
        Me.Prift_tblGrid_View.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Prift_tblGrid_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Prift_tblGrid_View.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Prift_tblGrid_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Prift_tblGrid_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Prift_tblGrid_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Prift_tblGrid_View.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Prift_tblGrid_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Prift_tblGrid_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Prift_tblGrid_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Prift_tblGrid_View.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Prift_tblGrid_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Prift_tblGrid_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Prift_tblGrid_View.ThemeStyle.HeaderStyle.Height = 30
        Me.Prift_tblGrid_View.ThemeStyle.ReadOnly = True
        Me.Prift_tblGrid_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Prift_tblGrid_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Prift_tblGrid_View.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Prift_tblGrid_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Prift_tblGrid_View.ThemeStyle.RowsStyle.Height = 22
        Me.Prift_tblGrid_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Prift_tblGrid_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'NextBtn
        '
        Me.NextBtn.CheckedState.Parent = Me.NextBtn
        Me.NextBtn.CustomImages.Parent = Me.NextBtn
        Me.NextBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.ForeColor = System.Drawing.Color.White
        Me.NextBtn.HoverState.Parent = Me.NextBtn
        Me.NextBtn.Location = New System.Drawing.Point(26, 594)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.ShadowDecoration.Parent = Me.NextBtn
        Me.NextBtn.Size = New System.Drawing.Size(148, 40)
        Me.NextBtn.TabIndex = 362
        Me.NextBtn.Text = "Filter"
        '
        'ProfitLbl
        '
        Me.ProfitLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProfitLbl.Location = New System.Drawing.Point(1049, 599)
        Me.ProfitLbl.Name = "ProfitLbl"
        Me.ProfitLbl.Size = New System.Drawing.Size(294, 30)
        Me.ProfitLbl.TabIndex = 368
        Me.ProfitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceLbl
        '
        Me.PriceLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PriceLbl.Location = New System.Drawing.Point(1049, 560)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(294, 30)
        Me.PriceLbl.TabIndex = 366
        Me.PriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CostLbl
        '
        Me.CostLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CostLbl.Location = New System.Drawing.Point(1049, 520)
        Me.CostLbl.Name = "CostLbl"
        Me.CostLbl.Size = New System.Drawing.Size(294, 30)
        Me.CostLbl.TabIndex = 364
        Me.CostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 526)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 370
        Me.Label1.Text = "Select Date:"
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "yyyy-MM-dd"
        Me.StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDate.Location = New System.Drawing.Point(26, 551)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(1)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(206, 29)
        Me.StartDate.TabIndex = 369
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(236, 551)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(306, 32)
        Me.ComboBox1.TabIndex = 372
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(180, 594)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 40)
        Me.Button2.TabIndex = 371
        Me.Button2.Text = "Print Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Daily Profit"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(1302, 5)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(41, 35)
        Me.Guna2Button1.TabIndex = 4
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
        Me.Guna2Panel4.Size = New System.Drawing.Size(1350, 43)
        Me.Guna2Panel4.TabIndex = 374
        '
        'CodeTxt
        '
        Me.CodeTxt.BackColor = System.Drawing.Color.Teal
        Me.CodeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeTxt.Location = New System.Drawing.Point(392, 594)
        Me.CodeTxt.Multiline = True
        Me.CodeTxt.Name = "CodeTxt"
        Me.CodeTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CodeTxt.Size = New System.Drawing.Size(94, 40)
        Me.CodeTxt.TabIndex = 375
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(492, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 40)
        Me.Button1.TabIndex = 376
        Me.Button1.Text = "CHK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProfitCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1350, 638)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CodeTxt)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.ProfitLbl)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.PriceLbl)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.CostLbl)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfitCalculate"
        Me.Text = "ProfitCalculate"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Prift_tblGrid_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Prift_tblGrid_View As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents NextBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ProfitLbl As Label
    Friend WithEvents PriceLbl As Label
    Friend WithEvents CostLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CodeTxt As TextBox
    Friend WithEvents Button1 As Button
End Class
