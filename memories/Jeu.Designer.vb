<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jeu))
        Me.carte_1 = New System.Windows.Forms.Label()
        Me.carte_2 = New System.Windows.Forms.Label()
        Me.carte_3 = New System.Windows.Forms.Label()
        Me.carte_4 = New System.Windows.Forms.Label()
        Me.carte_5 = New System.Windows.Forms.Label()
        Me.Panel_carte = New System.Windows.Forms.Panel()
        Me.carte_20 = New System.Windows.Forms.Label()
        Me.carte_19 = New System.Windows.Forms.Label()
        Me.carte_18 = New System.Windows.Forms.Label()
        Me.carte_17 = New System.Windows.Forms.Label()
        Me.carte_16 = New System.Windows.Forms.Label()
        Me.carte_15 = New System.Windows.Forms.Label()
        Me.carte_14 = New System.Windows.Forms.Label()
        Me.carte_13 = New System.Windows.Forms.Label()
        Me.carte_12 = New System.Windows.Forms.Label()
        Me.carte_11 = New System.Windows.Forms.Label()
        Me.carte_10 = New System.Windows.Forms.Label()
        Me.carte_9 = New System.Windows.Forms.Label()
        Me.carte_8 = New System.Windows.Forms.Label()
        Me.carte_7 = New System.Windows.Forms.Label()
        Me.carte_6 = New System.Windows.Forms.Label()
        Me.nom_joueur = New System.Windows.Forms.Label()
        Me.lblTempRest = New System.Windows.Forms.Label()
        Me.btn_abandon = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblName = New System.Windows.Forms.Label()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.Panel_carte.SuspendLayout()
        Me.SuspendLayout()
        '
        'carte_1
        '
        Me.carte_1.Location = New System.Drawing.Point(27, 18)
        Me.carte_1.Name = "carte_1"
        Me.carte_1.Size = New System.Drawing.Size(52, 17)
        Me.carte_1.TabIndex = 0
        Me.carte_1.Text = "1"
        '
        'carte_2
        '
        Me.carte_2.Location = New System.Drawing.Point(107, 18)
        Me.carte_2.Name = "carte_2"
        Me.carte_2.Size = New System.Drawing.Size(45, 17)
        Me.carte_2.TabIndex = 1
        Me.carte_2.Text = "2"
        '
        'carte_3
        '
        Me.carte_3.Location = New System.Drawing.Point(187, 18)
        Me.carte_3.Name = "carte_3"
        Me.carte_3.Size = New System.Drawing.Size(45, 17)
        Me.carte_3.TabIndex = 2
        Me.carte_3.Text = "3"
        '
        'carte_4
        '
        Me.carte_4.Location = New System.Drawing.Point(267, 18)
        Me.carte_4.Name = "carte_4"
        Me.carte_4.Size = New System.Drawing.Size(45, 17)
        Me.carte_4.TabIndex = 3
        Me.carte_4.Text = "4"
        '
        'carte_5
        '
        Me.carte_5.Location = New System.Drawing.Point(347, 18)
        Me.carte_5.Name = "carte_5"
        Me.carte_5.Size = New System.Drawing.Size(45, 17)
        Me.carte_5.TabIndex = 4
        Me.carte_5.Text = "5"
        '
        'Panel_carte
        '
        Me.Panel_carte.Controls.Add(Me.carte_20)
        Me.Panel_carte.Controls.Add(Me.carte_19)
        Me.Panel_carte.Controls.Add(Me.carte_18)
        Me.Panel_carte.Controls.Add(Me.carte_17)
        Me.Panel_carte.Controls.Add(Me.carte_16)
        Me.Panel_carte.Controls.Add(Me.carte_15)
        Me.Panel_carte.Controls.Add(Me.carte_14)
        Me.Panel_carte.Controls.Add(Me.carte_13)
        Me.Panel_carte.Controls.Add(Me.carte_12)
        Me.Panel_carte.Controls.Add(Me.carte_11)
        Me.Panel_carte.Controls.Add(Me.carte_10)
        Me.Panel_carte.Controls.Add(Me.carte_9)
        Me.Panel_carte.Controls.Add(Me.carte_8)
        Me.Panel_carte.Controls.Add(Me.carte_7)
        Me.Panel_carte.Controls.Add(Me.carte_6)
        Me.Panel_carte.Controls.Add(Me.carte_5)
        Me.Panel_carte.Controls.Add(Me.carte_4)
        Me.Panel_carte.Controls.Add(Me.carte_3)
        Me.Panel_carte.Controls.Add(Me.carte_2)
        Me.Panel_carte.Controls.Add(Me.carte_1)
        Me.Panel_carte.Location = New System.Drawing.Point(58, 156)
        Me.Panel_carte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel_carte.Name = "Panel_carte"
        Me.Panel_carte.Size = New System.Drawing.Size(417, 451)
        Me.Panel_carte.TabIndex = 0
        '
        'carte_20
        '
        Me.carte_20.Location = New System.Drawing.Point(347, 348)
        Me.carte_20.Name = "carte_20"
        Me.carte_20.Size = New System.Drawing.Size(45, 17)
        Me.carte_20.TabIndex = 19
        Me.carte_20.Text = "20"
        '
        'carte_19
        '
        Me.carte_19.Location = New System.Drawing.Point(267, 348)
        Me.carte_19.Name = "carte_19"
        Me.carte_19.Size = New System.Drawing.Size(45, 17)
        Me.carte_19.TabIndex = 18
        Me.carte_19.Text = "19"
        '
        'carte_18
        '
        Me.carte_18.Location = New System.Drawing.Point(187, 348)
        Me.carte_18.Name = "carte_18"
        Me.carte_18.Size = New System.Drawing.Size(45, 17)
        Me.carte_18.TabIndex = 17
        Me.carte_18.Text = "18"
        '
        'carte_17
        '
        Me.carte_17.Location = New System.Drawing.Point(107, 348)
        Me.carte_17.Name = "carte_17"
        Me.carte_17.Size = New System.Drawing.Size(45, 17)
        Me.carte_17.TabIndex = 16
        Me.carte_17.Text = "17"
        '
        'carte_16
        '
        Me.carte_16.Location = New System.Drawing.Point(27, 348)
        Me.carte_16.Name = "carte_16"
        Me.carte_16.Size = New System.Drawing.Size(52, 17)
        Me.carte_16.TabIndex = 15
        Me.carte_16.Text = "16"
        '
        'carte_15
        '
        Me.carte_15.Location = New System.Drawing.Point(347, 238)
        Me.carte_15.Name = "carte_15"
        Me.carte_15.Size = New System.Drawing.Size(45, 17)
        Me.carte_15.TabIndex = 14
        Me.carte_15.Text = "15"
        '
        'carte_14
        '
        Me.carte_14.Location = New System.Drawing.Point(267, 238)
        Me.carte_14.Name = "carte_14"
        Me.carte_14.Size = New System.Drawing.Size(45, 17)
        Me.carte_14.TabIndex = 13
        Me.carte_14.Text = "14"
        '
        'carte_13
        '
        Me.carte_13.Location = New System.Drawing.Point(187, 238)
        Me.carte_13.Name = "carte_13"
        Me.carte_13.Size = New System.Drawing.Size(45, 17)
        Me.carte_13.TabIndex = 12
        Me.carte_13.Text = "13"
        '
        'carte_12
        '
        Me.carte_12.Location = New System.Drawing.Point(107, 238)
        Me.carte_12.Name = "carte_12"
        Me.carte_12.Size = New System.Drawing.Size(45, 17)
        Me.carte_12.TabIndex = 11
        Me.carte_12.Text = "12"
        '
        'carte_11
        '
        Me.carte_11.Location = New System.Drawing.Point(27, 238)
        Me.carte_11.Name = "carte_11"
        Me.carte_11.Size = New System.Drawing.Size(52, 17)
        Me.carte_11.TabIndex = 10
        Me.carte_11.Text = "11"
        '
        'carte_10
        '
        Me.carte_10.Location = New System.Drawing.Point(347, 128)
        Me.carte_10.Name = "carte_10"
        Me.carte_10.Size = New System.Drawing.Size(45, 17)
        Me.carte_10.TabIndex = 9
        Me.carte_10.Text = "10"
        '
        'carte_9
        '
        Me.carte_9.Location = New System.Drawing.Point(267, 128)
        Me.carte_9.Name = "carte_9"
        Me.carte_9.Size = New System.Drawing.Size(45, 17)
        Me.carte_9.TabIndex = 8
        Me.carte_9.Text = "9"
        '
        'carte_8
        '
        Me.carte_8.Location = New System.Drawing.Point(187, 128)
        Me.carte_8.Name = "carte_8"
        Me.carte_8.Size = New System.Drawing.Size(45, 17)
        Me.carte_8.TabIndex = 7
        Me.carte_8.Text = "8"
        '
        'carte_7
        '
        Me.carte_7.Location = New System.Drawing.Point(107, 128)
        Me.carte_7.Name = "carte_7"
        Me.carte_7.Size = New System.Drawing.Size(45, 17)
        Me.carte_7.TabIndex = 6
        Me.carte_7.Text = "7"
        '
        'carte_6
        '
        Me.carte_6.Location = New System.Drawing.Point(27, 128)
        Me.carte_6.Name = "carte_6"
        Me.carte_6.Size = New System.Drawing.Size(52, 17)
        Me.carte_6.TabIndex = 5
        Me.carte_6.Text = "6"
        '
        'nom_joueur
        '
        Me.nom_joueur.AutoSize = True
        Me.nom_joueur.Font = New System.Drawing.Font("Comfortaa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_joueur.Location = New System.Drawing.Point(11, 23)
        Me.nom_joueur.Name = "nom_joueur"
        Me.nom_joueur.Size = New System.Drawing.Size(85, 25)
        Me.nom_joueur.TabIndex = 1
        Me.nom_joueur.Text = "Joueur : "
        '
        'lblTempRest
        '
        Me.lblTempRest.AutoSize = True
        Me.lblTempRest.Font = New System.Drawing.Font("Comfortaa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempRest.Location = New System.Drawing.Point(153, 123)
        Me.lblTempRest.Name = "lblTempRest"
        Me.lblTempRest.Size = New System.Drawing.Size(163, 29)
        Me.lblTempRest.TabIndex = 2
        Me.lblTempRest.Text = "Temps restant :"
        '
        'btn_abandon
        '
        Me.btn_abandon.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_abandon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_abandon.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_abandon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btn_abandon.Location = New System.Drawing.Point(408, 11)
        Me.btn_abandon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_abandon.Name = "btn_abandon"
        Me.btn_abandon.Size = New System.Drawing.Size(127, 73)
        Me.btn_abandon.TabIndex = 3
        Me.btn_abandon.Text = "Abandon"
        Me.btn_abandon.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Comfortaa", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(340, 123)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(56, 29)
        Me.lblTimer.TabIndex = 4
        Me.lblTimer.Text = "time"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Comfortaa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(102, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 23)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'ButtonPause
        '
        Me.ButtonPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPause.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ButtonPause.Location = New System.Drawing.Point(249, 23)
        Me.ButtonPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(123, 44)
        Me.ButtonPause.TabIndex = 6
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(555, 630)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btn_abandon)
        Me.Controls.Add(Me.lblTempRest)
        Me.Controls.Add(Me.nom_joueur)
        Me.Controls.Add(Me.Panel_carte)
        Me.Font = New System.Drawing.Font("Comfortaa", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Game - Jeu"
        Me.Panel_carte.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents carte_1 As Label
    Friend WithEvents carte_2 As Label
    Friend WithEvents carte_3 As Label
    Friend WithEvents carte_4 As Label
    Friend WithEvents carte_5 As Label
    Friend WithEvents Panel_carte As Panel
    Friend WithEvents nom_joueur As Label
    Friend WithEvents lblTempRest As Label
    Friend WithEvents btn_abandon As Button
    Friend WithEvents carte_10 As Label
    Friend WithEvents carte_9 As Label
    Friend WithEvents carte_8 As Label
    Friend WithEvents carte_7 As Label
    Friend WithEvents carte_6 As Label
    Friend WithEvents carte_15 As Label
    Friend WithEvents carte_14 As Label
    Friend WithEvents carte_13 As Label
    Friend WithEvents carte_12 As Label
    Friend WithEvents carte_11 As Label
    Friend WithEvents carte_20 As Label
    Friend WithEvents carte_19 As Label
    Friend WithEvents carte_18 As Label
    Friend WithEvents carte_17 As Label
    Friend WithEvents carte_16 As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents lblName As Label
    Friend WithEvents ButtonPause As Button
End Class
