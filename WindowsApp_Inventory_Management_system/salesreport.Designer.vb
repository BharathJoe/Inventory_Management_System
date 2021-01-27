<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesreport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesreport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.salesGridView = New System.Windows.Forms.DataGridView()
        Me.viewsales = New System.Windows.Forms.Button()
        CType(Me.salesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(585, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Information"
        '
        'salesGridView
        '
        Me.salesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salesGridView.Location = New System.Drawing.Point(497, 268)
        Me.salesGridView.Name = "salesGridView"
        Me.salesGridView.RowTemplate.Height = 28
        Me.salesGridView.Size = New System.Drawing.Size(940, 523)
        Me.salesGridView.TabIndex = 1
        '
        'viewsales
        '
        Me.viewsales.Location = New System.Drawing.Point(403, 366)
        Me.viewsales.Name = "viewsales"
        Me.viewsales.Size = New System.Drawing.Size(88, 51)
        Me.viewsales.TabIndex = 2
        Me.viewsales.Text = "view"
        Me.viewsales.UseVisualStyleBackColor = True
        '
        'salesreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1753, 803)
        Me.Controls.Add(Me.viewsales)
        Me.Controls.Add(Me.salesGridView)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "salesreport"
        Me.Text = "Sales Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.salesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents salesGridView As DataGridView
    Friend WithEvents viewsales As Button
End Class
