Module Module2

    Public Structure rdv
        Dim code As String
        Dim temp As String



    End Structure


    Dim nb As Integer = 0
    Public tab(100) As rdv

    Public Sub add(r As rdv)
        If nb < 100 Then
            tab(nb) = r
            nb += 1
            MessageBox.Show("RDV enregistrer pour le code : " & r.code.ToString())
        End If
    End Sub

    Public Sub rdvjour(s As DataGridView)
        For Each r As rdv In tab
            s.Rows.Add(r.code, r.temp)
        Next

    End Sub


End Module
