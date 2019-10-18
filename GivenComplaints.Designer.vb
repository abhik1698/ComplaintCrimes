<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GivenComplaints
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
        Me.id = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mtable = New System.Windows.Forms.DataGridView()
        Me.Arr = New System.Windows.Forms.RadioButton()
        Me.Rel = New System.Windows.Forms.RadioButton()
        Me.Del = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.mtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(210, 48)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 22)
        Me.id.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(338, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mtable
        '
        Me.mtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.mtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.mtable.BackgroundColor = System.Drawing.SystemColors.WindowFrame
        Me.mtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mtable.Location = New System.Drawing.Point(656, 6)
        Me.mtable.Name = "mtable"
        Me.mtable.RowTemplate.Height = 24
        Me.mtable.Size = New System.Drawing.Size(693, 459)
        Me.mtable.TabIndex = 2
        '
        'Arr
        '
        Me.Arr.AutoSize = True
        Me.Arr.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Arr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Arr.Location = New System.Drawing.Point(274, 98)
        Me.Arr.Name = "Arr"
        Me.Arr.Size = New System.Drawing.Size(74, 22)
        Me.Arr.TabIndex = 3
        Me.Arr.TabStop = True
        Me.Arr.Text = "Arrest"
        Me.Arr.UseVisualStyleBackColor = False
        '
        'Rel
        '
        Me.Rel.AutoSize = True
        Me.Rel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Rel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rel.Location = New System.Drawing.Point(373, 98)
        Me.Rel.Name = "Rel"
        Me.Rel.Size = New System.Drawing.Size(90, 22)
        Me.Rel.TabIndex = 4
        Me.Rel.TabStop = True
        Me.Rel.Text = "Release"
        Me.Rel.UseVisualStyleBackColor = False
        '
        'Del
        '
        Me.Del.AutoSize = True
        Me.Del.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Del.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del.Location = New System.Drawing.Point(80, 98)
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(158, 22)
        Me.Del.TabIndex = 5
        Me.Del.TabStop = True
        Me.Del.Text = "Delete Complaint"
        Me.Del.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(76, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Criminal ID:"
        '
        'GivenComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComplaintCrimes.My.Resources.Resources.GivenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1361, 473)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Del)
        Me.Controls.Add(Me.Rel)
        Me.Controls.Add(Me.Arr)
        Me.Controls.Add(Me.mtable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.id)
        Me.Name = "GivenComplaints"
        Me.Text = "GivenComplaints"
        CType(Me.mtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents id As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents mtable As DataGridView
    Friend WithEvents Arr As RadioButton
    Friend WithEvents Rel As RadioButton
    Friend WithEvents Del As RadioButton
    Friend WithEvents Label1 As Label
End Class
