<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newuser))
        Me.clear = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.email = New System.Windows.Forms.TextBox()
        Me.aaddress = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.mobno = New System.Windows.Forms.TextBox()
        Me.eid = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.aname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(318, 463)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(77, 47)
        Me.clear.TabIndex = 35
        Me.clear.Text = "clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(202, 463)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(110, 47)
        Me.submit.TabIndex = 34
        Me.submit.Text = "submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(202, 410)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(193, 39)
        Me.email.TabIndex = 33
        '
        'aaddress
        '
        Me.aaddress.Location = New System.Drawing.Point(202, 318)
        Me.aaddress.Multiline = True
        Me.aaddress.Name = "aaddress"
        Me.aaddress.Size = New System.Drawing.Size(193, 73)
        Me.aaddress.TabIndex = 32
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(202, 264)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(193, 39)
        Me.password.TabIndex = 31
        '
        'mobno
        '
        Me.mobno.Location = New System.Drawing.Point(202, 210)
        Me.mobno.Name = "mobno"
        Me.mobno.Size = New System.Drawing.Size(193, 39)
        Me.mobno.TabIndex = 30
        '
        'eid
        '
        Me.eid.Location = New System.Drawing.Point(202, 161)
        Me.eid.Name = "eid"
        Me.eid.Size = New System.Drawing.Size(193, 39)
        Me.eid.TabIndex = 29
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(202, 110)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(193, 39)
        Me.username.TabIndex = 28
        '
        'aname
        '
        Me.aname.Location = New System.Drawing.Point(202, 59)
        Me.aname.Name = "aname"
        Me.aname.Size = New System.Drawing.Size(193, 39)
        Me.aname.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 29)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Email Id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 29)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 29)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Mobile no"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 29)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Admin Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.clear)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.submit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.aaddress)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.password)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.mobno)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.eid)
        Me.GroupBox1.Controls.Add(Me.aname)
        Me.GroupBox1.Controls.Add(Me.username)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(555, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 561)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sign Up"
        '
        'newuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1733, 715)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "newuser"
        Me.Text = "New Admin | Sign Up"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents clear As Button
    Friend WithEvents submit As Button
    Friend WithEvents email As TextBox
    Friend WithEvents aaddress As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents mobno As TextBox
    Friend WithEvents eid As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents aname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
