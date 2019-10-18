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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.mtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(180, 74)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(100, 22)
        Me.uname.TabIndex = 0
        '
        'pname
        '
        Me.pname.Location = New System.Drawing.Point(180, 119)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(100, 22)
        Me.pname.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 45)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Inspector"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rank
        '
        Me.rank.Location = New System.Drawing.Point(180, 166)
        Me.rank.Name = "rank"
        Me.rank.Size = New System.Drawing.Size(100, 22)
        Me.rank.TabIndex = 3
        '
        'mtable
        '
        Me.mtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.mtable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.mtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mtable.Location = New System.Drawing.Point(342, 130)
        Me.mtable.Name = "mtable"
        Me.mtable.RowTemplate.Height = 24
        Me.mtable.Size = New System.Drawing.Size(996, 338)
        Me.mtable.TabIndex = 4
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(180, 217)
        Me.pwd.Name = "pwd"
        Me.pwd.Size = New System.Drawing.Size(100, 22)
        Me.pwd.TabIndex = 5
        '
        'searchText
        '
        Me.searchText.Location = New System.Drawing.Point(753, 74)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(100, 22)
        Me.searchText.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(961, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 46)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(716, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Criminal Name or Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Police Rank"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Username"
        '
        'CriminalHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 480)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
