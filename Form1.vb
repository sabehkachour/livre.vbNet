Public Class Form1
    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        Dim l As Livre
        l.ISBN = TextISBN.Text
        l.titre = TextTitre.Text
        l.auteur = TextAuteur.Text

        If ajouterLivre(l) Then
            MessageBox.Show("ajouter livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est sature")
        End If
    End Sub

    Private Sub ButtonAfficher_Click(sender As Object, e As EventArgs) Handles ButtonAfficher.Click
        Form2.Show()
    End Sub
End Class
