<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockupdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stockupdate))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TyreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TyReDataSet = New TyRe.TyReDataSet()
        Me.TyreTableAdapter = New TyRe.TyReDataSetTableAdapters.tyreTableAdapter()
        Me.TableAdapterManager = New TyRe.TyReDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.List_priceLabel1 = New System.Windows.Forms.Label()
        Me.Tyre_nameLabel2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.QuntityLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox6 = New System.Windows.Forms.ListBox()
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.ListBox10 = New System.Windows.Forms.ListBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.TyreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TyReDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 42)
        Me.Panel1.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Algerian", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Location = New System.Drawing.Point(3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 35)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "CPM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.TyRe.My.Resources.Resources.pricing_blank_fluorescent_red_dayglo_stickers_and_labels
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(716, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(35, 35)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.TyRe.My.Resources.Resources.raemi_Cross_Out
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(758, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 35)
        Me.Button1.TabIndex = 7
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.List_priceLabel1)
        Me.Panel2.Controls.Add(Me.Tyre_nameLabel2)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.ListBox5)
        Me.Panel2.Controls.Add(Me.ListBox4)
        Me.Panel2.Controls.Add(Me.ListBox3)
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.QuntityLabel1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 407)
        Me.Panel2.TabIndex = 80
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(619, 246)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 50)
        Me.Button3.TabIndex = 101
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'List_priceLabel1
        '
        Me.List_priceLabel1.BackColor = System.Drawing.Color.White
        Me.List_priceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "list price", True))
        Me.List_priceLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_priceLabel1.Location = New System.Drawing.Point(616, 52)
        Me.List_priceLabel1.Name = "List_priceLabel1"
        Me.List_priceLabel1.Size = New System.Drawing.Size(126, 26)
        Me.List_priceLabel1.TabIndex = 98
        Me.List_priceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tyre_nameLabel2
        '
        Me.Tyre_nameLabel2.BackColor = System.Drawing.Color.White
        Me.Tyre_nameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "tyre name", True))
        Me.Tyre_nameLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tyre_nameLabel2.Location = New System.Drawing.Point(245, 52)
        Me.Tyre_nameLabel2.Name = "Tyre_nameLabel2"
        Me.Tyre_nameLabel2.Size = New System.Drawing.Size(175, 27)
        Me.Tyre_nameLabel2.TabIndex = 97
        Me.Tyre_nameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(619, 177)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 50)
        Me.Button4.TabIndex = 96
        Me.Button4.Text = "add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AllowDrop = True
        Me.ComboBox1.DataSource = Me.TyreBindingSource
        Me.ComboBox1.DisplayMember = "tyre code"
        Me.ComboBox1.DropDownHeight = 150
        Me.ComboBox1.DropDownWidth = 50
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(55, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 95
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(616, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 18)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "list price"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(468, 52)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(83, 26)
        Me.TextBox4.TabIndex = 93
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(468, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(245, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "tyre name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(55, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "tyre code"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(407, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 21)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "list price"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(493, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 21)
        Me.Label17.TabIndex = 88
        Me.Label17.Text = "sub total"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(327, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 21)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "quantity"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(143, 112)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 21)
        Me.Label19.TabIndex = 86
        Me.Label19.Text = "tyre name"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(35, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 21)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "tyre code"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox5
        '
        Me.ListBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 19
        Me.ListBox5.Location = New System.Drawing.Point(492, 133)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(102, 251)
        Me.ListBox5.TabIndex = 84
        '
        'ListBox4
        '
        Me.ListBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 19
        Me.ListBox4.Location = New System.Drawing.Point(408, 133)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(85, 251)
        Me.ListBox4.TabIndex = 83
        '
        'ListBox3
        '
        Me.ListBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 19
        Me.ListBox3.Location = New System.Drawing.Point(326, 133)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(83, 251)
        Me.ListBox3.TabIndex = 82
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 19
        Me.ListBox2.Location = New System.Drawing.Point(143, 133)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(184, 251)
        Me.ListBox2.TabIndex = 81
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(35, 133)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(109, 251)
        Me.ListBox1.TabIndex = 80
        '
        'QuntityLabel1
        '
        Me.QuntityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TyreBindingSource, "quntity", True))
        Me.QuntityLabel1.Location = New System.Drawing.Point(671, 190)
        Me.QuntityLabel1.Name = "QuntityLabel1"
        Me.QuntityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.QuntityLabel1.TabIndex = 100
        Me.QuntityLabel1.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(708, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Label1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.ListBox6)
        Me.Panel3.Controls.Add(Me.ListBox7)
        Me.Panel3.Controls.Add(Me.ListBox8)
        Me.Panel3.Controls.Add(Me.ListBox9)
        Me.Panel3.Controls.Add(Me.ListBox10)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 409)
        Me.Panel3.TabIndex = 102
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(619, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 50)
        Me.Button5.TabIndex = 102
        Me.Button5.Text = "Print"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(409, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "list price"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(495, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "sub total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(327, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(143, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 21)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "tyre name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(35, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 21)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "tyre code"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListBox6
        '
        Me.ListBox6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 19
        Me.ListBox6.Location = New System.Drawing.Point(494, 112)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(100, 251)
        Me.ListBox6.TabIndex = 94
        '
        'ListBox7
        '
        Me.ListBox7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 19
        Me.ListBox7.Location = New System.Drawing.Point(410, 112)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(85, 251)
        Me.ListBox7.TabIndex = 93
        '
        'ListBox8
        '
        Me.ListBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 19
        Me.ListBox8.Location = New System.Drawing.Point(326, 112)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(85, 251)
        Me.ListBox8.TabIndex = 92
        '
        'ListBox9
        '
        Me.ListBox9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 19
        Me.ListBox9.Location = New System.Drawing.Point(143, 112)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(184, 251)
        Me.ListBox9.TabIndex = 91
        '
        'ListBox10
        '
        Me.ListBox10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox10.FormattingEnabled = True
        Me.ListBox10.ItemHeight = 19
        Me.ListBox10.Location = New System.Drawing.Point(35, 112)
        Me.ListBox10.Name = "ListBox10"
        Me.ListBox10.Size = New System.Drawing.Size(109, 251)
        Me.ListBox10.TabIndex = 90
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'stockupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TyRe.My.Resources.Resources.Tire_tread
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stockupdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "stockupdate"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TyreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TyReDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TyReDataSet As TyRe.TyReDataSet
    Friend WithEvents TyreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TyreTableAdapter As TyRe.TyReDataSetTableAdapters.tyreTableAdapter
    Friend WithEvents TableAdapterManager As TyRe.TyReDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents QuntityLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents List_priceLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tyre_nameLabel2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox7 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox8 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox9 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox10 As System.Windows.Forms.ListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
