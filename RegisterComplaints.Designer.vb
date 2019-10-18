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
        Me.mlocation = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.comments = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cname
        '
        Me.cname.Location = New System.Drawing.Point(246, 154)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(100, 22)
        Me.cname.TabIndex = 0
        '
        'crimeb
        '
        Me.crimeb.Location = New System.Drawing.Point(246, 206)
        Me.crimeb.Name = "crimeb"
        Me.crimeb.Size = New System.Drawing.Size(100, 22)
        Me.crimeb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mlocation
        '
        Me.mlocation.Location = New System.Drawing.Point(246, 258)
        Me.mlocation.Name = "mlocation"
        Me.mlocation.Size = New System.Drawing.Size(100, 22)
        Me.mlocation.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(98, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 55)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Complaint"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'comments
        '
        Me.comments.Location = New System.Drawing.Point(403, 164)
        Me.comments.Name = "comments"
        Me.comments.Size = New System.Drawing.Size(339, 126)
        Me.comments.TabIndex = 5
        Me.comments.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Please Describe the Crime here:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Culprit Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Location:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Crime:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RegisterComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comments)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mlocation)
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
    Friend WithEvents mlocation As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents comments As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
