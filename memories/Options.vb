Imports System.ComponentModel
Imports System.IO

Public Class Options
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Init_Tools()
    End Sub

    Private Sub Init_Tools()
        'recupere les information depuis l'appli

        CheckBoxTime.Checked = Appli._makeTimer
        CheckBoxPause.Checked = Appli._makePause
        TextBoxTime.Text = Appli._wtime
        TextBoxPath.Text = My.Settings.path
        RadioButtonOn.Checked = Appli._playMusic
        RadioButtonOff.Checked = Not Appli._playMusic
        RadioButtonTheme1.Checked = _theme1
        RadioButtonTheme2.Checked = _theme2

        'initialise les images des themes
        Set_Lbl(lblTh1, My.Resources.dos_carte_1)
        Set_Lbl(lblTh2, My.Resources.dos_carte_2)
    End Sub

    Private Sub Set_Lbl(lbl As Label, img As Image)
        lbl.Size = New Size(img.Width, img.Height)
        lbl.Image = img
        lbl.Text = ""
    End Sub

    Private Sub TextBoxTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxTime.KeyPress
        If e.KeyChar = vbBack Then Exit Sub

        ''une partie ne peut pas durer plus de 1000 seconde (16 min)
        If Not IsNumeric(e.KeyChar) Or Not TextBoxTime.Text.Length < 3 Then e.Handled = True
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click
        If TextBoxTime.Text.Length < 1 Then
            MsgBox("Veuillez renseigner un temps de partie",, "Temps incorrect")
        ElseIf CInt(TextBoxTime.Text) < 5 Then
            MsgBox("Le temps de partie ne peut etre inférieur à 5 secondes",, "Temps incorrect")
        ElseIf TextBoxPath.Text.Length > 0 And Not Directory.Exists(TextBoxPath.Text) Then
            MsgBox("le chemin de sauvegarde n'existe pas ! " & vbCrLf &
                   "Veuillez renseigner un chemin d'acces existant" & vbCrLf &
                   "(vous pouvez aussi ne rien renseigner)",, "Chemin inexistant")
        Else
            My.Settings.path = TextBoxPath.Text 'sauvegarde du chemin donné
            My.Settings.Save()                  '
            MsgBox("Les options ont bien été sauvegardées !",, "Options sauvegardées")
            Accueil.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Form4_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'envoie des informations sur l'etat des options vers l'appli pour les autres formulaires

        Appli._makeTimer = CheckBoxTime.Checked
        Appli._makePause = CheckBoxPause.Checked
        '' si le champ est vide le timer sera par default à 60
        Appli._wtime = If(TextBoxTime.Text = Nothing, 60, CInt(TextBoxTime.Text))
        My.Settings.path = TextBoxPath.Text
    End Sub

    Private Sub RadioButtonOn_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOn.CheckedChanged
        If RadioButtonOn.Checked And Not Appli._playMusic Then
            Play_Music()
            Appli._playMusic = True
        ElseIf Not RadioButtonOn.Checked Then
            Stop_Music()
            Appli._playMusic = False
        End If
    End Sub

    Private Sub RadioButtonTheme1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTheme1.CheckedChanged
        Appli._theme1 = RadioButtonTheme1.Checked
    End Sub

    Private Sub RadioButtonTheme2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTheme2.CheckedChanged
        Appli._theme2 = RadioButtonTheme2.Checked
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dialogResult = FolderBrowserDialog1.ShowDialog()
        If DialogResult.OK Then TextBoxPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
End Class