Public Class ajout
    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        affiche.Show()
    End Sub


    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim x As patient
        x.code = txt_code.Text
        x.nom = txt_nom.Text
        x.prenom = txt_prenom.Text
        ajouter(x)

        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()


    End Sub
    Private Sub MakePanelTransparent(panel As Panel)
        panel.BackColor = Color.FromArgb(70, 0, 0, 0)
    End Sub


    Private Sub ajout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1.BackColor = Color.Transparent
        label2.BackColor = Color.Transparent
        label3.BackColor = Color.Transparent
        Label4.BackColor = Color.Transparent
        label1.ForeColor = Color.White
        label2.ForeColor = Color.White
        label3.ForeColor = Color.White
        Label4.ForeColor = Color.White

        txt_code.BackColor = Color.Pink
        txt_nom.BackColor = Color.Pink
        txt_prenom.BackColor = Color.Pink
        btn_afficher.FlatStyle = FlatStyle.Flat
        btn_afficher.BackColor = Color.FromArgb(39, 174, 96)
        btn_afficher.ForeColor = Color.White
        btn_afficher.FlatAppearance.BorderColor = Color.White
        btn_ajout.FlatStyle = FlatStyle.Flat
        btn_ajout.BackColor = Color.FromArgb(39, 174, 96)
        btn_ajout.ForeColor = Color.White
        btn_ajout.FlatAppearance.BorderColor = Color.White
        MakePanelTransparent(Panel1)
        MakePanelTransparent(Panel2)
        bttn_close.BackColor = Color.FromArgb(90, 0, 0, 0)
        Bttn_minimise.BackColor = Color.FromArgb(90, 0, 0, 0)





    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub bttn_close_Click(sender As Object, e As EventArgs) Handles bttn_close.Click
        Me.Close()

    End Sub

    Private Sub Bttn_minimise_Click(sender As Object, e As EventArgs) Handles Bttn_minimise.Click
        WindowState = WindowState.Minimized

    End Sub
End Class