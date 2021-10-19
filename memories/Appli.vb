Imports System.IO

Module Appli
    ''---------Variable de passage entre fomulaire---------
    Public _name As String  ''form1 -> form2
    Public _makeTimer As Boolean    ''option
    Public _wtime As Integer        ''option
    Public _makePause As Boolean    ''option
    Public _playMusic As Boolean    ''option
    Public _theme1 As Boolean       ''option    
    Public _theme2 As Boolean       ''option    

    ''--------------Option--------------------
    Public Sub Play_Music()
        My.Computer.Audio.Play(My.Resources.musique, AudioPlayMode.BackgroundLoop)
    End Sub

    Public Sub Stop_Music()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Init_Option()
        _read = New StreamReader(_path)
        If _read.Peek = -1 Then
            Set_Option()
        Else
            Dim Split() As String = Strings.Split(_read.ReadLine, "/")
            Set_Option(Split(0).Equals("True"),
                       CInt(Split(1)),
                       Split(2).Equals("True"),
                       Split(3).Equals("True"),
                       Split(4).Equals("True"),
                       Split(5).Equals("True"))
        End If
        If _playMusic Then Play_Music()
    End Sub

    Private Sub Set_Option(mT As Boolean, wT As Integer, mP As Boolean,
                           pM As Boolean, tH1 As Boolean, th2 As Boolean)
        _makeTimer = mT
        _wtime = wT
        _makePause = mP
        _playMusic = pM
        _theme1 = tH1
        _theme2 = th2
    End Sub

    Private Sub Set_Option()
        Set_Option(True, 60, False, True, True, False)   ''Option par defaut (premier demarrage)
    End Sub

    Private Function Option_ToString() As String
        Return _makeTimer.ToString & "/" &
            _wtime & "/" &
            _makePause.ToString & "/" &
            _playMusic.ToString & "/" &
            _theme1.ToString & "/" &
            _theme2.ToString
    End Function
    ''---------------------------------------

    ''------------------gestion des joueurs------------------
    Structure Joueur
        Dim name As String
        Dim bestTime As Integer
        Dim bestScore As Integer
        Dim nbPlayedGame As Integer
        Dim totalTime As Integer
    End Structure

    Public tabJoueurs(2) As Joueur  'reconsitue le fichier .txt en un tableau de joueur manipulable
    Public nbJoueur As Integer

    ''--------------flux de lecture et d'ecriture------------------------
    Const _File As String = "sauvegarde.txt"    'nom du fichier de sauvegarde
    Dim _path As String 'chemin d'acces
    Dim _write As StreamWriter
    Dim _read As StreamReader
    ''---------------set path---------------
    Private Sub Set_Path()
        Dim settingsPath As String = My.Settings.path

        'si le repertoire n'existe pas, c'est le rep par defaut
        _path = If(Directory.Exists(settingsPath), settingsPath & "\" & _File, _File)
    End Sub

    ''---------------utils--------------------------
    Private Function Joueur_toString(n As String, bT As Integer, bS As Integer, nb As Integer, tT As Integer) As String
        Return n & "/" & bT & "/" & bS & "/" & nb & "/" & tT
    End Function

    Private Sub Set_Row(idx As Integer, n As String, bT As Integer, bS As Integer, nb As Integer, tT As Integer)
        tabJoueurs(idx).name = n
        tabJoueurs(idx).bestTime = bT
        tabJoueurs(idx).bestScore = bS
        tabJoueurs(idx).nbPlayedGame = nb
        tabJoueurs(idx).totalTime = tT
    End Sub

    Private Sub Set_Row(str As String)  'a partir d'une chaine de caractere (le .txt)
        Dim split() As String = Strings.Split(str, "/")
        Set_Row(nbJoueur, split(0), CInt(split(1)), CInt(split(2)), CInt(split(3)), CInt(split(4)))
    End Sub

    Private Sub Add_Joueur(str As String)
        If nbJoueur = tabJoueurs.Length Then
            ReDim Preserve tabJoueurs(tabJoueurs.Length + 2)    ''ajout dynamique avec un pas de 2
        End If
        Set_Row(str)
        nbJoueur += 1
    End Sub

    Public Sub Update_Joueur(n As String, recTime As Integer, score As Integer, timeElaped As Integer)
        Dim idx As Integer = Get_Idx_By_Name(n)
        If idx = -1 Then    'si le joueur n'existe pas
            Add_Joueur(Joueur_toString(n, recTime, score, 1, timeElaped))
        Else
            If Is_Updatable(idx, recTime, score) Then
                tabJoueurs(idx).bestTime = recTime
                tabJoueurs(idx).bestScore = score
            End If
            tabJoueurs(idx).nbPlayedGame += 1
            tabJoueurs(idx).totalTime += timeElaped
        End If
    End Sub

    'renvoie si le score effectué est meilleur que le score precedent
    Private Function Is_Updatable(idx As Integer, time As Integer, score As Integer) As Boolean
        If tabJoueurs(idx).bestScore < score Then Return True

        Return tabJoueurs(idx).bestScore = score AndAlso tabJoueurs(idx).bestTime > time
    End Function

    'recherche un joueur en fonction de son nom dans un tableau
    Public Function Get_Idx_By_Name(name As String) As Integer
        For i = 0 To nbJoueur - 1
            If tabJoueurs(i).name.Equals(name) Then Return i
        Next
        Return -1
    End Function
    ''-------------------------------------------------

    ''-------lecture-------
    Private Sub Init_File()
        Set_Path()  ''initialisation du chemin
        ''le fichier est crée s'il n'existe pas dans le repertoire sur chemin
        If Not System.IO.File.Exists(_path) Then
            System.IO.File.Create(_path).Dispose()
        End If
    End Sub

    Private Sub Init_TabJoueurs()
        ' le flux de lecture est deja ouvert dans Init_Option()
        ' on le ferme apres avoir lu tout les joueurs du txt
        Do While _read.Peek() >= 0
            Add_Joueur(_read.ReadLine)
        Loop
        _read.Close()
    End Sub
    ''----------------------------

    ''-------ecriture, une fois l'application fermée------- 
    Public Sub Write_Score()
        Init_File() '' le fichier est crée si le chemin a été changer dans les options

        System.IO.File.WriteAllText(_path, "") ''le txt est clear pour reconstituer le tableau vers le txt

        _write = New StreamWriter(_path, True)

        _write.WriteLine(Option_ToString())  ''sauvegarde des options en premiere ligne

        Dim j As Joueur
        For i = 0 To nbJoueur - 1
            j = tabJoueurs(i)
            _write.WriteLine(Joueur_toString(j.name, j.bestTime, j.bestScore, j.nbPlayedGame, j.totalTime))
        Next
        _write.Close()
    End Sub
    ''----------------------------

    ''----------------------Main----------------------
    Sub main()
        Init_File()
        Init_Option()
        Init_TabJoueurs()
        Application.Run(Accueil)
        Write_Score()
    End Sub
End Module
