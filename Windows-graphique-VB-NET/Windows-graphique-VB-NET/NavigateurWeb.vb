Public Class NavigateurWeb
    Private Sub NavigateurWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Les deux lignes suivantes peuvent être remplacées par Me.WB_NAVIGATEUR.Navigate("http://www.google.fr")
        Me.TXT_ADRESSE.Text = "http://www.google.fr"
        'Simule un clic en passant comme argument nothing (null)
        Me.BT_ADRESSE_Click(Nothing, Nothing)

        'Au démarrage, pas de possibilité de « Précédent »,  « Suivant », « Stop »
        Me.BT_SUIVANT.Enabled = False
        Me.BT_PRECEDENT.Enabled = False
        Me.BT_STOP.Enabled = False
    End Sub

#Region "Boutons de navigation"

    Private Sub BT_ADRESSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ADRESSE.Click
        'S'il existe une adresse, on y va
        If Not Me.TXT_ADRESSE Is Nothing Then
            Me.WB_NAVIGATEUR.Navigate(TXT_ADRESSE.Text)
        End If
    End Sub

    Private Sub BT_PRECEDENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PRECEDENT.Click
        'Va à la page précédente
        Me.WB_NAVIGATEUR.GoBack()
    End Sub

    Private Sub BT_SUIVANT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SUIVANT.Click
        'Va à la page suivante
        Me.WB_NAVIGATEUR.GoForward()
    End Sub

    Private Sub BT_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_STOP.Click
        'Désactive le bouton « Stop » et arrête le chargement du navigateur
        Me.BT_STOP.Enabled = False
        Me.WB_NAVIGATEUR.Stop()
    End Sub

    Private Sub BT_REFRESH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_REFRESH.Click
        'Rafraîchit le navigateur
        Me.WB_NAVIGATEUR.Refresh()
    End Sub

#End Region

#Region "Evènements du WBroser"

    'À chaque changement d'état, on met à jour les boutons
    Sub WB_NAVIGATEUR_CanGoForwardChanged(ByVal sender As Object, ByVal e As EventArgs) Handles WB_NAVIGATEUR.CanGoForwardChanged
        If Me.WB_NAVIGATEUR.CanGoForward Then
            Me.BT_SUIVANT.Enabled = True
        Else
            Me.BT_SUIVANT.Enabled = False
        End If
    End Sub

    'À chaque changement d'état, on met à jour les boutons
    Sub WB_NAVIGATEUR_CanGoBackChanged(ByVal sender As Object, ByVal e As EventArgs) Handles WB_NAVIGATEUR.CanGoBackChanged
        If Me.WB_NAVIGATEUR.CanGoBack Then
            Me.BT_PRECEDENT.Enabled = True
        Else
            Me.BT_PRECEDENT.Enabled = False
        End If
    End Sub

    'Au changement de statut de la page
    Sub WB_NAVIGATEUR_StatutTextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles WB_NAVIGATEUR.StatusTextChanged
        'On met le statut à jour
        Me.LBL_STATUT.Text = WB_NAVIGATEUR.StatusText
    End Sub

    'Au changement de progression de la page
    Sub WB_NAVIGATEUR_ProgressChanged(ByVal sender As Object, ByVal e As WebBrowserProgressChangedEventArgs) Handles WB_NAVIGATEUR.ProgressChanged
        Me.PGB_STATUT.Maximum = e.MaximumProgress
        If (e.CurrentProgress >= 0) Then
            Me.PGB_STATUT.Value = e.CurrentProgress
        End If
    End Sub

    'Lorsque le chargement est fini
    Private Sub WB_NAVIGATEUR_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WB_NAVIGATEUR.DocumentCompleted
        'on désactive le bouton « Stop »
        Me.BT_STOP.Enabled = False
        'on cache la barre de progression
        Me.PGB_STATUT.Visible = False
        'on récupère l'adresse de la page et on l'affiche
        Me.TXT_ADRESSE.Text = Me.WB_NAVIGATEUR.Url.ToString
    End Sub

    'Lorsque le chargement commence
    Private Sub WB_NAVIGATEUR_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WB_NAVIGATEUR.Navigating
        'On active le bouton « Stop »
        Me.BT_STOP.Enabled = True
        'Au début du chargement, on affiche la barre de progression
        Me.PGB_STATUT.Visible = True
    End Sub
#End Region

End Class