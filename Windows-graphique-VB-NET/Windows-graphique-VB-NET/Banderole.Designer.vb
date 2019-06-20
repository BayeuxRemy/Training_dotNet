<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banderole
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
        Me.components = New System.ComponentModel.Container()
        Me.RB_1 = New System.Windows.Forms.RadioButton()
        Me.RB_2 = New System.Windows.Forms.RadioButton()
        Me.RB_3 = New System.Windows.Forms.RadioButton()
        Me.RB_4 = New System.Windows.Forms.RadioButton()
        Me.RB_5 = New System.Windows.Forms.RadioButton()
        Me.RB_6 = New System.Windows.Forms.RadioButton()
        Me.RB_7 = New System.Windows.Forms.RadioButton()
        Me.RB_8 = New System.Windows.Forms.RadioButton()
        Me.RB_10 = New System.Windows.Forms.RadioButton()
        Me.BT_PLAY = New System.Windows.Forms.Button()
        Me.BT_STOP = New System.Windows.Forms.Button()
        Me.TKB_VIT = New System.Windows.Forms.TrackBar()
        Me.RB_9 = New System.Windows.Forms.RadioButton()
        Me.TIM_TIM = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TKB_VIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RB_1
        '
        Me.RB_1.AutoSize = True
        Me.RB_1.BackColor = System.Drawing.SystemColors.Control
        Me.RB_1.ForeColor = System.Drawing.Color.Red
        Me.RB_1.Location = New System.Drawing.Point(13, 10)
        Me.RB_1.Name = "RB_1"
        Me.RB_1.Size = New System.Drawing.Size(14, 13)
        Me.RB_1.TabIndex = 1
        Me.RB_1.TabStop = True
        Me.RB_1.UseVisualStyleBackColor = False
        '
        'RB_2
        '
        Me.RB_2.AutoSize = True
        Me.RB_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RB_2.Location = New System.Drawing.Point(33, 10)
        Me.RB_2.Name = "RB_2"
        Me.RB_2.Size = New System.Drawing.Size(14, 13)
        Me.RB_2.TabIndex = 2
        Me.RB_2.TabStop = True
        Me.RB_2.UseVisualStyleBackColor = True
        '
        'RB_3
        '
        Me.RB_3.AutoSize = True
        Me.RB_3.ForeColor = System.Drawing.Color.Yellow
        Me.RB_3.Location = New System.Drawing.Point(53, 10)
        Me.RB_3.Name = "RB_3"
        Me.RB_3.Size = New System.Drawing.Size(14, 13)
        Me.RB_3.TabIndex = 3
        Me.RB_3.TabStop = True
        Me.RB_3.UseVisualStyleBackColor = True
        '
        'RB_4
        '
        Me.RB_4.AutoSize = True
        Me.RB_4.ForeColor = System.Drawing.Color.Lime
        Me.RB_4.Location = New System.Drawing.Point(73, 10)
        Me.RB_4.Name = "RB_4"
        Me.RB_4.Size = New System.Drawing.Size(14, 13)
        Me.RB_4.TabIndex = 4
        Me.RB_4.TabStop = True
        Me.RB_4.UseVisualStyleBackColor = True
        '
        'RB_5
        '
        Me.RB_5.AutoSize = True
        Me.RB_5.ForeColor = System.Drawing.Color.Cyan
        Me.RB_5.Location = New System.Drawing.Point(93, 10)
        Me.RB_5.Name = "RB_5"
        Me.RB_5.Size = New System.Drawing.Size(14, 13)
        Me.RB_5.TabIndex = 5
        Me.RB_5.TabStop = True
        Me.RB_5.UseVisualStyleBackColor = True
        '
        'RB_6
        '
        Me.RB_6.AutoSize = True
        Me.RB_6.ForeColor = System.Drawing.Color.Blue
        Me.RB_6.Location = New System.Drawing.Point(113, 10)
        Me.RB_6.Name = "RB_6"
        Me.RB_6.Size = New System.Drawing.Size(14, 13)
        Me.RB_6.TabIndex = 6
        Me.RB_6.TabStop = True
        Me.RB_6.UseVisualStyleBackColor = True
        '
        'RB_7
        '
        Me.RB_7.AutoSize = True
        Me.RB_7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RB_7.Location = New System.Drawing.Point(133, 10)
        Me.RB_7.Name = "RB_7"
        Me.RB_7.Size = New System.Drawing.Size(14, 13)
        Me.RB_7.TabIndex = 7
        Me.RB_7.TabStop = True
        Me.RB_7.UseVisualStyleBackColor = True
        '
        'RB_8
        '
        Me.RB_8.AutoSize = True
        Me.RB_8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RB_8.Location = New System.Drawing.Point(153, 10)
        Me.RB_8.Name = "RB_8"
        Me.RB_8.Size = New System.Drawing.Size(14, 13)
        Me.RB_8.TabIndex = 8
        Me.RB_8.TabStop = True
        Me.RB_8.UseVisualStyleBackColor = True
        '
        'RB_10
        '
        Me.RB_10.AutoSize = True
        Me.RB_10.Location = New System.Drawing.Point(193, 10)
        Me.RB_10.Name = "RB_10"
        Me.RB_10.Size = New System.Drawing.Size(14, 13)
        Me.RB_10.TabIndex = 9
        Me.RB_10.TabStop = True
        Me.RB_10.UseVisualStyleBackColor = True
        '
        'BT_PLAY
        '
        Me.BT_PLAY.Location = New System.Drawing.Point(13, 29)
        Me.BT_PLAY.Name = "BT_PLAY"
        Me.BT_PLAY.Size = New System.Drawing.Size(91, 23)
        Me.BT_PLAY.TabIndex = 10
        Me.BT_PLAY.Text = "Play"
        Me.BT_PLAY.UseVisualStyleBackColor = True
        '
        'BT_STOP
        '
        Me.BT_STOP.Location = New System.Drawing.Point(110, 29)
        Me.BT_STOP.Name = "BT_STOP"
        Me.BT_STOP.Size = New System.Drawing.Size(97, 23)
        Me.BT_STOP.TabIndex = 11
        Me.BT_STOP.Text = "Stop"
        Me.BT_STOP.UseVisualStyleBackColor = True
        '
        'TKB_VIT
        '
        Me.TKB_VIT.Location = New System.Drawing.Point(12, 58)
        Me.TKB_VIT.Name = "TKB_VIT"
        Me.TKB_VIT.Size = New System.Drawing.Size(194, 45)
        Me.TKB_VIT.TabIndex = 12
        '
        'RB_9
        '
        Me.RB_9.AutoSize = True
        Me.RB_9.ForeColor = System.Drawing.Color.Silver
        Me.RB_9.Location = New System.Drawing.Point(173, 10)
        Me.RB_9.Name = "RB_9"
        Me.RB_9.Size = New System.Drawing.Size(14, 13)
        Me.RB_9.TabIndex = 13
        Me.RB_9.TabStop = True
        Me.RB_9.UseVisualStyleBackColor = True
        '
        'TIM_TIM
        '
        '
        'Banderole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(212, 93)
        Me.Controls.Add(Me.RB_9)
        Me.Controls.Add(Me.TKB_VIT)
        Me.Controls.Add(Me.BT_STOP)
        Me.Controls.Add(Me.BT_PLAY)
        Me.Controls.Add(Me.RB_10)
        Me.Controls.Add(Me.RB_8)
        Me.Controls.Add(Me.RB_7)
        Me.Controls.Add(Me.RB_6)
        Me.Controls.Add(Me.RB_5)
        Me.Controls.Add(Me.RB_4)
        Me.Controls.Add(Me.RB_3)
        Me.Controls.Add(Me.RB_2)
        Me.Controls.Add(Me.RB_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Banderole"
        Me.Text = "Banderole"
        CType(Me.TKB_VIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RB_1 As RadioButton
    Friend WithEvents RB_2 As RadioButton
    Friend WithEvents RB_3 As RadioButton
    Friend WithEvents RB_4 As RadioButton
    Friend WithEvents RB_5 As RadioButton
    Friend WithEvents RB_6 As RadioButton
    Friend WithEvents RB_7 As RadioButton
    Friend WithEvents RB_8 As RadioButton
    Friend WithEvents RB_10 As RadioButton
    Friend WithEvents BT_PLAY As Button
    Friend WithEvents BT_STOP As Button
    Friend WithEvents TKB_VIT As TrackBar
    Friend WithEvents RB_9 As RadioButton
    Friend WithEvents TIM_TIM As Timer
End Class
