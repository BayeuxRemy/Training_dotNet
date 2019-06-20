Module Module1

    Sub Main()
        'Déclaration des variables
        Dim Choix As String = ""
        Dim ValeurEntree As String = ""
        Dim Valeur1 As Double = 0
        Dim Valeur2 As Double = 0

        'Affichage du menu
        Console.WriteLine("-   Minicalculatrice   -")
        Console.WriteLine("-  Opérations possibles -")
        Console.WriteLine("-     Addition : 'a'    -")
        Console.WriteLine("-   Soustraction : 's'  -")
        Console.WriteLine("-  Multiplication : 'm' -")
        Console.WriteLine("-     Division : 'd'    -")

        Do
            Console.WriteLine("- Faites votre choix :  -")
            'Demande de l'opération
            Choix = Console.ReadLine()
            'Répète l'opération tant que le choix n'est pas valide
        Loop Until Choix = "a" Or Choix = "s" Or Choix = "m" Or Choix = "d"

        'Récupération du premier nombre
        Do
            Console.WriteLine("Entrez la première valeur")
            ValeurEntree = Console.ReadLine()
            'Tourne tant que ce n'est pas un nombre
        Loop Until IsNumeric(ValeurEntree)
        'Écriture de la valeur dans un double
        Valeur1 = ValeurEntree

        'Récupération du second nombre
        Do
            Console.WriteLine("Entrez la seconde valeur")
            ValeurEntree = Console.ReadLine()
            'Tourne tant que ce n'est pas un nombre
        Loop Until IsNumeric(ValeurEntree)
        'Écriture de la valeur dans un double
        Valeur2 = ValeurEntree

        Select Case Choix
            Case "a"
                'Addition
                Console.WriteLine(Valeur1 & " + " & Valeur2 & " = " & Valeur1 + Valeur2)
            Case "s"
                'Soustraction
                Console.WriteLine(Valeur1 & " - " & Valeur2 & " = " & Valeur1 - Valeur2)
            Case "m"
                'Multiplication
                Console.WriteLine(Valeur1 & " x " & Valeur2 & " = " & Valeur1 * Valeur2)
            Case "d"
                'Division
                Console.WriteLine(Valeur1 & " / " & Valeur2 & " = ")
                Console.WriteLine("Valeur exacte : " & Valeur1 / Valeur2)
                Console.WriteLine("Résultat entier : " & Valeur1 \ Valeur2)
                Console.WriteLine("Reste : " & Valeur1 Mod Valeur2)
        End Select

        'Pause factice
        Console.Read()
    End Sub

End Module