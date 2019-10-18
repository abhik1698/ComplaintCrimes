<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterComplaints
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
        Me.cname = New System.Windows.Forms.TextBox()
        Me.crimeb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.location = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.comments = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cname
        '
        Me.cname.Location = New System.Drawing.Point(241, 99)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(100, 22)
        Me.cname.TabIndex = 0
        '
        'crimeb
        '
        Me.crimeb.Location = New System.Drawing.Point(241, 151)
        Me.crimeb.Name = "crimeb"
        Me.crimeb.Size = New System.Drawing.Size(100, 22)
        Me.crimeb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'location
        '
        Me.location.Location = New System.Drawing.Point(241, 203)
        Me.location.Name = "location"
        Me.location.Size = New System.Drawing.Size(100, 22)
        Me.location.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 95)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Complaint"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'comments
        '
        Me.comments.Location = New System.Drawing.Point(398, 109)
        Me.comments.Name = "comments"
        Me.comments.Size = New System.Drawing.Size(339, 126)
        Me.comments.TabIndex = 5
        Me.comments.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Please Describe the Crime here"
        '
        'RegisterComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comments)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.location)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crimeb)
        Me.Controls.Add(Me.cname)
        Me.Name = "RegisterComplaints"
        Me.Text = "Register Complaints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cname As TextBox
    Friend WithEvents crimeb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents location As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents comments As RichTextBox
    Friend WithEvents Label2 As Label
End Class
