<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welform))
        Me.timer1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer1
        '
        Me.timer1.AutoSize = True
        Me.timer1.Location = New System.Drawing.Point(577, 510)
        Me.timer1.Name = "timer1"
        Me.timer1.Size = New System.Drawing.Size(44, 20)
        Me.timer1.TabIndex = 3
        Me.timer1.Text = "timer"
        Me.timer1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.ezgif_com_crop
        Me.PictureBox1.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.ezgif_com_crop
        Me.PictureBox1.Location = New System.Drawing.Point(539, 164)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 314)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'welform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.PicsArt_10_12_07_56_32
        Me.ClientSize = New System.Drawing.Size(1430, 688)
        Me.Controls.Add(Me.timer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "welform"
        Me.Text = "welcome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
