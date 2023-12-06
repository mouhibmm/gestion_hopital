Module Module1

    Public Structure patient
        Dim code As String
        Dim nom As String
        Dim prenom As String
    End Structure


    Dim nb As Integer = 0
    Public tabf(100) As patient

    Public Sub ajouter(p As patient)
        If nb < 100 Then
            tabf(nb) = p
            nb += 1
            MessageBox.Show("patient ajouter avec succes")
        ElseIf nb > 100 Then
            MessageBox.Show("liste saturée")


        End If
    End Sub

    Public Sub afficher(s As DataGridView)
        For Each p As patient In tabf
            s.Rows.Add(p.code, p.nom, p.prenom)
        Next

    End Sub

End Module
