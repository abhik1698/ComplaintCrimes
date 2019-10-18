<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CMap
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
        Me.mtable = New System.Windows.Forms.DataGridView()
        CType(Me.mtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(231, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(506, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "For Safety Pupose, stay alert in these Regions"
        '
        'mtable
        '
        Me.mtable.AllowUserToAddRows = False
        Me.mtable.AllowUserToDeleteRows = False
        Me.mtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.mtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.mtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mtable.Location = New System.Drawing.Point(12, 10)
        Me.mtable.Name = "mtable"
        Me.mtable.ReadOnly = True
        Me.mtable.RowTemplate.Height = 24
        Me.mtable.Size = New System.Drawing.Size(213, 428)
        Me.mtable.TabIndex = 1
        '
        'CMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ComplaintCrimes.My.Resources.Resources.CMapBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.mtable)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CMap"
        Me.Text = "CMap"
        CType(Me.mtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mtable As DataGridView
End Class
