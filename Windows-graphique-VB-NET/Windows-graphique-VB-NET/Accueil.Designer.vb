<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Calcul_Voyage = New System.Windows.Forms.Button()
        Me.Navigateur_Web = New System.Windows.Forms.Button()
        Me.Plateau_Mario = New System.Windows.Forms.Button()
        Me.Banderole_Timer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Calcul_Voyage
        '
        Me.Calcul_Voyage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Calcul_Voyage.Location = New System.Drawing.Point(12, 12)
        Me.Calcul_Voyage.Name = "Calcul_Voyage"
        Me.Calcul_Voyage.Size = New System.Drawing.Size(97, 92)
        Me.Calcul_Voyage.TabIndex = 0
        Me.Calcul_Voyage.Text = "Calcul Voyage"
        Me.Calcul_Voyage.UseVisualStyleBackColor = True
        '
        'Navigateur_Web
        '
        Me.Navigateur_Web.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Navigateur_Web.Location = New System.Drawing.Point(115, 110)
        Me.Navigateur_Web.Name = "Navigateur_Web"
        Me.Navigateur_Web.Size = New System.Drawing.Size(97, 92)
        Me.Navigateur_Web.TabIndex = 1
        Me.Navigateur_Web.Text = "Navigateur web"
        Me.Navigateur_Web.UseVisualStyleBackColor = True
        '
        'Plateau_Mario
        '
        Me.Plateau_Mario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Plateau_Mario.Location = New System.Drawing.Point(12, 110)
        Me.Plateau_Mario.Name = "Plateau_Mario"
        Me.Plateau_Mario.Size = New System.Drawing.Size(97, 92)
        Me.Plateau_Mario.TabIndex = 2
        Me.Plateau_Mario.Text = "Plateau Mario "
        Me.Plateau_Mario.UseVisualStyleBackColor = True
        '
        'Banderole_Timer
        '
        Me.Banderole_Timer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Banderole_Timer.Location = New System.Drawing.Point(115, 12)
        Me.Banderole_Timer.Name = "Banderole_Timer"
        Me.Banderole_Timer.Size = New System.Drawing.Size(97, 92)
        Me.Banderole_Timer.TabIndex = 3
        Me.Banderole_Timer.Text = "Banderole"
        Me.Banderole_Timer.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 208)
        Me.Controls.Add(Me.Banderole_Timer)
        Me.Controls.Add(Me.Plateau_Mario)
        Me.Controls.Add(Me.Navigateur_Web)
        Me.Controls.Add(Me.Calcul_Voyage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Accueil"
        Me.Text = "Accueil "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Calcul_Voyage As Button
    Friend WithEvents Navigateur_Web As Button
    Friend WithEvents Plateau_Mario As Button
    Friend WithEvents Banderole_Timer As Button
End Class
