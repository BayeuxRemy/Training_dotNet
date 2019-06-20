<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculVoyage
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
        Me.BT_CALCUL = New System.Windows.Forms.Button()
        Me.TXT_CONSOMMATION = New System.Windows.Forms.TextBox()
        Me.TXT_PRIXESS = New System.Windows.Forms.TextBox()
        Me.TXT_NBKM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBL_ERR = New System.Windows.Forms.Label()
        Me.LBL_COUT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_CALCUL
        '
        Me.BT_CALCUL.Location = New System.Drawing.Point(12, 182)
        Me.BT_CALCUL.Name = "BT_CALCUL"
        Me.BT_CALCUL.Size = New System.Drawing.Size(342, 40)
        Me.BT_CALCUL.TabIndex = 0
        Me.BT_CALCUL.Text = "Calculer"
        Me.BT_CALCUL.UseVisualStyleBackColor = True
        '
        'TXT_CONSOMMATION
        '
        Me.TXT_CONSOMMATION.Location = New System.Drawing.Point(229, 66)
        Me.TXT_CONSOMMATION.Name = "TXT_CONSOMMATION"
        Me.TXT_CONSOMMATION.Size = New System.Drawing.Size(125, 20)
        Me.TXT_CONSOMMATION.TabIndex = 1
        '
        'TXT_PRIXESS
        '
        Me.TXT_PRIXESS.Location = New System.Drawing.Point(229, 118)
        Me.TXT_PRIXESS.Name = "TXT_PRIXESS"
        Me.TXT_PRIXESS.Size = New System.Drawing.Size(125, 20)
        Me.TXT_PRIXESS.TabIndex = 2
        '
        'TXT_NBKM
        '
        Me.TXT_NBKM.Location = New System.Drawing.Point(229, 92)
        Me.TXT_NBKM.Name = "TXT_NBKM"
        Me.TXT_NBKM.Size = New System.Drawing.Size(125, 20)
        Me.TXT_NBKM.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Consommation du véhicule (L/100km)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre de kilomètres (km)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Prix du litre d'essence (€/L)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label4.Location = New System.Drawing.Point(64, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 39)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Calcul voyage"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LBL_ERR
        '
        Me.LBL_ERR.AutoSize = True
        Me.LBL_ERR.BackColor = System.Drawing.SystemColors.Menu
        Me.LBL_ERR.Cursor = System.Windows.Forms.Cursors.No
        Me.LBL_ERR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBL_ERR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ERR.ForeColor = System.Drawing.Color.Red
        Me.LBL_ERR.Location = New System.Drawing.Point(30, 152)
        Me.LBL_ERR.Name = "LBL_ERR"
        Me.LBL_ERR.Size = New System.Drawing.Size(311, 16)
        Me.LBL_ERR.TabIndex = 9
        Me.LBL_ERR.Text = "Soyez gentils, n'écrivez pas n'importe quoi.."
        Me.LBL_ERR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_ERR.Visible = False
        '
        'LBL_COUT
        '
        Me.LBL_COUT.AutoSize = True
        Me.LBL_COUT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LBL_COUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_COUT.Location = New System.Drawing.Point(51, 237)
        Me.LBL_COUT.Name = "LBL_COUT"
        Me.LBL_COUT.Size = New System.Drawing.Size(0, 20)
        Me.LBL_COUT.TabIndex = 10
        '
        'CalculVoyage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 277)
        Me.Controls.Add(Me.LBL_COUT)
        Me.Controls.Add(Me.LBL_ERR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_NBKM)
        Me.Controls.Add(Me.TXT_PRIXESS)
        Me.Controls.Add(Me.TXT_CONSOMMATION)
        Me.Controls.Add(Me.BT_CALCUL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CalculVoyage"
        Me.Text = "Calcul voyage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CALCUL As Button
    Friend WithEvents TXT_CONSOMMATION As TextBox
    Friend WithEvents TXT_PRIXESS As TextBox
    Friend WithEvents TXT_NBKM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBL_ERR As Label
    Friend WithEvents LBL_COUT As Label
End Class
