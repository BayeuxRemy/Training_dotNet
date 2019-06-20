Public Class Banderole
    Private Sub TIM_TIM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIM_TIM.Tick
        Dim Tourne As Boolean = True
        Dim Bouton As Integer = 0

        'Rassemble tous les boutons radio dans un tableau
        Dim RB(9) As RadioButton
        RB(0) = Me.RB_1
        RB(1) = Me.RB_2
        RB(2) = Me.RB_3
        RB(3) = Me.RB_4
        RB(4) = Me.RB_5
        RB(5) = Me.RB_6
        RB(6) = Me.RB_7
        RB(7) = Me.RB_8
        RB(8) = Me.RB_9
        RB(9) = Me.RB_10

        While Tourne
            'Si on est arrivé au bout du tableau, on sort de cette boucle
            If Bouton = 10 Then
                Tourne = False
            Else
                'Si le bouton actuellement parcouru est activé
                If RB(Bouton).Checked Then
                    'Et si ce n'est pas le dernier
                    If RB(Bouton) IsNot RB(9) Then
                        'on active celui d’après et on sort de la boucle
                        RB(Bouton + 1).Checked = True
                        Tourne = False
                    Else
                        'Sinon on reprend au premier
                        Me.RB_1.Checked = True
                    End If
                End If
                'On incrémente le compteur
                Bouton = Bouton + 1
            End If
        End While
    End Sub

    Private Sub BT_PLAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PLAY.Click
        Me.TIM_TIM.Enabled = True
        Me.TIM_TIM.Interval = 501 - Me.TKB_VIT.Value * 50
    End Sub

    Private Sub BT_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_STOP.Click
        Me.TIM_TIM.Enabled = False
    End Sub

    Private Sub TKB_VIT_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKB_VIT.Scroll
        Me.TIM_TIM.Interval = 501 - Me.TKB_VIT.Value * 50
    End Sub
End Class