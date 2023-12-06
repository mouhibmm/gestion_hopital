<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class affiche
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
        Me.dgv_pat = New System.Windows.Forms.DataGridView()
        Me.CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRENOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bttn_delete = New System.Windows.Forms.Button()
        CType(Me.dgv_pat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_pat
        '
        Me.dgv_pat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODE, Me.NOM, Me.PRENOM})
        Me.dgv_pat.Location = New System.Drawing.Point(12, 12)
        Me.dgv_pat.MultiSelect = False
        Me.dgv_pat.Name = "dgv_pat"
        Me.dgv_pat.RowHeadersWidth = 51
        Me.dgv_pat.RowTemplate.Height = 24
        Me.dgv_pat.Size = New System.Drawing.Size(528, 426)
        Me.dgv_pat.TabIndex = 0
        '
        'CODE
        '
        Me.CODE.HeaderText = "CODE"
        Me.CODE.MinimumWidth = 6
        Me.CODE.Name = "CODE"
        Me.CODE.Width = 125
        '
        'NOM
        '
        Me.NOM.HeaderText = "NOM"
        Me.NOM.MinimumWidth = 6
        Me.NOM.Name = "NOM"
        Me.NOM.Width = 125
        '
        'PRENOM
        '
        Me.PRENOM.HeaderText = "PRENOM"
        Me.PRENOM.MinimumWidth = 6
        Me.PRENOM.Name = "PRENOM"
        Me.PRENOM.Width = 125
        '
        'bttn_delete
        '
        Me.bttn_delete.Location = New System.Drawing.Point(649, 394)
        Me.bttn_delete.Name = "bttn_delete"
        Me.bttn_delete.Size = New System.Drawing.Size(118, 44)
        Me.bttn_delete.TabIndex = 1
        Me.bttn_delete.Text = "delete"
        Me.bttn_delete.UseVisualStyleBackColor = True
        '
        'affiche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bttn_delete)
        Me.Controls.Add(Me.dgv_pat)
        Me.Name = "affiche"
        Me.Text = "affiche"
        CType(Me.dgv_pat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_pat As DataGridView
    Friend WithEvents CODE As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents PRENOM As DataGridViewTextBoxColumn
    Friend WithEvents bttn_delete As Button
End Class
