Public Class affiche


    Private Sub affiche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher(dgv_pat)
        bttn_delete.FlatStyle = FlatStyle.Flat
        bttn_delete.BackColor = Color.Red
        bttn_delete.ForeColor = Color.White
        bttn_delete.FlatAppearance.BorderColor = Color.White
    End Sub

    Private Sub dgv_pat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_pat.CellContentClick

    End Sub

    Private Sub bttn_delete_Click(sender As Object, e As EventArgs) Handles bttn_delete.Click

        Dim f As Integer
        f = dgv_pat.SelectedCells(0).RowIndex
        tabf(f) = Nothing
        dgv_pat.Rows.RemoveAt(f)
        MessageBox.Show("delete succeed")
    End Sub
End Class