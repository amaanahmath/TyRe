<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TyreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TyReDataSet = New TyRe.TyReDataSet()
        Me.TyreTableAdapter = New TyRe.TyReDataSetTableAdapters.tyreTableAdapter()
        Me.TableAdapterManager = New TyRe.TyReDataSetTableAdapters.TableAdapterManager()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.List_priceLabel1 = New System.Windows.Forms.Label()
        Me.Tyre_nameLabel1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BillingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TyReDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TyReDataSet1 = New TyRe.TyReDataSet1()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tyre_codeLabel1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Selling_priceLabel1 = New System.Windows.Forms.Label()
        Me.QuntityLabel1 = New System.Windows.Forms.Label()
        Me.CostLabel1 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BillingTableAdapter = New TyRe.TyReDataSet1TableAdapters.BillingTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Spricelabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BillNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoustermerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.TyreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TyReDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TyReDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TyReDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 42)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TyRe.My.Resources.Resources.pricing_blank_fluorescent_red_dayglo_stickers_and_labels
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(1121, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 30)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.TyRe.My.Resources.Resources.raemi_Cross_Out
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(1158, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TyreBindingSource
        '
        Me.TyreBindingSource.DataMember = "tyre"
        Me.TyreBindingSource.DataSource = Me.TyReDataSet
        '
        'TyReDataSet
        '
        Me.TyReDataSet.DataSetName = "TyReDataSet"
        Me.TyReDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TyreTableAdapter
        '
        Me.TyreTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tyreTableAdapter = Me.TyreTableAdapter
        Me.TableAdapterManager.UpdateOrder = TyRe.TyReDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(927, 566)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 18)
        Me.Label21.TabIndex = 97
        Me.Label21.Text = "total"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1026, 562)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(162, 26)
        Me.TextBox7.TabIndex = 96
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(927, 534)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "discount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(927, 502)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 18)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "sub total"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1026, 530)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(162, 26)
        Me.TextBox6.TabIndex = 87
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(728, 541)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 47)
        Me.Button3.TabIndex = 81
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1026, 498)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(162, 26)
        Me.TextBox5.TabIndex = 80
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1020, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 47)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "Add List"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'List_priceLabel1
        '
        Me.List_priceLabel1.BackColor = System.Drawing.Color.White
        Me.List_priceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "list price", True))
        Me.List_priceLabel1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_priceLabel1.ForeColor = System.Drawing.Color.Black
        Me.List_priceLabel1.Location = New System.Drawing.Point(446, 169)
        Me.List_priceLabel1.Name = "List_priceLabel1"
        Me.List_priceLabel1.Size = New System.Drawing.Size(115, 25)
        Me.List_priceLabel1.TabIndex = 72
        Me.List_priceLabel1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.List_priceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tyre_nameLabel1
        '
        Me.Tyre_nameLabel1.BackColor = System.Drawing.Color.White
        Me.Tyre_nameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "tyre name", True))
        Me.Tyre_nameLabel1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tyre_nameLabel1.ForeColor = System.Drawing.Color.Black
        Me.Tyre_nameLabel1.Location = New System.Drawing.Point(175, 169)
        Me.Tyre_nameLabel1.Name = "Tyre_nameLabel1"
        Me.Tyre_nameLabel1.Size = New System.Drawing.Size(125, 25)
        Me.Tyre_nameLabel1.TabIndex = 71
        Me.Tyre_nameLabel1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Tyre_nameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.DataSource = Me.TyreBindingSource
        Me.ComboBox1.DisplayMember = "tyre code"
        Me.ComboBox1.DropDownHeight = 150
        Me.ComboBox1.DropDownWidth = 50
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(15, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 69
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(446, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 19)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "List Price"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingBindingSource, "Final Price", True))
        Me.TextBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1036, 175)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(142, 26)
        Me.TextBox8.TabIndex = 67
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingBindingSource, "Quantity", True))
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(335, 169)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(83, 27)
        Me.TextBox4.TabIndex = 65
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BillingBindingSource
        '
        Me.BillingBindingSource.DataMember = "Billing"
        Me.BillingBindingSource.DataSource = Me.TyReDataSet1BindingSource
        '
        'TyReDataSet1BindingSource
        '
        Me.TyReDataSet1BindingSource.DataSource = Me.TyReDataSet1
        Me.TyReDataSet1BindingSource.Position = 0
        '
        'TyReDataSet1
        '
        Me.TyReDataSet1.DataSetName = "TyReDataSet1"
        Me.TyReDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(612, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 19)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Selling Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(335, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(175, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Tyre Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 19)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Tyre Code"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BillingBindingSource, "Date", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(353, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(273, 27)
        Me.DateTimePicker1.TabIndex = 60
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingBindingSource, "BillNo", True))
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Red
        Me.TextBox3.Location = New System.Drawing.Point(114, 56)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 27)
        Me.TextBox3.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(298, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 19)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Bill NO"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingBindingSource, "Coustermer name", True))
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(114, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 27)
        Me.TextBox2.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Name"
        '
        'Tyre_codeLabel1
        '
        Me.Tyre_codeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "tyre code", True))
        Me.Tyre_codeLabel1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tyre_codeLabel1.ForeColor = System.Drawing.Color.Black
        Me.Tyre_codeLabel1.Location = New System.Drawing.Point(21, 169)
        Me.Tyre_codeLabel1.Name = "Tyre_codeLabel1"
        Me.Tyre_codeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Tyre_codeLabel1.TabIndex = 70
        Me.Tyre_codeLabel1.Text = "Label11"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1042, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "quntity", True))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1033, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 26)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Label12"
        '
        'Selling_priceLabel1
        '
        Me.Selling_priceLabel1.BackColor = System.Drawing.Color.White
        Me.Selling_priceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "selling price", True))
        Me.Selling_priceLabel1.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Selling_priceLabel1.ForeColor = System.Drawing.Color.Black
        Me.Selling_priceLabel1.Location = New System.Drawing.Point(612, 169)
        Me.Selling_priceLabel1.Name = "Selling_priceLabel1"
        Me.Selling_priceLabel1.Size = New System.Drawing.Size(110, 25)
        Me.Selling_priceLabel1.TabIndex = 73
        Me.Selling_priceLabel1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Selling_priceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QuntityLabel1
        '
        Me.QuntityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "quntity", True))
        Me.QuntityLabel1.ForeColor = System.Drawing.Color.Black
        Me.QuntityLabel1.Location = New System.Drawing.Point(1042, 175)
        Me.QuntityLabel1.Name = "QuntityLabel1"
        Me.QuntityLabel1.Size = New System.Drawing.Size(106, 20)
        Me.QuntityLabel1.TabIndex = 85
        Me.QuntityLabel1.Text = "Label12"
        '
        'CostLabel1
        '
        Me.CostLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "cost", True))
        Me.CostLabel1.ForeColor = System.Drawing.Color.Black
        Me.CostLabel1.Location = New System.Drawing.Point(1060, 175)
        Me.CostLabel1.Name = "CostLabel1"
        Me.CostLabel1.Size = New System.Drawing.Size(106, 20)
        Me.CostLabel1.TabIndex = 84
        Me.CostLabel1.Text = "Label12"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(749, 170)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(125, 27)
        Me.TextBox9.TabIndex = 99
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(746, 142)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 19)
        Me.Label22.TabIndex = 98
        Me.Label22.Text = "Discount %"
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Black
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.BillNoDataGridViewTextBoxColumn, Me.CoustermerNameDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.ListPriceDataGridViewTextBoxColumn, Me.SellingPriceDataGridViewTextBoxColumn, Me.FinalPriceDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.BillingBindingSource
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.BunifuCustomDataGrid1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(12, 243)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.RowHeadersVisible = False
        Me.BunifuCustomDataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCustomDataGrid1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1176, 249)
        Me.BunifuCustomDataGrid1.TabIndex = 100
        '
        'BillingTableAdapter
        '
        Me.BillingTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingBindingSource, "List Price", True))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(494, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Label2"
        '
        'Spricelabel
        '
        Me.Spricelabel.AutoSize = True
        Me.Spricelabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BillingBindingSource, "Selling Price", True))
        Me.Spricelabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Spricelabel.Location = New System.Drawing.Point(627, 178)
        Me.Spricelabel.Name = "Spricelabel"
        Me.Spricelabel.Size = New System.Drawing.Size(60, 19)
        Me.Spricelabel.TabIndex = 102
        Me.Spricelabel.Text = "Label9"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Algerian", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 35)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "CPM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'BillNoDataGridViewTextBoxColumn
        '
        Me.BillNoDataGridViewTextBoxColumn.DataPropertyName = "BillNo"
        Me.BillNoDataGridViewTextBoxColumn.HeaderText = "BillNo"
        Me.BillNoDataGridViewTextBoxColumn.Name = "BillNoDataGridViewTextBoxColumn"
        '
        'CoustermerNameDataGridViewTextBoxColumn
        '
        Me.CoustermerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CoustermerNameDataGridViewTextBoxColumn.DataPropertyName = "Coustermer name"
        Me.CoustermerNameDataGridViewTextBoxColumn.HeaderText = "Coustermer name"
        Me.CoustermerNameDataGridViewTextBoxColumn.Name = "CoustermerNameDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'ListPriceDataGridViewTextBoxColumn
        '
        Me.ListPriceDataGridViewTextBoxColumn.DataPropertyName = "List Price"
        Me.ListPriceDataGridViewTextBoxColumn.HeaderText = "List Price"
        Me.ListPriceDataGridViewTextBoxColumn.Name = "ListPriceDataGridViewTextBoxColumn"
        '
        'SellingPriceDataGridViewTextBoxColumn
        '
        Me.SellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling Price"
        Me.SellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price"
        Me.SellingPriceDataGridViewTextBoxColumn.Name = "SellingPriceDataGridViewTextBoxColumn"
        '
        'FinalPriceDataGridViewTextBoxColumn
        '
        Me.FinalPriceDataGridViewTextBoxColumn.DataPropertyName = "Final Price"
        Me.FinalPriceDataGridViewTextBoxColumn.HeaderText = "Final Price"
        Me.FinalPriceDataGridViewTextBoxColumn.Name = "FinalPriceDataGridViewTextBoxColumn"
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.Visible = False
        '
        'billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TyRe.My.Resources.Resources._9001_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.List_priceLabel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Tyre_codeLabel1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Tyre_nameLabel1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Selling_priceLabel1)
        Me.Controls.Add(Me.QuntityLabel1)
        Me.Controls.Add(Me.CostLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Spricelabel)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "=---------=11"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TyreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TyReDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TyReDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TyReDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TyReDataSet As TyRe.TyReDataSet
    Friend WithEvents TyreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TyreTableAdapter As TyRe.TyReDataSetTableAdapters.tyreTableAdapter
    Friend WithEvents TableAdapterManager As TyRe.TyReDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents List_priceLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tyre_nameLabel1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tyre_codeLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Selling_priceLabel1 As System.Windows.Forms.Label
    Friend WithEvents QuntityLabel1 As System.Windows.Forms.Label
    Friend WithEvents CostLabel1 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TyReDataSet1 As TyRe.TyReDataSet1
    Friend WithEvents TyReDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BillingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillingTableAdapter As TyRe.TyReDataSet1TableAdapters.BillingTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Spricelabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoustermerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellingPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinalPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
