<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.browse = New System.Windows.Forms.Button
        Me.quit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ofdpictureviewer = New System.Windows.Forms.OpenFileDialog
        Me.music = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'browse
        '
        Me.browse.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.browse.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.browse.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.browse.ImageKey = "(none)"
        Me.browse.Location = New System.Drawing.Point(652, 3)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(101, 39)
        Me.browse.TabIndex = 0
        Me.browse.Text = "browse"
        Me.browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.browse.UseVisualStyleBackColor = False
        '
        'quit
        '
        Me.quit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.quit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.quit.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit.Location = New System.Drawing.Point(652, 48)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(101, 39)
        Me.quit.TabIndex = 1
        Me.quit.Text = "quit"
        Me.quit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(618, 424)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'music
        '
        Me.music.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.music.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.music.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.music.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.music.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.music.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.music.Location = New System.Drawing.Point(652, 93)
        Me.music.Name = "music"
        Me.music.Size = New System.Drawing.Size(101, 39)
        Me.music.TabIndex = 3
        Me.music.Text = "music"
        Me.music.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(663, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 454)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.music)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.browse)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents quit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ofdpictureviewer As System.Windows.Forms.OpenFileDialog
    Friend WithEvents music As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
