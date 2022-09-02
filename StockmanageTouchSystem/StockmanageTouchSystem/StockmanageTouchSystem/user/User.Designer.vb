<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.unameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Button7
        '
        Me.Guna2Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button7.CheckedState.Parent = Me.Guna2Button7
        Me.Guna2Button7.CustomBorderThickness = New System.Windows.Forms.Padding(1)
        Me.Guna2Button7.CustomImages.Image = Global.StockmanageTouchSystem.My.Resources.Resources.close
        Me.Guna2Button7.CustomImages.Parent = Me.Guna2Button7
        Me.Guna2Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.HoverState.Parent = Me.Guna2Button7
        Me.Guna2Button7.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Guna2Button7.Location = New System.Drawing.Point(373, 12)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.Padding = New System.Windows.Forms.Padding(1)
        Me.Guna2Button7.ShadowDecoration.Parent = Me.Guna2Button7
        Me.Guna2Button7.Size = New System.Drawing.Size(37, 25)
        Me.Guna2Button7.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(325, 478)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 42)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'passtxt
        '
        Me.passtxt.BackColor = System.Drawing.SystemColors.Info
        Me.passtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.Location = New System.Drawing.Point(115, 445)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxt.Size = New System.Drawing.Size(297, 27)
        Me.passtxt.TabIndex = 25
        '
        'unameTxt
        '
        Me.unameTxt.BackColor = System.Drawing.SystemColors.Info
        Me.unameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameTxt.Location = New System.Drawing.Point(115, 412)
        Me.unameTxt.Name = "unameTxt"
        Me.unameTxt.Size = New System.Drawing.Size(297, 27)
        Me.unameTxt.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(10, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(10, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "User Name:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(104, 478)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 42)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(241, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 42)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 42)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(409, 354)
        Me.DataGridView1.TabIndex = 18
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 534)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.unameTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2Button7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User"
        Me.Text = "User"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button4 As Button
    Friend WithEvents passtxt As TextBox
    Friend WithEvents unameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
