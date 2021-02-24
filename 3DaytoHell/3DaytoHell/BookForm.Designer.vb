<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MemberDataSet = New _3DaytoHell.MemberDataSet()
        Me.BookDataSet = New _3DaytoHell.BookDataSet()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter = New _3DaytoHell.BookDataSetTableAdapters.BookTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FillByBookToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BauthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BpimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookDataSet1 = New _3DaytoHell.BookDataSet1()
        Me.BookTableAdapter1 = New _3DaytoHell.BookDataSet1TableAdapters.BookTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ข้อมูลหนังสือ"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource1, "ID", True))
        Me.TextBox1.Location = New System.Drawing.Point(151, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสหนังสือ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ชื่อหนังสือ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "สำนักพิมพ์"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ราคา"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "จำนวนวันที่สามารถยืมได้"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource1, "Bname", True))
        Me.TextBox2.Location = New System.Drawing.Point(151, 133)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource1, "Bauthor", True))
        Me.TextBox3.Location = New System.Drawing.Point(151, 186)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(148, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource1, "Bpim", True))
        Me.TextBox4.Location = New System.Drawing.Point(151, 231)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(148, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource1, "Bprice", True))
        Me.TextBox5.Location = New System.Drawing.Point(151, 286)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(148, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ชื่อผู้แต่ง"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource1, "Sday", True))
        Me.TextBox6.Location = New System.Drawing.Point(151, 325)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(148, 22)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource1, "Tday", True))
        Me.TextBox7.Location = New System.Drawing.Point(151, 363)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(148, 22)
        Me.TextBox7.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "จำนวนวันที่สามารถยืมได้"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(323, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "สำหรับนักศึกษา"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(323, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "สำหรับเจ้าหน้าที่"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "เพิ่ม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(185, 489)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "บันทึก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(326, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "ลบ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(341, 76)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "ค้นหา"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(459, 489)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "ล้าง"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MemberDataSet
        '
        Me.MemberDataSet.DataSetName = "MemberDataSet"
        Me.MemberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookDataSet
        '
        Me.BookDataSet.DataSetName = "BookDataSet"
        Me.BookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.BookDataSet
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BnameDataGridViewTextBoxColumn, Me.BauthorDataGridViewTextBoxColumn, Me.BpimDataGridViewTextBoxColumn, Me.BpriceDataGridViewTextBoxColumn, Me.SdayDataGridViewTextBoxColumn, Me.TdayDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(474, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(753, 330)
        Me.DataGridView1.TabIndex = 22
        '
        'FillByBookToolStrip
        '
        Me.FillByBookToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByBookToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByBookToolStrip.Name = "FillByBookToolStrip"
        Me.FillByBookToolStrip.Size = New System.Drawing.Size(1262, 25)
        Me.FillByBookToolStrip.TabIndex = 23
        Me.FillByBookToolStrip.Text = "FillByBookToolStrip"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'BnameDataGridViewTextBoxColumn
        '
        Me.BnameDataGridViewTextBoxColumn.DataPropertyName = "Bname"
        Me.BnameDataGridViewTextBoxColumn.HeaderText = "Bname"
        Me.BnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BnameDataGridViewTextBoxColumn.Name = "BnameDataGridViewTextBoxColumn"
        Me.BnameDataGridViewTextBoxColumn.Width = 125
        '
        'BauthorDataGridViewTextBoxColumn
        '
        Me.BauthorDataGridViewTextBoxColumn.DataPropertyName = "Bauthor"
        Me.BauthorDataGridViewTextBoxColumn.HeaderText = "Bauthor"
        Me.BauthorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BauthorDataGridViewTextBoxColumn.Name = "BauthorDataGridViewTextBoxColumn"
        Me.BauthorDataGridViewTextBoxColumn.Width = 125
        '
        'BpimDataGridViewTextBoxColumn
        '
        Me.BpimDataGridViewTextBoxColumn.DataPropertyName = "Bpim"
        Me.BpimDataGridViewTextBoxColumn.HeaderText = "Bpim"
        Me.BpimDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BpimDataGridViewTextBoxColumn.Name = "BpimDataGridViewTextBoxColumn"
        Me.BpimDataGridViewTextBoxColumn.Width = 125
        '
        'BpriceDataGridViewTextBoxColumn
        '
        Me.BpriceDataGridViewTextBoxColumn.DataPropertyName = "Bprice"
        Me.BpriceDataGridViewTextBoxColumn.HeaderText = "Bprice"
        Me.BpriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BpriceDataGridViewTextBoxColumn.Name = "BpriceDataGridViewTextBoxColumn"
        Me.BpriceDataGridViewTextBoxColumn.Width = 125
        '
        'SdayDataGridViewTextBoxColumn
        '
        Me.SdayDataGridViewTextBoxColumn.DataPropertyName = "Sday"
        Me.SdayDataGridViewTextBoxColumn.HeaderText = "Sday"
        Me.SdayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SdayDataGridViewTextBoxColumn.Name = "SdayDataGridViewTextBoxColumn"
        Me.SdayDataGridViewTextBoxColumn.Width = 125
        '
        'TdayDataGridViewTextBoxColumn
        '
        Me.TdayDataGridViewTextBoxColumn.DataPropertyName = "Tday"
        Me.TdayDataGridViewTextBoxColumn.HeaderText = "Tday"
        Me.TdayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TdayDataGridViewTextBoxColumn.Name = "TdayDataGridViewTextBoxColumn"
        Me.TdayDataGridViewTextBoxColumn.Width = 125
        '
        'BookBindingSource1
        '
        Me.BookBindingSource1.DataMember = "Book"
        Me.BookBindingSource1.DataSource = Me.BookDataSet1
        '
        'BookDataSet1
        '
        Me.BookDataSet1.DataSetName = "BookDataSet1"
        Me.BookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookTableAdapter1
        '
        Me.BookTableAdapter1.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1084, 13)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(131, 29)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "กลับไปหน้าเมนู"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 586)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.FillByBookToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookForm"
        Me.Text = "BookForm"
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MemberDataSet As MemberDataSet
    Friend WithEvents BookDataSet As BookDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As BookDataSetTableAdapters.BookTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BookDataSet1 As BookDataSet1
    Friend WithEvents BookBindingSource1 As BindingSource
    Friend WithEvents BookTableAdapter1 As BookDataSet1TableAdapters.BookTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BauthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BpimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillByBookToolStrip As ToolStrip
    Friend WithEvents Button6 As Button
End Class
