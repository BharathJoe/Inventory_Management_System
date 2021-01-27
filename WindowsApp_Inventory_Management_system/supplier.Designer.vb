<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supplier))
        Me.mobnum = New System.Windows.Forms.TextBox()
        Me.pcode = New System.Windows.Forms.TextBox()
        Me.city = New System.Windows.Forms.ListBox()
        Me.state = New System.Windows.Forms.ListBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.viewbtn = New System.Windows.Forms.Button()
        Me.suppdGridView = New System.Windows.Forms.DataGridView()
        Me.clear = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.address = New System.Windows.Forms.TextBox()
        Me.cname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.suppdGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mobnum
        '
        Me.mobnum.Location = New System.Drawing.Point(313, 704)
        Me.mobnum.Name = "mobnum"
        Me.mobnum.Size = New System.Drawing.Size(172, 26)
        Me.mobnum.TabIndex = 41
        '
        'pcode
        '
        Me.pcode.Location = New System.Drawing.Point(313, 653)
        Me.pcode.Name = "pcode"
        Me.pcode.Size = New System.Drawing.Size(172, 26)
        Me.pcode.TabIndex = 40
        '
        'city
        '
        Me.city.FormattingEnabled = True
        Me.city.ItemHeight = 20
        Me.city.Items.AddRange(New Object() {"Mumbai", "New Delhi", "Kolkatha", "Chennai", "Bangalore", "Ahamedabad", "Pune", "Cochin", "Ooty"})
        Me.city.Location = New System.Drawing.Point(313, 531)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(172, 104)
        Me.city.TabIndex = 39
        '
        'state
        '
        Me.state.FormattingEnabled = True
        Me.state.ItemHeight = 20
        Me.state.Items.AddRange(New Object() {"Andhra Pradesh", "Bihar", "Goa", "Karnataka", "Kerala", "Tamilnadu", "Others"})
        Me.state.Location = New System.Drawing.Point(313, 391)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(172, 124)
        Me.state.TabIndex = 38
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(1130, 245)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(143, 35)
        Me.delete.TabIndex = 37
        Me.delete.Text = "Delete Suppliers"
        Me.delete.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(939, 245)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(143, 35)
        Me.updatebtn.TabIndex = 36
        Me.updatebtn.Text = "Update Details"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'viewbtn
        '
        Me.viewbtn.Location = New System.Drawing.Point(742, 245)
        Me.viewbtn.Name = "viewbtn"
        Me.viewbtn.Size = New System.Drawing.Size(143, 35)
        Me.viewbtn.TabIndex = 35
        Me.viewbtn.Text = "View Suppliers"
        Me.viewbtn.UseVisualStyleBackColor = True
        '
        'suppdGridView
        '
        Me.suppdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.suppdGridView.Location = New System.Drawing.Point(726, 297)
        Me.suppdGridView.Name = "suppdGridView"
        Me.suppdGridView.RowTemplate.Height = 28
        Me.suppdGridView.Size = New System.Drawing.Size(989, 490)
        Me.suppdGridView.TabIndex = 34
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(535, 531)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(88, 35)
        Me.clear.TabIndex = 33
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(535, 447)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(88, 35)
        Me.addbtn.TabIndex = 32
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(313, 277)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(172, 93)
        Me.address.TabIndex = 31
        '
        'cname
        '
        Me.cname.Location = New System.Drawing.Point(313, 235)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(172, 26)
        Me.cname.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 701)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 29)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Mobile"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(147, 649)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 29)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Post Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(182, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 542)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 29)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 29)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 29)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Company Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(667, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 29)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "SUPPLIER DETAILS"
        '
        'supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1785, 795)
        Me.Controls.Add(Me.mobnum)
        Me.Controls.Add(Me.pcode)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.viewbtn)
        Me.Controls.Add(Me.suppdGridView)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "supplier"
        Me.Text = "Distributor Details "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.suppdGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mobnum As TextBox
    Friend WithEvents pcode As TextBox
    Friend WithEvents city As ListBox
    Friend WithEvents state As ListBox
    Friend WithEvents delete As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents viewbtn As Button
    Friend WithEvents suppdGridView As DataGridView
    Friend WithEvents clear As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents address As TextBox
    Friend WithEvents cname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
