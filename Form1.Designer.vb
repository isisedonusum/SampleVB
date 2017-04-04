<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVKN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtURLeArchive = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(766, 636)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtURLeArchive)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtPass)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtUser)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtVKN)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtURL)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(758, 603)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bilgiler"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pass"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(139, 172)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(148, 26)
        Me.txtPass.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User Name"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(139, 132)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(148, 26)
        Me.txtUser.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "VKN"
        '
        'txtVKN
        '
        Me.txtVKN.Location = New System.Drawing.Point(139, 92)
        Me.txtVKN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVKN.Name = "txtVKN"
        Me.txtVKN.Size = New System.Drawing.Size(148, 26)
        Me.txtVKN.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "URL e-Fatura"
        '
        'txtURL
        '
        Me.txtURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURL.Location = New System.Drawing.Point(139, 20)
        Me.txtURL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(604, 26)
        Me.txtURL.TabIndex = 0
        Me.txtURL.Text = "http://musteritestws.isisbilisim.com.tr/services/einvoice/ReportInvoiceList.svc"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(758, 603)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fatura Listesi"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Listele"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "URL e-Arşiv"
        '
        'txtURLeArchive
        '
        Me.txtURLeArchive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtURLeArchive.Location = New System.Drawing.Point(139, 56)
        Me.txtURLeArchive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtURLeArchive.Name = "txtURLeArchive"
        Me.txtURLeArchive.Size = New System.Drawing.Size(604, 26)
        Me.txtURLeArchive.TabIndex = 8
        Me.txtURLeArchive.Text = "http://musteritestws.isisbilisim.com.tr/Services/earchive/ReceiverInvoices.svc"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(758, 603)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "İptal Fatura Gönder"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox5.Location = New System.Drawing.Point(0, 349)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(766, 287)
        Me.TextBox5.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 118)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Gönder"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 636)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVKN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtURLeArchive As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox

End Class
