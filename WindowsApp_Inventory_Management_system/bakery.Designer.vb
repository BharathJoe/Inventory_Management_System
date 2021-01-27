<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bakery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bakery))
        Me.salesreport = New System.Windows.Forms.PictureBox()
        Me.stockPictureBox = New System.Windows.Forms.PictureBox()
        Me.logout = New System.Windows.Forms.PictureBox()
        Me.servicedesk = New System.Windows.Forms.PictureBox()
        Me.sales = New System.Windows.Forms.PictureBox()
        Me.newuser = New System.Windows.Forms.PictureBox()
        Me.changeuser = New System.Windows.Forms.PictureBox()
        Me.supplierpic = New System.Windows.Forms.PictureBox()
        CType(Me.salesreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.servicedesk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.supplierpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salesreport
        '
        Me.salesreport.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.salesreport
        Me.salesreport.Location = New System.Drawing.Point(495, 12)
        Me.salesreport.Name = "salesreport"
        Me.salesreport.Size = New System.Drawing.Size(155, 122)
        Me.salesreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.salesreport.TabIndex = 14
        Me.salesreport.TabStop = False
        '
        'stockPictureBox
        '
        Me.stockPictureBox.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.stock
        Me.stockPictureBox.Location = New System.Drawing.Point(173, 12)
        Me.stockPictureBox.Name = "stockPictureBox"
        Me.stockPictureBox.Size = New System.Drawing.Size(155, 122)
        Me.stockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stockPictureBox.TabIndex = 13
        Me.stockPictureBox.TabStop = False
        '
        'logout
        '
        Me.logout.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.logout
        Me.logout.Location = New System.Drawing.Point(1139, 12)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(155, 122)
        Me.logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logout.TabIndex = 12
        Me.logout.TabStop = False
        '
        'servicedesk
        '
        Me.servicedesk.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.desk
        Me.servicedesk.Location = New System.Drawing.Point(978, 12)
        Me.servicedesk.Name = "servicedesk"
        Me.servicedesk.Size = New System.Drawing.Size(155, 122)
        Me.servicedesk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.servicedesk.TabIndex = 11
        Me.servicedesk.TabStop = False
        '
        'sales
        '
        Me.sales.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.sales
        Me.sales.Location = New System.Drawing.Point(334, 12)
        Me.sales.Name = "sales"
        Me.sales.Size = New System.Drawing.Size(155, 122)
        Me.sales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sales.TabIndex = 10
        Me.sales.TabStop = False
        '
        'newuser
        '
        Me.newuser.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.user
        Me.newuser.Location = New System.Drawing.Point(12, 12)
        Me.newuser.Name = "newuser"
        Me.newuser.Size = New System.Drawing.Size(155, 122)
        Me.newuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.newuser.TabIndex = 8
        Me.newuser.TabStop = False
        '
        'changeuser
        '
        Me.changeuser.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.changeuser
        Me.changeuser.Location = New System.Drawing.Point(817, 12)
        Me.changeuser.Name = "changeuser"
        Me.changeuser.Size = New System.Drawing.Size(155, 122)
        Me.changeuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.changeuser.TabIndex = 7
        Me.changeuser.TabStop = False
        '
        'supplierpic
        '
        Me.supplierpic.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.supplier
        Me.supplierpic.Location = New System.Drawing.Point(656, 12)
        Me.supplierpic.Name = "supplierpic"
        Me.supplierpic.Size = New System.Drawing.Size(155, 122)
        Me.supplierpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.supplierpic.TabIndex = 6
        Me.supplierpic.TabStop = False
        '
        'bakery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.page_bg_blur02
        Me.ClientSize = New System.Drawing.Size(1851, 714)
        Me.Controls.Add(Me.salesreport)
        Me.Controls.Add(Me.stockPictureBox)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.servicedesk)
        Me.Controls.Add(Me.sales)
        Me.Controls.Add(Me.newuser)
        Me.Controls.Add(Me.changeuser)
        Me.Controls.Add(Me.supplierpic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "bakery"
        Me.Text = "Inventory System | Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.salesreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.servicedesk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.supplierpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sales As PictureBox
    Friend WithEvents newuser As PictureBox
    Friend WithEvents changeuser As PictureBox
    Friend WithEvents supplierpic As PictureBox
    Friend WithEvents servicedesk As PictureBox
    Friend WithEvents logout As PictureBox
    Friend WithEvents stockPictureBox As PictureBox
    Friend WithEvents salesreport As PictureBox
End Class
