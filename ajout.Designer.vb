<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ajout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ajout))
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_afficher = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bttn_close = New System.Windows.Forms.Button()
        Me.Bttn_minimise = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Palatino Linotype", 11.89565!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(29, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Code"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Palatino Linotype", 11.89565!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(29, 130)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "nom"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Palatino Linotype", 11.89565!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(29, 238)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 25)
        Me.label3.TabIndex = 2
        Me.label3.Text = "prenom"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(160, 41)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(220, 22)
        Me.txt_code.TabIndex = 3
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(160, 130)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(220, 22)
        Me.txt_nom.TabIndex = 4
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(160, 238)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(220, 22)
        Me.txt_prenom.TabIndex = 5
        '
        'btn_ajout
        '
        Me.btn_ajout.Location = New System.Drawing.Point(340, 608)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(106, 36)
        Me.btn_ajout.TabIndex = 6
        Me.btn_ajout.Text = "ajout"
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'btn_afficher
        '
        Me.btn_afficher.Location = New System.Drawing.Point(489, 608)
        Me.btn_afficher.Name = "btn_afficher"
        Me.btn_afficher.Size = New System.Drawing.Size(106, 36)
        Me.btn_afficher.TabIndex = 7
        Me.btn_afficher.Text = "afficher"
        Me.btn_afficher.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 20.03478!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 43)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ajouter un patient "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_code)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.label3)
        Me.Panel1.Controls.Add(Me.txt_prenom)
        Me.Panel1.Controls.Add(Me.txt_nom)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Location = New System.Drawing.Point(50, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 323)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(50, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 77)
        Me.Panel2.TabIndex = 10
        '
        'bttn_close
        '
        Me.bttn_close.BackgroundImage = CType(resources.GetObject("bttn_close.BackgroundImage"), System.Drawing.Image)
        Me.bttn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttn_close.Location = New System.Drawing.Point(604, 1)
        Me.bttn_close.Name = "bttn_close"
        Me.bttn_close.Size = New System.Drawing.Size(43, 36)
        Me.bttn_close.TabIndex = 9
        Me.bttn_close.UseVisualStyleBackColor = True
        '
        'Bttn_minimise
        '
        Me.Bttn_minimise.BackgroundImage = CType(resources.GetObject("Bttn_minimise.BackgroundImage"), System.Drawing.Image)
        Me.Bttn_minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Bttn_minimise.Location = New System.Drawing.Point(552, 1)
        Me.Bttn_minimise.Name = "Bttn_minimise"
        Me.Bttn_minimise.Size = New System.Drawing.Size(43, 36)
        Me.Bttn_minimise.TabIndex = 11
        Me.Bttn_minimise.UseVisualStyleBackColor = True
        '
        'ajout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(647, 656)
        Me.Controls.Add(Me.Bttn_minimise)
        Me.Controls.Add(Me.bttn_close)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_afficher)
        Me.Controls.Add(Me.btn_ajout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ajout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ajout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents label3 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_afficher As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bttn_close As Button
    Friend WithEvents Bttn_minimise As Button
End Class
