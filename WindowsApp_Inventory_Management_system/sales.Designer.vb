<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sales))
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cusmobTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cusidTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.checkButton = New System.Windows.Forms.Button()
        Me.proGroupBox = New System.Windows.Forms.GroupBox()
        Me.cusGroupBox = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.result_lbl = New System.Windows.Forms.Label()
        Me.cusaddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cusnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.billGroupBox = New System.Windows.Forms.GroupBox()
        Me.printButton = New System.Windows.Forms.Button()
        Me.pay = New System.Windows.Forms.Button()
        Me.PrintDialogmjb = New System.Windows.Forms.PrintDialog()
        Me.PrintDocumentmjb = New System.Drawing.Printing.PrintDocument()
        Me.proGroupBox.SuspendLayout()
        Me.cusGroupBox.SuspendLayout()
        Me.billGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(251, 91)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(176, 35)
        Me.TextBox6.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 29)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Stocks"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(251, 40)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 35)
        Me.TextBox5.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 29)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Price"
        '
        'cusmobTextBox
        '
        Me.cusmobTextBox.Location = New System.Drawing.Point(251, 117)
        Me.cusmobTextBox.Name = "cusmobTextBox"
        Me.cusmobTextBox.Size = New System.Drawing.Size(176, 35)
        Me.cusmobTextBox.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 29)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Customer mobile"
        '
        'cusidTextBox
        '
        Me.cusidTextBox.Location = New System.Drawing.Point(251, 49)
        Me.cusidTextBox.Name = "cusidTextBox"
        Me.cusidTextBox.Size = New System.Drawing.Size(176, 35)
        Me.cusidTextBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(615, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 29)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Product Name"
        '
        'id_TextBox
        '
        Me.id_TextBox.Location = New System.Drawing.Point(251, 44)
        Me.id_TextBox.Name = "id_TextBox"
        Me.id_TextBox.ReadOnly = True
        Me.id_TextBox.Size = New System.Drawing.Size(176, 35)
        Me.id_TextBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Product ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"cake", "hersley", "jelly", "perk", "nutties"})
        Me.ComboBox1.Location = New System.Drawing.Point(251, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 37)
        Me.ComboBox1.TabIndex = 27
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(251, 149)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 35)
        Me.TextBox1.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 29)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Amount"
        '
        'checkButton
        '
        Me.checkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkButton.Location = New System.Drawing.Point(433, 112)
        Me.checkButton.Name = "checkButton"
        Me.checkButton.Size = New System.Drawing.Size(95, 40)
        Me.checkButton.TabIndex = 30
        Me.checkButton.Text = "Check"
        Me.checkButton.UseVisualStyleBackColor = True
        '
        'proGroupBox
        '
        Me.proGroupBox.Controls.Add(Me.Label1)
        Me.proGroupBox.Controls.Add(Me.id_TextBox)
        Me.proGroupBox.Controls.Add(Me.Label2)
        Me.proGroupBox.Controls.Add(Me.ComboBox1)
        Me.proGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proGroupBox.Location = New System.Drawing.Point(91, 354)
        Me.proGroupBox.Name = "proGroupBox"
        Me.proGroupBox.Size = New System.Drawing.Size(1697, 162)
        Me.proGroupBox.TabIndex = 31
        Me.proGroupBox.TabStop = False
        Me.proGroupBox.Text = "Product Information"
        '
        'cusGroupBox
        '
        Me.cusGroupBox.Controls.Add(Me.Button1)
        Me.cusGroupBox.Controls.Add(Me.result_lbl)
        Me.cusGroupBox.Controls.Add(Me.cusaddressTextBox)
        Me.cusGroupBox.Controls.Add(Me.Label9)
        Me.cusGroupBox.Controls.Add(Me.cusnameTextBox)
        Me.cusGroupBox.Controls.Add(Me.Label8)
        Me.cusGroupBox.Controls.Add(Me.Label3)
        Me.cusGroupBox.Controls.Add(Me.cusidTextBox)
        Me.cusGroupBox.Controls.Add(Me.checkButton)
        Me.cusGroupBox.Controls.Add(Me.Label4)
        Me.cusGroupBox.Controls.Add(Me.cusmobTextBox)
        Me.cusGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cusGroupBox.Location = New System.Drawing.Point(91, 144)
        Me.cusGroupBox.Name = "cusGroupBox"
        Me.cusGroupBox.Size = New System.Drawing.Size(1706, 194)
        Me.cusGroupBox.TabIndex = 28
        Me.cusGroupBox.TabStop = False
        Me.cusGroupBox.Text = "Customer Information"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1085, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Save "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'result_lbl
        '
        Me.result_lbl.AutoSize = True
        Me.result_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_lbl.Location = New System.Drawing.Point(246, 169)
        Me.result_lbl.Name = "result_lbl"
        Me.result_lbl.Size = New System.Drawing.Size(64, 25)
        Me.result_lbl.TabIndex = 33
        Me.result_lbl.Text = "status"
        Me.result_lbl.Visible = False
        '
        'cusaddressTextBox
        '
        Me.cusaddressTextBox.Location = New System.Drawing.Point(836, 100)
        Me.cusaddressTextBox.Multiline = True
        Me.cusaddressTextBox.Name = "cusaddressTextBox"
        Me.cusaddressTextBox.Size = New System.Drawing.Size(217, 88)
        Me.cusaddressTextBox.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(625, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 29)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Address"
        '
        'cusnameTextBox
        '
        Me.cusnameTextBox.Location = New System.Drawing.Point(836, 46)
        Me.cusnameTextBox.Name = "cusnameTextBox"
        Me.cusnameTextBox.Size = New System.Drawing.Size(217, 35)
        Me.cusnameTextBox.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 29)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Customer Id"
        '
        'billGroupBox
        '
        Me.billGroupBox.Controls.Add(Me.printButton)
        Me.billGroupBox.Controls.Add(Me.pay)
        Me.billGroupBox.Controls.Add(Me.Label5)
        Me.billGroupBox.Controls.Add(Me.Label6)
        Me.billGroupBox.Controls.Add(Me.TextBox5)
        Me.billGroupBox.Controls.Add(Me.TextBox1)
        Me.billGroupBox.Controls.Add(Me.TextBox6)
        Me.billGroupBox.Controls.Add(Me.Label7)
        Me.billGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.billGroupBox.Location = New System.Drawing.Point(91, 548)
        Me.billGroupBox.Name = "billGroupBox"
        Me.billGroupBox.Size = New System.Drawing.Size(1706, 225)
        Me.billGroupBox.TabIndex = 28
        Me.billGroupBox.TabStop = False
        Me.billGroupBox.Text = "Biling Details"
        '
        'printButton
        '
        Me.printButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printButton.Location = New System.Drawing.Point(595, 150)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(81, 40)
        Me.printButton.TabIndex = 36
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = True
        Me.printButton.Visible = False
        '
        'pay
        '
        Me.pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay.Location = New System.Drawing.Point(447, 150)
        Me.pay.Name = "pay"
        Me.pay.Size = New System.Drawing.Size(81, 40)
        Me.pay.TabIndex = 35
        Me.pay.Text = "Pay"
        Me.pay.UseVisualStyleBackColor = True
        '
        'PrintDialogmjb
        '
        Me.PrintDialogmjb.UseEXDialog = True
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 785)
        Me.Controls.Add(Me.billGroupBox)
        Me.Controls.Add(Me.cusGroupBox)
        Me.Controls.Add(Me.proGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sales"
        Me.Text = "Billing | Bakery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.proGroupBox.ResumeLayout(False)
        Me.proGroupBox.PerformLayout()
        Me.cusGroupBox.ResumeLayout(False)
        Me.cusGroupBox.PerformLayout()
        Me.billGroupBox.ResumeLayout(False)
        Me.billGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cusmobTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cusidTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id_TextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents checkButton As Button
    Friend WithEvents proGroupBox As GroupBox
    Friend WithEvents cusGroupBox As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cusnameTextBox As TextBox
    Friend WithEvents result_lbl As Label
    Friend WithEvents cusaddressTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents billGroupBox As GroupBox
    Friend WithEvents pay As Button
    Friend WithEvents printButton As Button
    Friend WithEvents PrintDialogmjb As PrintDialog
    Friend WithEvents PrintDocumentmjb As Printing.PrintDocument
End Class
