<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficheToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.bttn_close = New System.Windows.Forms.Button()
        Me.bttn_minimise = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.RDVToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(920, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutToolStripMenuItem, Me.AfficheToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.PatientToolStripMenuItem.Text = "patient"
        '
        'AjoutToolStripMenuItem
        '
        Me.AjoutToolStripMenuItem.Name = "AjoutToolStripMenuItem"
        Me.AjoutToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.AjoutToolStripMenuItem.Text = "ajout"
        '
        'AfficheToolStripMenuItem
        '
        Me.AfficheToolStripMenuItem.Name = "AfficheToolStripMenuItem"
        Me.AfficheToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.AfficheToolStripMenuItem.Text = "affiche"
        '
        'RDVToolStripMenuItem
        '
        Me.RDVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutToolStripMenuItem1, Me.AfficheToolStripMenuItem1})
        Me.RDVToolStripMenuItem.Name = "RDVToolStripMenuItem"
        Me.RDVToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.RDVToolStripMenuItem.Text = "RDV"
        '
        'AjoutToolStripMenuItem1
        '
        Me.AjoutToolStripMenuItem1.Name = "AjoutToolStripMenuItem1"
        Me.AjoutToolStripMenuItem1.Size = New System.Drawing.Size(247, 26)
        Me.AjoutToolStripMenuItem1.Text = "prend RDV"
        '
        'AfficheToolStripMenuItem1
        '
        Me.AfficheToolStripMenuItem1.Name = "AfficheToolStripMenuItem1"
        Me.AfficheToolStripMenuItem1.Size = New System.Drawing.Size(247, 26)
        Me.AfficheToolStripMenuItem1.Text = "afficher les RDV de jour"
        '
        'bttn_close
        '
        Me.bttn_close.BackgroundImage = CType(resources.GetObject("bttn_close.BackgroundImage"), System.Drawing.Image)
        Me.bttn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttn_close.Location = New System.Drawing.Point(882, 0)
        Me.bttn_close.Name = "bttn_close"
        Me.bttn_close.Size = New System.Drawing.Size(38, 28)
        Me.bttn_close.TabIndex = 6
        Me.bttn_close.UseVisualStyleBackColor = True
        '
        'bttn_minimise
        '
        Me.bttn_minimise.BackgroundImage = CType(resources.GetObject("bttn_minimise.BackgroundImage"), System.Drawing.Image)
        Me.bttn_minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttn_minimise.Location = New System.Drawing.Point(838, 0)
        Me.bttn_minimise.Name = "bttn_minimise"
        Me.bttn_minimise.Size = New System.Drawing.Size(38, 28)
        Me.bttn_minimise.TabIndex = 7
        Me.bttn_minimise.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 589)
        Me.Panel1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(920, 622)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bttn_minimise)
        Me.Controls.Add(Me.bttn_close)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficheToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficheToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AjoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents bttn_close As Button
    Friend WithEvents bttn_minimise As Button
    Friend WithEvents Panel1 As Panel
End Class
