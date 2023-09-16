<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.btnGen = New System.Windows.Forms.Button()
        Me.txtGen = New System.Windows.Forms.TextBox()
        Me.cbHour = New System.Windows.Forms.ComboBox()
        Me.cbMin = New System.Windows.Forms.ComboBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.LblHour = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.CurrentTime = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGen
        '
        Me.btnGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGen.Location = New System.Drawing.Point(343, 230)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(60, 35)
        Me.btnGen.TabIndex = 0
        Me.btnGen.Text = "Gen"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'txtGen
        '
        Me.txtGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGen.Location = New System.Drawing.Point(177, 236)
        Me.txtGen.Name = "txtGen"
        Me.txtGen.Size = New System.Drawing.Size(87, 29)
        Me.txtGen.TabIndex = 1
        '
        'cbHour
        '
        Me.cbHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHour.FormattingEnabled = True
        Me.cbHour.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbHour.Location = New System.Drawing.Point(177, 171)
        Me.cbHour.Name = "cbHour"
        Me.cbHour.Size = New System.Drawing.Size(70, 32)
        Me.cbHour.TabIndex = 2
        '
        'cbMin
        '
        Me.cbMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMin.FormattingEnabled = True
        Me.cbMin.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cbMin.Location = New System.Drawing.Point(333, 171)
        Me.cbMin.Name = "cbMin"
        Me.cbMin.Size = New System.Drawing.Size(70, 32)
        Me.cbMin.TabIndex = 4
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(193, 331)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(86, 35)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(83, 241)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(61, 24)
        Me.lblCode.TabIndex = 6
        Me.lblCode.Text = "Code:"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(280, 175)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(46, 24)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "Min:"
        '
        'LblHour
        '
        Me.LblHour.AutoSize = True
        Me.LblHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHour.Location = New System.Drawing.Point(87, 176)
        Me.LblHour.Name = "LblHour"
        Me.LblHour.Size = New System.Drawing.Size(57, 24)
        Me.LblHour.TabIndex = 8
        Me.LblHour.Text = "Hour:"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(321, 331)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(72, 35)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(87, 61)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(68, 23)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name:"
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(70, 122)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(105, 23)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "Username:"
        '
        'txtName
        '
        Me.txtName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(177, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(229, 29)
        Me.txtName.TabIndex = 13
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(177, 119)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(229, 29)
        Me.txtUsername.TabIndex = 14
        '
        'CurrentTime
        '
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.cbMin)
        Me.GroupBox3.Controls.Add(Me.lblMin)
        Me.GroupBox3.Controls.Add(Me.btnGen)
        Me.GroupBox3.Controls.Add(Me.LblHour)
        Me.GroupBox3.Controls.Add(Me.cbHour)
        Me.GroupBox3.Controls.Add(Me.txtGen)
        Me.GroupBox3.Controls.Add(Me.lblCode)
        Me.GroupBox3.Controls.Add(Me.txtUsername)
        Me.GroupBox3.Controls.Add(Me.txtName)
        Me.GroupBox3.Controls.Add(Me.lblUsername)
        Me.GroupBox3.Controls.Add(Me.lblName)
        Me.GroupBox3.Controls.Add(Me.btnBack)
        Me.GroupBox3.Controls.Add(Me.btnCreate)
        Me.GroupBox3.Location = New System.Drawing.Point(67, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 405)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Honeydew
        Me.Label1.Location = New System.Drawing.Point(215, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 35)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "REGISTRATION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(638, 462)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGen As Button
    Friend WithEvents txtGen As TextBox
    Friend WithEvents cbHour As ComboBox
    Friend WithEvents cbMin As ComboBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents lblCode As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents LblHour As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents CurrentTime As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
End Class
