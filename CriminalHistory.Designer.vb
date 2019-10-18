<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CriminalHistory
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
        Me.pname = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rank = New System.Windows.Forms.TextBox()
        Me.mtable = New System.Windows.Forms.DataGridView()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.mtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(197, 74)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(100, 22)
        Me.uname.TabIndex = 0
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(197, 118)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(100, 22)
        Me.pname.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(39, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(258, 107)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Inspector"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'rank
        '
        Me.rank.Location = New System.Drawing.Point(197, 166)
        Me.rank.Name = "rank"
        Me.rank.Size = New System.Drawing.Size(100, 22)
        Me.rank.TabIndex = 3
        '
        'mtable
        '
        Me.mtable.AllowUserToAddRows = False
        Me.mtable.AllowUserToOrderColumns = True
        Me.mtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.mtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.mtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mtable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.mtable.Location = New System.Drawing.Point(342, 130)
        Me.mtable.Name = "mtable"
        Me.mtable.RowTemplate.Height = 24
        Me.mtable.Size = New System.Drawing.Size(996, 338)
        Me.mtable.TabIndex = 4
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(197, 216)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(100, 22)
        Me.pwd.TabIndex = 5
        '
        'searchText
        '
        Me.searchText.Location = New System.Drawing.Point(665, 86)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(244, 22)
        Me.searchText.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(950, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 47)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Criminal Name or Location:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Username:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Police Rank:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Name:"
        '
        'CriminalHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 480)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.pwd)
        Me.Controls.Add(Me.mtable)
        Me.Controls.Add(Me.rank)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.uname)
        Me.Name = "CriminalHistory"
        Me.Text = "Criminal Records"
        CType(Me.mtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uname As TextBox
    Friend WithEvents pname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents rank As TextBox
    Friend WithEvents mtable As DataGridView
    Friend WithEvents pwd As TextBox
    Friend WithEvents searchText As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
