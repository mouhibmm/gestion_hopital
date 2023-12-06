<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PriseRDV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PriseRDV))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.codep = New System.Windows.Forms.TextBox()
        Me.btn_valid = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bttn_minimise = New System.Windows.Forms.Button()
        Me.bttn_close = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "code patient"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Palatino Linotype", 11.89565!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(62, 208)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(119, 25)
        Me.label2.TabIndex = 1
        Me.label2.Text = "date et heure"
        '
        'codep
        '
        Me.codep.Location = New System.Drawing.Point(307, 81)
        Me.codep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.codep.Name = "codep"
        Me.codep.Size = New System.Drawing.Size(288, 33)
        Me.codep.TabIndex = 2
        '
        'btn_valid
        '
        Me.btn_valid.Location = New System.Drawing.Point(827, 708)
        Me.btn_valid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_valid.Name = "btn_valid"
        Me.btn_valid.Size = New System.Drawing.Size(168, 52)
        Me.btn_valid.TabIndex = 4
        Me.btn_valid.Text = "valider"
        Me.btn_valid.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(627, 708)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(154, 52)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(307, 200)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 33)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 20.03478!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 44)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "prendre un RDV"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(267, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 76)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.codep)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(57, 225)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 397)
        Me.Panel2.TabIndex = 9
        '
        'bttn_minimise
        '
        Me.bttn_minimise.BackgroundImage = CType(resources.GetObject("bttn_minimise.BackgroundImage"), System.Drawing.Image)
        Me.bttn_minimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttn_minimise.Location = New System.Drawing.Point(925, 1)
        Me.bttn_minimise.Name = "bttn_minimise"
        Me.bttn_minimise.Size = New System.Drawing.Size(38, 36)
        Me.bttn_minimise.TabIndex = 10
        Me.bttn_minimise.UseVisualStyleBackColor = True
        '
        'bttn_close
        '
        Me.bttn_close.BackgroundImage = CType(resources.GetObject("bttn_close.BackgroundImage"), System.Drawing.Image)
        Me.bttn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttn_close.Location = New System.Drawing.Point(969, 1)
        Me.bttn_close.Name = "bttn_close"
        Me.bttn_close.Size = New System.Drawing.Size(43, 36)
        Me.bttn_close.TabIndex = 11
        Me.bttn_close.UseVisualStyleBackColor = True
        '
        'frm_PriseRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1058, 778)
        Me.Controls.Add(Me.bttn_close)
        Me.Controls.Add(Me.bttn_minimise)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_valid)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Palatino Linotype", 11.89565!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_PriseRDV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PriseRDV"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents codep As TextBox
    Friend WithEvents btn_valid As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents bttn_minimise As Button
    Friend WithEvents bttn_close As Button
End Class
