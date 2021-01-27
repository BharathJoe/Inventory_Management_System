<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.result_lbl = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.reset = New System.Windows.Forms.Button()
        Me.submit = New System.Windows.Forms.Button()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.Label()
        Me.bgPictureBox = New System.Windows.Forms.PictureBox()
        Me.loginPanel.SuspendLayout()
        CType(Me.bgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginPanel
        '
        Me.loginPanel.BackColor = System.Drawing.Color.Transparent
        Me.loginPanel.BackgroundImage = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.IMG_20191014_WA00521
        Me.loginPanel.Controls.Add(Me.result_lbl)
        Me.loginPanel.Controls.Add(Me.username)
        Me.loginPanel.Controls.Add(Me.password)
        Me.loginPanel.Controls.Add(Me.reset)
        Me.loginPanel.Controls.Add(Me.submit)
        Me.loginPanel.Controls.Add(Me.passwordLabel)
        Me.loginPanel.Controls.Add(Me.usernameLabel)
        Me.loginPanel.Controls.Add(Me.login)
        Me.loginPanel.Location = New System.Drawing.Point(577, 59)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(665, 369)
        Me.loginPanel.TabIndex = 10
        '
        'result_lbl
        '
        Me.result_lbl.AutoSize = True
        Me.result_lbl.BackColor = System.Drawing.Color.Transparent
        Me.result_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.result_lbl.Location = New System.Drawing.Point(285, 315)
        Me.result_lbl.Name = "result_lbl"
        Me.result_lbl.Size = New System.Drawing.Size(92, 25)
        Me.result_lbl.TabIndex = 14
        Me.result_lbl.Text = "message"
        Me.result_lbl.Visible = False
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(288, 158)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(160, 26)
        Me.username.TabIndex = 13
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(288, 212)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(160, 26)
        Me.password.TabIndex = 12
        Me.password.UseSystemPasswordChar = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(370, 259)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(78, 35)
        Me.reset.TabIndex = 11
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(288, 259)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(76, 35)
        Me.submit.TabIndex = 10
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.BackColor = System.Drawing.Color.Transparent
        Me.passwordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.passwordLabel.Location = New System.Drawing.Point(128, 205)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(139, 32)
        Me.passwordLabel.TabIndex = 9
        Me.passwordLabel.Text = "Password"
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.usernameLabel.Location = New System.Drawing.Point(128, 151)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(145, 32)
        Me.usernameLabel.TabIndex = 8
        Me.usernameLabel.Text = "Username"
        '
        'login
        '
        Me.login.AutoSize = True
        Me.login.BackColor = System.Drawing.Color.Transparent
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.login.Location = New System.Drawing.Point(295, 73)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(118, 46)
        Me.login.TabIndex = 7
        Me.login.Text = "Login"
        '
        'bgPictureBox
        '
        Me.bgPictureBox.Image = Global.WindowsApp_Inventory_Management_system.My.Resources.Resources.IMG_20191014_WA0052
        Me.bgPictureBox.InitialImage = CType(resources.GetObject("bgPictureBox.InitialImage"), System.Drawing.Image)
        Me.bgPictureBox.Location = New System.Drawing.Point(-233, -145)
        Me.bgPictureBox.Name = "bgPictureBox"
        Me.bgPictureBox.Size = New System.Drawing.Size(2500, 1200)
        Me.bgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bgPictureBox.TabIndex = 9
        Me.bgPictureBox.TabStop = False
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 680)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.bgPictureBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "loginform"
        Me.Text = "Login | Inventory Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        CType(Me.bgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginPanel As Panel
    Friend WithEvents result_lbl As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents reset As Button
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents login As Label
    Friend WithEvents bgPictureBox As PictureBox
    Friend WithEvents submit As Button
End Class
