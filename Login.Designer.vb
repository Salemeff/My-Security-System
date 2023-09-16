<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.ShwPass = New System.Windows.Forms.CheckBox()
        Me.lblAL = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUserLogin = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(84, 83)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(105, 27)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "USER NAME"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUser.Visible = False
        '
        'lblPass
        '
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(84, 160)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(105, 20)
        Me.lblPass.TabIndex = 5
        Me.lblPass.Text = "PASSWORD"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPass.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(106, 261)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(63, 39)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(56, 117)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(160, 26)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(56, 186)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(160, 26)
        Me.txtPass.TabIndex = 1
        '
        'ShwPass
        '
        Me.ShwPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShwPass.Location = New System.Drawing.Point(90, 228)
        Me.ShwPass.Name = "ShwPass"
        Me.ShwPass.Size = New System.Drawing.Size(105, 16)
        Me.ShwPass.TabIndex = 4
        Me.ShwPass.Text = "Show Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ShwPass.UseVisualStyleBackColor = True
        '
        'lblAL
        '
        Me.lblAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAL.Location = New System.Drawing.Point(58, 40)
        Me.lblAL.Name = "lblAL"
        Me.lblAL.Size = New System.Drawing.Size(154, 27)
        Me.lblAL.TabIndex = 7
        Me.lblAL.Text = "ADMIN LOGIN"
        Me.lblAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.lblUserLogin)
        Me.GroupBox1.Controls.Add(Me.lblAL)
        Me.GroupBox1.Controls.Add(Me.ShwPass)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.lblPass)
        Me.GroupBox1.Controls.Add(Me.lblUser)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(271, 321)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lblUserLogin
        '
        Me.lblUserLogin.AutoSize = True
        Me.lblUserLogin.Location = New System.Drawing.Point(179, 287)
        Me.lblUserLogin.Name = "lblUserLogin"
        Me.lblUserLogin.Size = New System.Drawing.Size(84, 13)
        Me.lblUserLogin.TabIndex = 3
        Me.lblUserLogin.TabStop = True
        Me.lblUserLogin.Text = "Goto User Login"
        '
        'Login
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(298, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents ShwPass As CheckBox
    Friend WithEvents lblAL As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblUserLogin As LinkLabel
End Class
