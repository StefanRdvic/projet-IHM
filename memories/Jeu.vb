Imports System.Threading

Public Class Jeu
    ''----constantes----
    Const _nbTypeCartes As Integer = 5
    Const _nbCartesByType As Integer = 4
    Const _nbTotalCartes As Integer = 20

    ''les images sont plus facilement accessible dans un tableau
    Dim _imgCarte(_nbTypeCartes) As Image, _DosCarte As Image

    ''----initialisation des cartes----
    Dim _rand As New Random()
    ''lorsque un element atteint 4 <nbCartesByType> la limite a été atteinte
    Dim _tagsOccurences() As Integer, _foundCard() As Boolean

    ''----Timer----
    Dim _time As Integer
    Dim _timeElapsed
    Dim _firstClick As Boolean
    Dim _recordTime As Integer

    ''----verification----
    Dim _cartePrec As Label
    Dim _cpt As Integer, _score As Integer, _saveScore As Integer   'sauvegarde

    ''----Pause----
    Dim _Pause As Boolean

    ''---------Load---------
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Init_Var()
        Init_Tools()
        Manage_Event()
        If Appli._theme1 Then Set_Images_Theme1()
        If Appli._theme2 Then Set_Images_Theme2()
        Init_Panel()
    End Sub

    ''---------INITIALISATION---------
    Private Sub Init_Var()
        _firstClick = True
        _tagsOccurences = {0, 0, 0, 0, 0}
        _foundCard = {False, False, False, False, False}
        _time = Appli._wtime
        _timeElapsed = 0
        _cpt = 0
        _score = 0
        _Pause = True
    End Sub

    Private Sub Init_Tools()
        ButtonPause.Visible = Appli._makePause
        lblName.Text = Appli._name
        If Appli._makeTimer Then
            lblTempRest.Text = "Temps restant"
            lblTimer.Text = _time \ 60 & " : " & _time Mod 60
        Else
            lblTempRest.Text = "Temps écoulé"
            lblTimer.Text = _timeElapsed \ 60 & " : " & _timeElapsed Mod 60
        End If
    End Sub

    Private Sub Set_Images_Theme1()
        _imgCarte(0) = My.Resources.carte_1
        _imgCarte(1) = My.Resources.carte_2
        _imgCarte(2) = My.Resources.carte_3
        _imgCarte(3) = My.Resources.carte_4
        _imgCarte(4) = My.Resources.carte_5
        _DosCarte = My.Resources.dos_carte_1
    End Sub

    Private Sub Set_Images_Theme2()
        _imgCarte(0) = My.Resources.carte_6
        _imgCarte(1) = My.Resources.carte_7
        _imgCarte(2) = My.Resources.carte_8
        _imgCarte(3) = My.Resources.carte_9
        _imgCarte(4) = My.Resources.carte_10
        _DosCarte = My.Resources.dos_carte_2
    End Sub

    Private Sub Init_Panel()
        For Each lbl As Label In Panel_carte.Controls
            lbl.Size = New Size(_DosCarte.Width, _DosCarte.Height)  'la taille restera la meme pour toutes les cartes
            lbl.Image = _DosCarte
            lbl.Tag = Get_Rand_Tag()
            lbl.Text = ""
        Next
    End Sub

    Private Function Get_Rand_Tag() As Integer
        Dim idx As Integer = _rand.Next(0, 5)
        While _tagsOccurences(idx) >= _nbCartesByType ''generation au dela de la limite
            idx = _rand.Next(0, 5)
        End While
        _tagsOccurences(idx) += 1
        Return idx
    End Function
    ''----------------------------------

    ''---------Timer---------
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Appli._makeTimer Then
            _time = _time - 1
            _timeElapsed += 1
            lblTimer.Text = _time \ 60 & " : " & _time Mod 60
        Else
            _timeElapsed += 1
            lblTimer.Text = _timeElapsed \ 60 & " : " & _timeElapsed Mod 60
        End If
        If _time <= 0 Then
            Timer.Stop()
            End_Game("C'est fini vous avez trouvé : " & _score \ 4 &
                     " carré" & If(_score \ 4 > 1, "s", ""))
        End If
    End Sub
    ''---------------------------

    ''---------Gestion des regles et du jeu---------
    Private Sub Manage_Event()
        For Each lbl As Label In Panel_carte.Controls
            AddHandler lbl.Click, AddressOf Cartes_Click
        Next
    End Sub

    Private Sub Cartes_Click(sender As Object, e As EventArgs)
        If _firstClick Then
            Timer.Start()
            _firstClick = False
        End If

        If Not sender.Image.Equals(_DosCarte) Then Exit Sub

        sender.Image = _imgCarte(sender.Tag)
        _cpt += 1

        If Not Is_Click_Right(sender) Then
            sleep(800)
            Flip_Cards_Back()   ''decremente le compteur egalement
            Exit Sub
        End If

        If _cpt Mod 4 = 0 Then
            sleep(200)
            _foundCard(sender.Tag) = True
            Disable_Found_Cards()
            _recordTime = _timeElapsed
        End If

        If _cpt >= _nbTotalCartes Then End_Game("Bravo, vous avez fini le jeu !")

        _cartePrec = sender
    End Sub

    Private Function Is_Click_Right(lbl As Label) As Boolean
        ''la verification entre 2 cartes n'a pas lieu lorsque c'est un premier click
        Return (_cpt Mod 4 = 1 And lbl.Enabled) OrElse Not lbl.Equals(_cartePrec) And lbl.Tag.Equals(_cartePrec.Tag)
    End Function

    Private Sub Flip_Cards_Back()
        For Each lbl As Label In Panel_carte.Controls
            If Not lbl.Image.Equals(_DosCarte) And lbl.Enabled Then
                lbl.Image = _DosCarte
                _cpt -= 1
            End If
        Next
    End Sub

    Private Sub Disable_Found_Cards()
        For Each lbl As Label In Panel_carte.Controls
            If _foundCard(lbl.Tag) And Not lbl.Image.Equals(_DosCarte) And lbl.Enabled Then
                lbl.Enabled = False
                _score += 1
            End If
        Next
    End Sub

    Private Sub sleep(ms As Integer)
        Application.DoEvents()
        Thread.Sleep(ms)
    End Sub

    Private Sub End_Game(message As String)
        Timer.Stop()
        Update_Joueur(lblName.Text, If(_score = 0, _timeElapsed, _recordTime), _score, _timeElapsed)
        MsgBox(message, , "Fin de partie")
        Accueil.Show()
        Me.Close()
    End Sub
    ''----------------------------------------------------------

    ''--------------boutton----------------------
    Private Sub btn_abandon_Click(sender As Object, e As EventArgs) Handles btn_abandon.Click
        Dim rep = MsgBox("Confimer l'abandon ?", vbYesNo, "Abandon")
        If rep = vbYes Then End_Game("Vous abandonnez la partie.")
    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        If _Pause Then
            Timer.Stop()
            Enable_All_Cards(False)
            _saveScore = _score
            _Pause = False
        Else
            Timer.Start()
            Enable_All_Cards(True)
            Disable_Found_Cards()   ''les cartes deja trouvés sont toujours desactivées
            _Pause = True
            _score = _saveScore
        End If
    End Sub

    Private Sub Enable_All_Cards(mode As Boolean)
        For Each lbl As Label In Panel_carte.Controls
            lbl.Enabled = mode
        Next
    End Sub
    ''----------------------------------------------------------

End Class