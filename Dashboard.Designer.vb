<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvailableTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsedTicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsConditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSeCloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicalSupportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlinePrivacyStatementToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsConditionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutSecloToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.TimerWelcome = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(680, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvailableTicketsToolStripMenuItem, Me.UsedTicketsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ViewToolStripMenuItem.Text = "&Edit"
        '
        'AvailableTicketsToolStripMenuItem
        '
        Me.AvailableTicketsToolStripMenuItem.Name = "AvailableTicketsToolStripMenuItem"
        Me.AvailableTicketsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AvailableTicketsToolStripMenuItem.Text = "Edit Ticket"
        '
        'UsedTicketsToolStripMenuItem
        '
        Me.UsedTicketsToolStripMenuItem.Name = "UsedTicketsToolStripMenuItem"
        Me.UsedTicketsToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.UsedTicketsToolStripMenuItem.Text = " Delete Ticket"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendFeedbackToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&View"
        '
        'SendFeedbackToolStripMenuItem
        '
        Me.SendFeedbackToolStripMenuItem.Name = "SendFeedbackToolStripMenuItem"
        Me.SendFeedbackToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SendFeedbackToolStripMenuItem.Text = "Registered Users"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TermsConditionToolStripMenuItem, Me.AboutSeCloToolStripMenuItem, Me.TechnicalSupportToolStripMenuItem1, Me.OnlinePrivacyStatementToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'TermsConditionToolStripMenuItem
        '
        Me.TermsConditionToolStripMenuItem.Name = "TermsConditionToolStripMenuItem"
        Me.TermsConditionToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TermsConditionToolStripMenuItem.Text = "View Help"
        '
        'AboutSeCloToolStripMenuItem
        '
        Me.AboutSeCloToolStripMenuItem.Name = "AboutSeCloToolStripMenuItem"
        Me.AboutSeCloToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AboutSeCloToolStripMenuItem.Text = "Send Feedback"
        '
        'TechnicalSupportToolStripMenuItem1
        '
        Me.TechnicalSupportToolStripMenuItem1.Name = "TechnicalSupportToolStripMenuItem1"
        Me.TechnicalSupportToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.TechnicalSupportToolStripMenuItem1.Text = "Technical Support"
        '
        'OnlinePrivacyStatementToolStripMenuItem1
        '
        Me.OnlinePrivacyStatementToolStripMenuItem1.Name = "OnlinePrivacyStatementToolStripMenuItem1"
        Me.OnlinePrivacyStatementToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.OnlinePrivacyStatementToolStripMenuItem1.Text = "Online Privacy statement"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TermsConditionToolStripMenuItem1, Me.AboutSecloToolStripMenuItem1})
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'TermsConditionToolStripMenuItem1
        '
        Me.TermsConditionToolStripMenuItem1.Name = "TermsConditionToolStripMenuItem1"
        Me.TermsConditionToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.TermsConditionToolStripMenuItem1.Text = "Terms $ Condition"
        '
        'AboutSecloToolStripMenuItem1
        '
        Me.AboutSecloToolStripMenuItem1.Name = "AboutSecloToolStripMenuItem1"
        Me.AboutSecloToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.AboutSecloToolStripMenuItem1.Text = "About Seclo"
        '
        'lblWelcome
        '
        Me.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcome.Font = New System.Drawing.Font("OCR-B 10 BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(274, 190)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(125, 23)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "WELCOME"
        '
        'TimerWelcome
        '
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(680, 419)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvailableTicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsedTicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblWelcome As Label
    Friend WithEvents TimerWelcome As Timer
    Friend WithEvents SendFeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TermsConditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutSeCloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TermsConditionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutSecloToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TechnicalSupportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OnlinePrivacyStatementToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
