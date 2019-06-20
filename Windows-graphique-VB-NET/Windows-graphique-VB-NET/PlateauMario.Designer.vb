<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlateauMario
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
        Me.Pan_Mario = New System.Windows.Forms.Panel()
        Me.Contrôles = New System.Windows.Forms.GroupBox()
        Me.BT_DESCEND = New System.Windows.Forms.Button()
        Me.BT_AVANCE = New System.Windows.Forms.Button()
        Me.BT_MONTE = New System.Windows.Forms.Button()
        Me.BT_RECULE = New System.Windows.Forms.Button()
        Me.Contrôles.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pan_Mario
        '
        Me.Pan_Mario.BackColor = System.Drawing.Color.Red
        Me.Pan_Mario.Location = New System.Drawing.Point(263, 109)
        Me.Pan_Mario.Name = "Pan_Mario"
        Me.Pan_Mario.Size = New System.Drawing.Size(27, 25)
        Me.Pan_Mario.TabIndex = 0
        '
        'Contrôles
        '
        Me.Contrôles.Controls.Add(Me.BT_DESCEND)
        Me.Contrôles.Controls.Add(Me.BT_AVANCE)
        Me.Contrôles.Controls.Add(Me.BT_MONTE)
        Me.Contrôles.Controls.Add(Me.BT_RECULE)
        Me.Contrôles.Location = New System.Drawing.Point(12, 382)
        Me.Contrôles.Name = "Contrôles"
        Me.Contrôles.Size = New System.Drawing.Size(409, 116)
        Me.Contrôles.TabIndex = 1
        Me.Contrôles.TabStop = False
        Me.Contrôles.Text = "Contrôles"
        '
        'BT_DESCEND
        '
        Me.BT_DESCEND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_DESCEND.Location = New System.Drawing.Point(172, 68)
        Me.BT_DESCEND.Name = "BT_DESCEND"
        Me.BT_DESCEND.Size = New System.Drawing.Size(97, 42)
        Me.BT_DESCEND.TabIndex = 3
        Me.BT_DESCEND.Text = "v"
        Me.BT_DESCEND.UseVisualStyleBackColor = True
        '
        'BT_AVANCE
        '
        Me.BT_AVANCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_AVANCE.Location = New System.Drawing.Point(275, 19)
        Me.BT_AVANCE.Name = "BT_AVANCE"
        Me.BT_AVANCE.Size = New System.Drawing.Size(79, 91)
        Me.BT_AVANCE.TabIndex = 2
        Me.BT_AVANCE.Text = ">"
        Me.BT_AVANCE.UseVisualStyleBackColor = True
        '
        'BT_MONTE
        '
        Me.BT_MONTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_MONTE.Location = New System.Drawing.Point(172, 19)
        Me.BT_MONTE.Name = "BT_MONTE"
        Me.BT_MONTE.Size = New System.Drawing.Size(97, 43)
        Me.BT_MONTE.TabIndex = 1
        Me.BT_MONTE.Text = "^"
        Me.BT_MONTE.UseVisualStyleBackColor = True
        '
        'BT_RECULE
        '
        Me.BT_RECULE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_RECULE.Location = New System.Drawing.Point(79, 19)
        Me.BT_RECULE.Name = "BT_RECULE"
        Me.BT_RECULE.Size = New System.Drawing.Size(87, 91)
        Me.BT_RECULE.TabIndex = 0
        Me.BT_RECULE.Text = "<"
        Me.BT_RECULE.UseVisualStyleBackColor = True
        '
        'PlateauMario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(433, 509)
        Me.Controls.Add(Me.Contrôles)
        Me.Controls.Add(Me.Pan_Mario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "PlateauMario"
        Me.Text = "Plateau de jeu"
        Me.Contrôles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pan_Mario As Panel
    Friend WithEvents Contrôles As GroupBox
    Friend WithEvents BT_DESCEND As Button
    Friend WithEvents BT_AVANCE As Button
    Friend WithEvents BT_MONTE As Button
    Friend WithEvents BT_RECULE As Button
End Class
