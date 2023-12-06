<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.user_txt = New System.Windows.Forms.TextBox()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bttn_login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Buttn_minimize = New System.Windows.Forms.Button()
        Me.bttn_close = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 393)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "password :"
        '
        'user_txt
        '
        Me.user_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_txt.HideSelection = False
        Me.user_txt.Location = New System.Drawing.Point(187, 322)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.Size = New System.Drawing.Size(344, 37)
        Me.user_txt.TabIndex = 2
        '
        'pass_txt
        '
        Me.pass_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_txt.Location = New System.Drawing.Point(187, 386)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(344, 37)
        Me.pass_txt.TabIndex = 3
        Me.pass_txt.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bttn_login)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.pass_txt)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.user_txt)
        Me.Panel1.Location = New System.Drawing.Point(188, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 557)
        Me.Panel1.TabIndex = 4
        '
        'bttn_login
        '
        Me.bttn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttn_login.Location = New System.Drawing.Point(74, 502)
        Me.bttn_login.Name = "bttn_login"
        Me.bttn_login.Size = New System.Drawing.Size(409, 50)
        Me.bttn_login.TabIndex = 6
        Me.bttn_login.Text = "login"
        Me.bttn_login.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.27826!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "user name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(534, 297)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Buttn_minimize)
        Me.Panel2.Controls.Add(Me.bttn_close)
        Me.Panel2.Location = New System.Drawing.Point(188, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(534, 40)
        Me.Panel2.TabIndex = 5
        '
        'Buttn_minimize
        '
        Me.Buttn_minimize.BackgroundImage = CType(resources.GetObject("Buttn_minimize.BackgroundImage"), System.Drawing.Image)
        Me.Buttn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buttn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Buttn_minimize.Location = New System.Drawing.Point(445, 0)
        Me.Buttn_minimize.Name = "Buttn_minimize"
        Me.Buttn_minimize.Size = New System.Drawing.Size(38, 40)
        Me.Buttn_minimize.TabIndex = 7
        Me.Buttn_minimize.UseVisualStyleBackColor = True
        '
        'bttn_close
        '
        Me.bttn_close.BackgroundImage = CType(resources.GetObject("bttn_close.BackgroundImage"), System.Drawing.Image)
        Me.bttn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttn_close.Location = New System.Drawing.Point(489, 0)
        Me.bttn_close.Name = "bttn_close"
        Me.bttn_close.Size = New System.Drawing.Size(45, 40)
        Me.bttn_close.TabIndex = 6
        Me.bttn_close.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(964, 807)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents user_txt As TextBox
    Friend WithEvents pass_txt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bttn_login As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bttn_close As Button
    Friend WithEvents Buttn_minimize As Button
End Class
