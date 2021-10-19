Public Class Accueil
    Dim showRule As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelRule.Visible = False
        Init_ComboBox()
        btn_jouer.Enabled = False
    End Sub

    Private Sub Init_ComboBox()
        For i = 0 To Appli.nbJoueur - 1
            ComboBox_name.Items.Add(Appli.tabJoueurs(i).name)   'utilise les noms des anciens joueur recuperer dans tabJoueurs
        Next
    End Sub

    Private Sub ComboBox_name_TextChanged(sender As Object, e As EventArgs) Handles ComboBox_name.TextChanged
        If Trim(ComboBox_name.Text).Length > 2 Then
            btn_jouer.Enabled = True
            btn_jouer.BackColor = Color.FromArgb(144, 12, 63)
            btn_jouer.ForeColor = Color.FromArgb(178, 186, 187)
        Else
            btn_jouer.Enabled = False
            btn_jouer.BackColor = Color.FromArgb(66, 73, 73)
        End If
    End Sub

    Private Sub ComboBox_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox_name.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        ''les nom sont limités à 10 caracteres
        If Not ComboBox_name.Text.Length <= 10 Then e.Handled = True
    End Sub

    Private Sub btn_score_Click(sender As Object, e As EventArgs) Handles btn_score.Click
        Me.Hide()
        Score.Show()
    End Sub

    Private Sub btn_options_Click(sender As Object, e As EventArgs) Handles btn_options.Click
        Me.Hide()
        Options.Show()
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Dim rep = MsgBox("Voulez vous quitter l'application ?", vbYesNo, "Quitter l'application")
        If rep = vbYes Then Me.Close()
    End Sub

    Private Sub btn_jouer_Click(sender As Object, e As EventArgs) Handles btn_jouer.Click
        If Not ComboBox_name.Items.Contains(ComboBox_name.Text) Then '' l'ajout s'effectue si c'est un nouveau joueur
            ComboBox_name.Items.Add(ComboBox_name.Text)
        End If
        Appli._name = ComboBox_name.Text
        Me.Hide()
        Jeu.Show()
    End Sub

    Private Sub ButtonRule_Click(sender As Object, e As EventArgs) Handles ButtonRule.Click
        If showRule Then
            LabelRule.Visible = True
            showRule = False
        Else
            LabelRule.Visible = False
            showRule = True
        End If
    End Sub
End Class
