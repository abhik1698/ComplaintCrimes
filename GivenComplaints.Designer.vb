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
        Me.id.Location = New System.Drawing.Point(226, 96)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 22)
        Me.id.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mtable
        '
        Me.mtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.mtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.mtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mtable.Location = New System.Drawing.Point(498, 60)
        Me.mtable.Name = "mtable"
        Me.mtable.RowTemplate.Height = 24
        Me.mtable.Size = New System.Drawing.Size(851, 401)
        Me.mtable.TabIndex = 2
        '
        'Arr
        '
        Me.Arr.AutoSize = True
        Me.Arr.Location = New System.Drawing.Point(139, 173)
        Me.Arr.Name = "Arr"
        Me.Arr.Size = New System.Drawing.Size(67, 21)
        Me.Arr.TabIndex = 3
        Me.Arr.TabStop = True
        Me.Arr.Text = "Arrest"
        Me.Arr.UseVisualStyleBackColor = True
        '
        'Rel
        '
        Me.Rel.AutoSize = True
        Me.Rel.Location = New System.Drawing.Point(226, 173)
        Me.Rel.Name = "Rel"
        Me.Rel.Size = New System.Drawing.Size(81, 21)
        Me.Rel.TabIndex = 4
        Me.Rel.TabStop = True
        Me.Rel.Text = "Release"
        Me.Rel.UseVisualStyleBackColor = True
        '
        'Del
        '
        Me.Del.AutoSize = True
        Me.Del.Location = New System.Drawing.Point(328, 173)
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(136, 21)
        Me.Del.TabIndex = 5
        Me.Del.TabStop = True
        Me.Del.Text = "Delete Complaint"
        Me.Del.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Criminal ID"
        '
        'GivenComplaints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
