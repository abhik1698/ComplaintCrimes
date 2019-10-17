<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.uname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(217, 164)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(100, 22)
        Me.uname.TabIndex = 0
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(374, 164)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(100, 22)
        Me.fname.TabIndex = 1
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(526, 164)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(100, 22)
        Me.pwd.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 65)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.uname)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uname As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents pwd As TextBox
    Friend WithEvents Button1 As Button
End Class
