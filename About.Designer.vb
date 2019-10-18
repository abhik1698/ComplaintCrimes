<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.des = New System.Windows.Forms.Label()
        Me.cmp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'des
        '
        Me.des.AutoSize = True
        Me.des.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.des.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.des.Location = New System.Drawing.Point(38, 33)
        Me.des.Name = "des"
        Me.des.Size = New System.Drawing.Size(59, 20)
        Me.des.TabIndex = 0
        Me.des.Text = "Label1"
        Me.des.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmp
        '
        Me.cmp.AutoSize = True
        Me.cmp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmp.Location = New System.Drawing.Point(38, 86)
        Me.cmp.Name = "cmp"
        Me.cmp.Size = New System.Drawing.Size(59, 20)
        Me.cmp.TabIndex = 1
        Me.cmp.Text = "Label1"
        Me.cmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComplaintCrimes.My.Resources.Resources.aboutBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1322, 481)
        Me.Controls.Add(Me.cmp)
        Me.Controls.Add(Me.des)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents des As Label
    Friend WithEvents cmp As Label
End Class
