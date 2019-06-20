Public Class Accueil
    Private Sub Plateau_Mario_Click(sender As Object, e As EventArgs) Handles Plateau_Mario.Click
        PlateauMario.Show()
    End Sub
    Private Sub Calcul_Voyage_Click(sender As Object, e As EventArgs) Handles Calcul_Voyage.Click
        CalculVoyage.Show()
    End Sub
    Private Sub Banderole_Timer__Click(sender As Object, e As EventArgs) Handles Banderole_Timer.Click
        Banderole.Show()
    End Sub
    Private Sub Navigateur_Web_Click(sender As Object, e As EventArgs) Handles Navigateur_Web.Click
        NavigateurWeb.Show()
    End Sub
End Class