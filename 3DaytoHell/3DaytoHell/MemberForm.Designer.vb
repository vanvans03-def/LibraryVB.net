<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberDataSet = New _3DaytoHell.MemberDataSet()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MpassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MgroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MtelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MlevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillBySIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MemberTableAdapter = New _3DaytoHell.MemberDataSetTableAdapters.MemberTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 459)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลสมาชิก"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(251, 394)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 36)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "ล้างข้อความ"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(143, 394)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 28)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "ลบ"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(19, 394)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(83, 28)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "เพิ่ม"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "ค้นหา"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Mlevel", True))
        Me.TextBox7.Location = New System.Drawing.Point(105, 275)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 22)
        Me.TextBox7.TabIndex = 13
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.MemberDataSet
        '
        'MemberDataSet
        '
        Me.MemberDataSet.DataSetName = "MemberDataSet"
        Me.MemberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Mtel", True))
        Me.TextBox6.Location = New System.Drawing.Point(105, 239)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 22)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Maddress", True))
        Me.TextBox5.Location = New System.Drawing.Point(105, 206)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(194, 22)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Mgroup", True))
        Me.TextBox4.Location = New System.Drawing.Point(105, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(113, 22)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Mname", True))
        Me.TextBox3.Location = New System.Drawing.Point(105, 126)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Mpass", True))
        Me.TextBox2.Location = New System.Drawing.Point(105, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "ID", True))
        Me.TextBox1.Location = New System.Drawing.Point(105, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pass"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 537)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "บันทึก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MpassDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.MgroupDataGridViewTextBoxColumn, Me.MaddressDataGridViewTextBoxColumn, Me.MtelDataGridViewTextBoxColumn, Me.MlevelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MemberBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(565, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(795, 386)
        Me.DataGridView1.TabIndex = 19
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'MpassDataGridViewTextBoxColumn
        '
        Me.MpassDataGridViewTextBoxColumn.DataPropertyName = "Mpass"
        Me.MpassDataGridViewTextBoxColumn.HeaderText = "Mpass"
        Me.MpassDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MpassDataGridViewTextBoxColumn.Name = "MpassDataGridViewTextBoxColumn"
        Me.MpassDataGridViewTextBoxColumn.Width = 125
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "Mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Mname"
        Me.MnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        Me.MnameDataGridViewTextBoxColumn.Width = 125
        '
        'MgroupDataGridViewTextBoxColumn
        '
        Me.MgroupDataGridViewTextBoxColumn.DataPropertyName = "Mgroup"
        Me.MgroupDataGridViewTextBoxColumn.HeaderText = "Mgroup"
        Me.MgroupDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MgroupDataGridViewTextBoxColumn.Name = "MgroupDataGridViewTextBoxColumn"
        Me.MgroupDataGridViewTextBoxColumn.Width = 125
        '
        'MaddressDataGridViewTextBoxColumn
        '
        Me.MaddressDataGridViewTextBoxColumn.DataPropertyName = "Maddress"
        Me.MaddressDataGridViewTextBoxColumn.HeaderText = "Maddress"
        Me.MaddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaddressDataGridViewTextBoxColumn.Name = "MaddressDataGridViewTextBoxColumn"
        Me.MaddressDataGridViewTextBoxColumn.Width = 125
        '
        'MtelDataGridViewTextBoxColumn
        '
        Me.MtelDataGridViewTextBoxColumn.DataPropertyName = "Mtel"
        Me.MtelDataGridViewTextBoxColumn.HeaderText = "Mtel"
        Me.MtelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MtelDataGridViewTextBoxColumn.Name = "MtelDataGridViewTextBoxColumn"
        Me.MtelDataGridViewTextBoxColumn.Width = 125
        '
        'MlevelDataGridViewTextBoxColumn
        '
        Me.MlevelDataGridViewTextBoxColumn.DataPropertyName = "Mlevel"
        Me.MlevelDataGridViewTextBoxColumn.HeaderText = "Mlevel"
        Me.MlevelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MlevelDataGridViewTextBoxColumn.Name = "MlevelDataGridViewTextBoxColumn"
        Me.MlevelDataGridViewTextBoxColumn.Width = 125
        '
        'FillBySIDToolStrip
        '
        Me.FillBySIDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillBySIDToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBySIDToolStrip.Name = "FillBySIDToolStrip"
        Me.FillBySIDToolStrip.Size = New System.Drawing.Size(1391, 25)
        Me.FillBySIDToolStrip.TabIndex = 20
        Me.FillBySIDToolStrip.Text = "FillBySIDToolStrip"
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1256, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 31)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "กลับไปหน้าเมนู"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 708)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.FillBySIDToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MemberDataSet As MemberDataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As MemberDataSetTableAdapters.MemberTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MpassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MgroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MtelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MlevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button6 As Button
    Friend WithEvents FillBySIDToolStrip As ToolStrip
    Friend WithEvents Button3 As Button
End Class
