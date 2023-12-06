Imports System.Net.NetworkInformation

Public Class frm_RDVJour






    Private Sub rdvjour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdvjour(DataGridView1)
        bttn_delete.FlatStyle = FlatStyle.Flat
        bttn_delete.BackColor = Color.Red
        bttn_delete.ForeColor = Color.White
        bttn_delete.FlatAppearance.BorderColor = Color.White

    End Sub






    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick






    End Sub

    Private Sub bttn_delete_Click(sender As Object, e As EventArgs) Handles bttn_delete.Click
        Dim f As Integer
        f = DataGridView1.SelectedCells(0).RowIndex
        tab(f) = Nothing
        DataGridView1.Rows.RemoveAt(f)
        MessageBox.Show("delete succeed")






    End Sub

    Private Sub bttn_modify_Click(sender As Object, e As EventArgs)





    End Sub
End Class