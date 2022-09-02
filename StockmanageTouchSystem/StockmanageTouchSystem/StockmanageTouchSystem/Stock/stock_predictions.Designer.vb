<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock_predictions
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
        Dim Label10 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Stock_predicitc_Grid_View = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.endDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Calculate_Btn = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProfitLbl = New System.Windows.Forms.Label()
        Me.PriceLbl = New System.Windows.Forms.Label()
        Me.CostLbl = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Label10 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.Stock_predicitc_Grid_View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label10.ForeColor = System.Drawing.Color.White
        Label10.Location = New System.Drawing.Point(6, 14)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(121, 24)
        Label10.TabIndex = 376
        Label10.Text = "SelectPrinter:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label7.ForeColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(172, 85)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(102, 24)
        Label7.TabIndex = 387
        Label7.Text = "Total Profit:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label5.ForeColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(172, 15)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(104, 24)
        Label5.TabIndex = 385
        Label5.Text = "Total Price:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Label4.ForeColor = System.Drawing.Color.White
        Label4.Location = New System.Drawing.Point(172, 50)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(98, 24)
        Label4.TabIndex = 383
        Label4.Text = "Total Cost:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 24)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Stock Predictions"
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
        Me.Guna2Panel4.TabIndex = 375
        '
        'Stock_predicitc_Grid_View
        '
        Me.Stock_predicitc_Grid_View.AllowUserToAddRows = False
        Me.Stock_predicitc_Grid_View.AllowUserToDeleteRows = False
        Me.Stock_predicitc_Grid_View.AllowUserToResizeColumns = False
        Me.Stock_predicitc_Grid_View.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Stock_predicitc_Grid_View.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Stock_predicitc_Grid_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Stock_predicitc_Grid_View.BackgroundColor = System.Drawing.Color.White
        Me.Stock_predicitc_Grid_View.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Stock_predicitc_Grid_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Stock_predicitc_Grid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Stock_predicitc_Grid_View.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Stock_predicitc_Grid_View.ColumnHeadersHeight = 30
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Stock_predicitc_Grid_View.DefaultCellStyle = DataGridViewCellStyle3
        Me.Stock_predicitc_Grid_View.EnableHeadersVisualStyles = False
        Me.Stock_predicitc_Grid_View.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stock_predicitc_Grid_View.Location = New System.Drawing.Point(0, 43)
        Me.Stock_predicitc_Grid_View.Name = "Stock_predicitc_Grid_View"
        Me.Stock_predicitc_Grid_View.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Stock_predicitc_Grid_View.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Stock_predicitc_Grid_View.RowHeadersVisible = False
        Me.Stock_predicitc_Grid_View.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock_predicitc_Grid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Stock_predicitc_Grid_View.Size = New System.Drawing.Size(1350, 450)
        Me.Stock_predicitc_Grid_View.TabIndex = 376
        Me.Stock_predicitc_Grid_View.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Stock_predicitc_Grid_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Stock_predicitc_Grid_View.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Stock_predicitc_Grid_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Stock_predicitc_Grid_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Stock_predicitc_Grid_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Stock_predicitc_Grid_View.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Stock_predicitc_Grid_View.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stock_predicitc_Grid_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stock_predicitc_Grid_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Stock_predicitc_Grid_View.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Stock_predicitc_Grid_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Stock_predicitc_Grid_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Stock_predicitc_Grid_View.ThemeStyle.HeaderStyle.Height = 30
        Me.Stock_predicitc_Grid_View.ThemeStyle.ReadOnly = True
        Me.Stock_predicitc_Grid_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Stock_predicitc_Grid_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Stock_predicitc_Grid_View.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Stock_predicitc_Grid_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Stock_predicitc_Grid_View.ThemeStyle.RowsStyle.Height = 22
        Me.Stock_predicitc_Grid_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Stock_predicitc_Grid_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 378
        Me.Label1.Text = "Start Date:"
        '
        'StartDate
        '
        Me.StartDate.CustomFormat = "yyyy-MM-dd"
        Me.StartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDate.Location = New System.Drawing.Point(16, 39)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(1)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(206, 29)
        Me.StartDate.TabIndex = 377
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(220, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 380
        Me.Label2.Text = "End Date:"
        '
        'endDate
        '
        Me.endDate.CustomFormat = "yyyy-MM-dd"
        Me.endDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endDate.Location = New System.Drawing.Point(224, 39)
        Me.endDate.Margin = New System.Windows.Forms.Padding(1)
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(206, 29)
        Me.endDate.TabIndex = 379
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Calculate_Btn)
        Me.GroupBox1.Controls.Add(Me.endDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.StartDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 499)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 127)
        Me.GroupBox1.TabIndex = 381
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
        Me.Label3.TabIndex = 382
        Me.Label3.Text = "Generate Report :"
        '
        'Calculate_Btn
        '
        Me.Calculate_Btn.CheckedState.Parent = Me.Calculate_Btn
        Me.Calculate_Btn.CustomImages.Parent = Me.Calculate_Btn
        Me.Calculate_Btn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate_Btn.ForeColor = System.Drawing.Color.White
        Me.Calculate_Btn.HoverState.Parent = Me.Calculate_Btn
        Me.Calculate_Btn.Location = New System.Drawing.Point(224, 80)
        Me.Calculate_Btn.Name = "Calculate_Btn"
        Me.Calculate_Btn.ShadowDecoration.Parent = Me.Calculate_Btn
        Me.Calculate_Btn.Size = New System.Drawing.Size(206, 34)
        Me.Calculate_Btn.TabIndex = 381
        Me.Calculate_Btn.Text = "Generate"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(462, 499)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 127)
        Me.GroupBox2.TabIndex = 382
        Me.GroupBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(270, 28)
        Me.ComboBox1.TabIndex = 375
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(6, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(270, 34)
        Me.Button2.TabIndex = 374
        Me.Button2.Text = "Print Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProfitLbl
        '
        Me.ProfitLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProfitLbl.Location = New System.Drawing.Point(286, 84)
        Me.ProfitLbl.Name = "ProfitLbl"
        Me.ProfitLbl.Size = New System.Drawing.Size(294, 30)
        Me.ProfitLbl.TabIndex = 388
        Me.ProfitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceLbl
        '
        Me.PriceLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PriceLbl.Location = New System.Drawing.Point(286, 14)
        Me.PriceLbl.Name = "PriceLbl"
        Me.PriceLbl.Size = New System.Drawing.Size(294, 30)
        Me.PriceLbl.TabIndex = 386
        Me.PriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CostLbl
        '
        Me.CostLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CostLbl.Location = New System.Drawing.Point(286, 49)
        Me.CostLbl.Name = "CostLbl"
        Me.CostLbl.Size = New System.Drawing.Size(294, 30)
        Me.CostLbl.TabIndex = 384
        Me.CostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ProfitLbl)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Label7)
        Me.GroupBox3.Controls.Add(Me.CostLbl)
        Me.GroupBox3.Controls.Add(Me.PriceLbl)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(756, 499)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(586, 127)
        Me.GroupBox3.TabIndex = 389
        Me.GroupBox3.TabStop = False
        '
        'stock_predictions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1350, 638)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Stock_predicitc_Grid_View)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stock_predictions"
        Me.Text = "stock_predictions"
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        CType(Me.Stock_predicitc_Grid_View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Stock_predicitc_Grid_View As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents endDate As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Calculate_Btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ProfitLbl As Label
    Friend WithEvents PriceLbl As Label
    Friend WithEvents CostLbl As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
