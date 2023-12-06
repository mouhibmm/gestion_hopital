Public Class Form1
    Private Sub AjoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjoutToolStripMenuItem.Click
        ajout.Show()
    End Sub

    Private Sub AfficheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficheToolStripMenuItem.Click
        affiche.Show()

    End Sub

    Private Sub AjoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjoutToolStripMenuItem1.Click
        frm_PriseRDV.Show()
    End Sub

    Private Sub AfficheToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AfficheToolStripMenuItem1.Click
        frm_RDVJour.Show()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub MakePanelTransparent(panel As Panel)
        panel.BackColor = Color.FromArgb(90, 0, 0, 0)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)







    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub bttn_close_Click(sender As Object, e As EventArgs) Handles bttn_close.Click
        Me.Close()

    End Sub

    Private Sub bttn_minimise_Click(sender As Object, e As EventArgs) Handles bttn_minimise.Click
        WindowState = WindowState.Minimized
    End Sub

    Private Sub btn_recherche_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        MakePanelTransparent(Panel1)
    End Sub
End Class
