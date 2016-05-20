<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transparency
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transparency))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trackBar = New System.Windows.Forms.TrackBar()
        Me.txt10 = New System.Windows.Forms.Label()
        Me.txt100 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.trackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Opacity"
        '
        'trackBar
        '
        Me.trackBar.Location = New System.Drawing.Point(13, 30)
        Me.trackBar.Maximum = 100
        Me.trackBar.Minimum = 10
        Me.trackBar.Name = "trackBar"
        Me.trackBar.Size = New System.Drawing.Size(344, 45)
        Me.trackBar.TabIndex = 1
        Me.trackBar.Value = 70
        '
        'txt10
        '
        Me.txt10.AutoSize = True
        Me.txt10.Location = New System.Drawing.Point(13, 78)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(27, 13)
        Me.txt10.TabIndex = 2
        Me.txt10.Text = "10%"
        '
        'txt100
        '
        Me.txt100.AutoSize = True
        Me.txt100.Location = New System.Drawing.Point(324, 78)
        Me.txt100.Name = "txt100"
        Me.txt100.Size = New System.Drawing.Size(33, 13)
        Me.txt100.TabIndex = 3
        Me.txt100.Text = "100%"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(201, 113)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(282, 113)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'transparency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 148)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txt100)
        Me.Controls.Add(Me.txt10)
        Me.Controls.Add(Me.trackBar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "transparency"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Opacity"
        CType(Me.trackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents trackBar As TrackBar
    Friend WithEvents txt10 As Label
    Friend WithEvents txt100 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
