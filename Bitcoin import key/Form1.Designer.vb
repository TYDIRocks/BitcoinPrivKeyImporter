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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Private key:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Passcode:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(382, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(82, 84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(256, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Import!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(82, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(382, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Donations go to:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(104, 115)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(234, 20)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "1TydiD57N9m54SrX7XNWhNTzJLN4msJNj"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(126, 6)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(288, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bitcoind.exe location:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(420, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 20)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 148)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Bitcoin import private key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog

End Class
