<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NavigateurWeb
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
        Me.BT_PRECEDENT = New System.Windows.Forms.Button()
        Me.BT_SUIVANT = New System.Windows.Forms.Button()
        Me.BT_REFRESH = New System.Windows.Forms.Button()
        Me.BT_STOP = New System.Windows.Forms.Button()
        Me.TXT_ADRESSE = New System.Windows.Forms.TextBox()
        Me.BT_ADRESSE = New System.Windows.Forms.Button()
        Me.WB_NAVIGATEUR = New System.Windows.Forms.WebBrowser()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LBL_STATUT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PGB_STATUT = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_PRECEDENT
        '
        Me.BT_PRECEDENT.BackColor = System.Drawing.Color.Silver
        Me.BT_PRECEDENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_PRECEDENT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_PRECEDENT.Location = New System.Drawing.Point(22, 12)
        Me.BT_PRECEDENT.Name = "BT_PRECEDENT"
        Me.BT_PRECEDENT.Size = New System.Drawing.Size(40, 31)
        Me.BT_PRECEDENT.TabIndex = 0
        Me.BT_PRECEDENT.Text = "<"
        Me.BT_PRECEDENT.UseVisualStyleBackColor = False
        '
        'BT_SUIVANT
        '
        Me.BT_SUIVANT.BackColor = System.Drawing.Color.Silver
        Me.BT_SUIVANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SUIVANT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BT_SUIVANT.Location = New System.Drawing.Point(68, 12)
        Me.BT_SUIVANT.Name = "BT_SUIVANT"
        Me.BT_SUIVANT.Size = New System.Drawing.Size(44, 31)
        Me.BT_SUIVANT.TabIndex = 1
        Me.BT_SUIVANT.Text = ">"
        Me.BT_SUIVANT.UseVisualStyleBackColor = False
        '
        'BT_REFRESH
        '
        Me.BT_REFRESH.BackColor = System.Drawing.Color.SteelBlue
        Me.BT_REFRESH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_REFRESH.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BT_REFRESH.Location = New System.Drawing.Point(167, 12)
        Me.BT_REFRESH.Name = "BT_REFRESH"
        Me.BT_REFRESH.Size = New System.Drawing.Size(60, 31)
        Me.BT_REFRESH.TabIndex = 2
        Me.BT_REFRESH.Text = "Refresh"
        Me.BT_REFRESH.UseVisualStyleBackColor = False
        '
        'BT_STOP
        '
        Me.BT_STOP.BackColor = System.Drawing.Color.IndianRed
        Me.BT_STOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_STOP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BT_STOP.Location = New System.Drawing.Point(233, 12)
        Me.BT_STOP.Name = "BT_STOP"
        Me.BT_STOP.Size = New System.Drawing.Size(61, 31)
        Me.BT_STOP.TabIndex = 3
        Me.BT_STOP.Text = "Stop"
        Me.BT_STOP.UseVisualStyleBackColor = False
        '
        'TXT_ADRESSE
        '
        Me.TXT_ADRESSE.Location = New System.Drawing.Point(310, 18)
        Me.TXT_ADRESSE.Name = "TXT_ADRESSE"
        Me.TXT_ADRESSE.Size = New System.Drawing.Size(1085, 20)
        Me.TXT_ADRESSE.TabIndex = 4
        '
        'BT_ADRESSE
        '
        Me.BT_ADRESSE.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BT_ADRESSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BT_ADRESSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ADRESSE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BT_ADRESSE.Location = New System.Drawing.Point(1393, 17)
        Me.BT_ADRESSE.Name = "BT_ADRESSE"
        Me.BT_ADRESSE.Size = New System.Drawing.Size(82, 22)
        Me.BT_ADRESSE.TabIndex = 5
        Me.BT_ADRESSE.Text = "Rechercher"
        Me.BT_ADRESSE.UseVisualStyleBackColor = False
        '
        'WB_NAVIGATEUR
        '
        Me.WB_NAVIGATEUR.Location = New System.Drawing.Point(2, 54)
        Me.WB_NAVIGATEUR.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB_NAVIGATEUR.Name = "WB_NAVIGATEUR"
        Me.WB_NAVIGATEUR.ScriptErrorsSuppressed = True
        Me.WB_NAVIGATEUR.Size = New System.Drawing.Size(1488, 709)
        Me.WB_NAVIGATEUR.TabIndex = 6
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBL_STATUT, Me.PGB_STATUT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 764)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1490, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LBL_STATUT
        '
        Me.LBL_STATUT.Name = "LBL_STATUT"
        Me.LBL_STATUT.Size = New System.Drawing.Size(0, 17)
        '
        'PGB_STATUT
        '
        Me.PGB_STATUT.Name = "PGB_STATUT"
        Me.PGB_STATUT.Size = New System.Drawing.Size(100, 16)
        '
        'NavigateurWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 786)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WB_NAVIGATEUR)
        Me.Controls.Add(Me.BT_ADRESSE)
        Me.Controls.Add(Me.TXT_ADRESSE)
        Me.Controls.Add(Me.BT_STOP)
        Me.Controls.Add(Me.BT_REFRESH)
        Me.Controls.Add(Me.BT_SUIVANT)
        Me.Controls.Add(Me.BT_PRECEDENT)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NavigateurWeb"
        Me.Text = "Navigateur Web"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_PRECEDENT As Button
    Friend WithEvents BT_SUIVANT As Button
    Friend WithEvents BT_REFRESH As Button
    Friend WithEvents BT_STOP As Button
    Friend WithEvents TXT_ADRESSE As TextBox
    Friend WithEvents BT_ADRESSE As Button
    Friend WithEvents WB_NAVIGATEUR As WebBrowser
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LBL_STATUT As ToolStripStatusLabel
    Friend WithEvents PGB_STATUT As ToolStripProgressBar
End Class
