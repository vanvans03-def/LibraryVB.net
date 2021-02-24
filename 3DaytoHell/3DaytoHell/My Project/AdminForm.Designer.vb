<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FillByAdminToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AtelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminDataSet = New _3DaytoHell.AdminDataSet()
        Me.AdminTableAdapter = New _3DaytoHell.AdminDataSetTableAdapters.AdminTableAdapter()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ข้อมูลเจ้าหน้าที่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัสเจ้าหน้าที่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "รหัสผ่าน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ชื่อ สกุล"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ที่อยู่"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "เบอร์โทร"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "ID", True))
        Me.TextBox1.Location = New System.Drawing.Point(159, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 6
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "Admin"
        Me.AdminBindingSource.DataSource = Me.AdminDataSetBindingSource
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Apass", True))
        Me.TextBox2.Location = New System.Drawing.Point(159, 155)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Aname", True))
        Me.TextBox3.Location = New System.Drawing.Point(159, 199)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 22)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Aaddress", True))
        Me.TextBox4.Location = New System.Drawing.Point(159, 253)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 22)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "Atel", True))
        Me.TextBox5.Location = New System.Drawing.Point(159, 296)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 22)
        Me.TextBox5.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "เพิ่ม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(171, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "บันทึก"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(289, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "ลบ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(392, 368)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "ล้าง"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(315, 110)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "ค้นหา"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ApassDataGridViewTextBoxColumn, Me.AnameDataGridViewTextBoxColumn, Me.AaddressDataGridViewTextBoxColumn, Me.AtelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AdminBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(424, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(670, 278)
        Me.DataGridView1.TabIndex = 16
        '
        'FillByAdminToolStrip
        '
        Me.FillByAdminToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByAdminToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByAdminToolStrip.Name = "FillByAdminToolStrip"
        Me.FillByAdminToolStrip.Size = New System.Drawing.Size(1114, 25)
        Me.FillByAdminToolStrip.TabIndex = 17
        Me.FillByAdminToolStrip.Text = "FillByAdminToolStrip"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'ApassDataGridViewTextBoxColumn
        '
        Me.ApassDataGridViewTextBoxColumn.DataPropertyName = "Apass"
        Me.ApassDataGridViewTextBoxColumn.HeaderText = "Apass"
        Me.ApassDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ApassDataGridViewTextBoxColumn.Name = "ApassDataGridViewTextBoxColumn"
        Me.ApassDataGridViewTextBoxColumn.Width = 125
        '
        'AnameDataGridViewTextBoxColumn
        '
        Me.AnameDataGridViewTextBoxColumn.DataPropertyName = "Aname"
        Me.AnameDataGridViewTextBoxColumn.HeaderText = "Aname"
        Me.AnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AnameDataGridViewTextBoxColumn.Name = "AnameDataGridViewTextBoxColumn"
        Me.AnameDataGridViewTextBoxColumn.Width = 125
        '
        'AaddressDataGridViewTextBoxColumn
        '
        Me.AaddressDataGridViewTextBoxColumn.DataPropertyName = "Aaddress"
        Me.AaddressDataGridViewTextBoxColumn.HeaderText = "Aaddress"
        Me.AaddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AaddressDataGridViewTextBoxColumn.Name = "AaddressDataGridViewTextBoxColumn"
        Me.AaddressDataGridViewTextBoxColumn.Width = 125
        '
        'AtelDataGridViewTextBoxColumn
        '
        Me.AtelDataGridViewTextBoxColumn.DataPropertyName = "Atel"
        Me.AtelDataGridViewTextBoxColumn.HeaderText = "Atel"
        Me.AtelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AtelDataGridViewTextBoxColumn.Name = "AtelDataGridViewTextBoxColumn"
        Me.AtelDataGridViewTextBoxColumn.Width = 125
        '
        'AdminDataSetBindingSource
        '
        Me.AdminDataSetBindingSource.DataSource = Me.AdminDataSet
        Me.AdminDataSetBindingSource.Position = 0
        '
        'AdminDataSet
        '
        Me.AdminDataSet.DataSetName = "AdminDataSet"
        Me.AdminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 482)
        Me.Controls.Add(Me.FillByAdminToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AdminDataSetBindingSource As BindingSource
    Friend WithEvents AdminDataSet As AdminDataSet
    Friend WithEvents AdminBindingSource As BindingSource
    Friend WithEvents AdminTableAdapter As AdminDataSetTableAdapters.AdminTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AtelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillByAdminToolStrip As ToolStrip
End Class
