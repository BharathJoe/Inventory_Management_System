<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stocksales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stocksales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.Button()
        Me.icode = New System.Windows.Forms.TextBox()
        Me.iname = New System.Windows.Forms.TextBox()
        Me.description = New System.Windows.Forms.TextBox()
        Me.price = New System.Windows.Forms.TextBox()
        Me.stocks = New System.Windows.Forms.TextBox()
        Me.dattime = New System.Windows.Forms.DateTimePicker()
        Me.category = New System.Windows.Forms.ComboBox()
        Me.stockView = New System.Windows.Forms.DataGridView()
        Me.sitem = New System.Windows.Forms.TextBox()
        Me.categoryBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        CType(Me.stockView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 404)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 473)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 537)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Price"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(130, 621)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 26)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stocks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 692)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date Placed"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1175, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Search by Category"
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(526, 464)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(118, 44)
        Me.delete.TabIndex = 8
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(526, 575)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(118, 39)
        Me.insert.TabIndex = 9
        Me.insert.Text = "Export"
        Me.insert.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.Location = New System.Drawing.Point(526, 353)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(118, 43)
        Me.updatebtn.TabIndex = 10
        Me.updatebtn.Text = "Edit Item"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshbtn.Location = New System.Drawing.Point(526, 676)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(118, 42)
        Me.refreshbtn.TabIndex = 11
        Me.refreshbtn.Text = "Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(699, 220)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(93, 35)
        Me.search.TabIndex = 12
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'icode
        '
        Me.icode.Location = New System.Drawing.Point(281, 306)
        Me.icode.Name = "icode"
        Me.icode.Size = New System.Drawing.Size(213, 26)
        Me.icode.TabIndex = 13
        '
        'iname
        '
        Me.iname.Location = New System.Drawing.Point(281, 353)
        Me.iname.Name = "iname"
        Me.iname.Size = New System.Drawing.Size(213, 26)
        Me.iname.TabIndex = 14
        '
        'description
        '
        Me.description.Location = New System.Drawing.Point(281, 404)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(213, 26)
        Me.description.TabIndex = 15
        '
        'price
        '
        Me.price.Location = New System.Drawing.Point(281, 537)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(213, 26)
        Me.price.TabIndex = 16
        '
        'stocks
        '
        Me.stocks.Location = New System.Drawing.Point(281, 621)
        Me.stocks.Name = "stocks"
        Me.stocks.Size = New System.Drawing.Size(213, 26)
        Me.stocks.TabIndex = 17
        '
        'dattime
        '
        Me.dattime.Location = New System.Drawing.Point(281, 692)
        Me.dattime.Name = "dattime"
        Me.dattime.Size = New System.Drawing.Size(224, 26)
        Me.dattime.TabIndex = 18
        '
        'category
        '
        Me.category.FormattingEnabled = True
        Me.category.Items.AddRange(New Object() {"butter", "cookies", "cakes", "pulses", "grains", "pastries", "toppings", "others"})
        Me.category.Location = New System.Drawing.Point(281, 471)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(213, 28)
        Me.category.TabIndex = 19
        '
        'stockView
        '
        Me.stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stockView.Location = New System.Drawing.Point(699, 261)
        Me.stockView.Name = "stockView"
        Me.stockView.RowTemplate.Height = 28
        Me.stockView.Size = New System.Drawing.Size(993, 465)
        Me.stockView.TabIndex = 20
        '
        'sitem
        '
        Me.sitem.Location = New System.Drawing.Point(798, 226)
        Me.sitem.Name = "sitem"
        Me.sitem.Size = New System.Drawing.Size(136, 26)
        Me.sitem.TabIndex = 21
        '
        'categoryBox
        '
        Me.categoryBox.FormattingEnabled = True
        Me.categoryBox.Items.AddRange(New Object() {"butter", "cookies", "cakes", "pulses", "grains", "pastries", "toppings", "others"})
        Me.categoryBox.Location = New System.Drawing.Point(1329, 227)
        Me.categoryBox.Name = "categoryBox"
        Me.categoryBox.Size = New System.Drawing.Size(187, 28)
        Me.categoryBox.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(607, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(310, 37)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Bakery Stock Details"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(958, 159)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(74, 20)
        Me.status.TabIndex = 24
        Me.status.Text = "message"
        Me.status.Visible = False
        '
        'stocksales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1824, 727)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.categoryBox)
        Me.Controls.Add(Me.sitem)
        Me.Controls.Add(Me.stockView)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.dattime)
        Me.Controls.Add(Me.stocks)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.iname)
        Me.Controls.Add(Me.icode)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "stocksales"
        Me.Text = "Stock Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.stockView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents delete As Button
    Friend WithEvents insert As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents search As Button
    Friend WithEvents icode As TextBox
    Friend WithEvents iname As TextBox
    Friend WithEvents description As TextBox
    Friend WithEvents price As TextBox
    Friend WithEvents stocks As TextBox
    Friend WithEvents dattime As DateTimePicker
    Friend WithEvents category As ComboBox
    Friend WithEvents stockView As DataGridView
    Friend WithEvents sitem As TextBox
    Friend WithEvents categoryBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents status As Label
End Class
