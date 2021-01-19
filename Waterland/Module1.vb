Imports System.Threading
Imports System
Imports System.Speech.Synthesis

Module Module1
    Dim players As Integer = Nothing
    Dim cash As Integer
    Dim moreCash As List(Of Integer) = New List(Of Integer)
    Dim glassesa As List(Of Integer) = New List(Of Integer)
    Dim signsa As List(Of Integer) = New List(Of Integer)
    Dim pricea As List(Of Integer) = New List(Of Integer)
    Sub Main()
        Console.SetWindowSize(55, 18)
        Console.Title = "Waterland"
        Console.CursorSize = 100
        Console.WriteLine("King: Welcome to water land!")
        Console.WriteLine("King: But there isn't any water here!")
        Console.WriteLine("King: Please find some water and sell it!")
        Console.WriteLine("You: Okay, why not! I brought water ")
        Console.WriteLine("with me for this vacation!")
        Console.WriteLine("")
        Console.WriteLine("King: How much people are with you?")
        Console.WriteLine("Strike a key to continue...")
        Console.ReadKey()
        Console.Clear()
        Console.WriteLine("Enter amount of players... (Max. 129)")
        Dim plrs = Console.ReadLine
        If Integer.TryParse(plrs, 1) Then

            If Integer.Parse(plrs) <= 129 Then

                players = Integer.Parse(plrs)

            Else

                Console.Clear()
                Main()

            End If
        Else

            Console.Clear()
            Main()

        End If
        If players = 1 Then
            Console.WriteLine("King: Okay, so you're lonely. Lets begin!")
            Console.ReadKey()
        ElseIf players = 69 Then
            Console.WriteLine("King: Okay, so, we are doing this for the memes?")
            Console.ReadKey()
            Console.Clear()
            Main()
        Else
            Console.WriteLine("King: Okay! " & players & " people it is. ")
            Console.WriteLine("kign: The person who earns the most money in 20 rounds. ")
            Console.WriteLine("Wins my crown.")
            For u As Integer = 0 To players - 1
                moreCash.Add(0)
            Next
            Console.ReadKey()
        End If
        Weather()

    End Sub
    Sub Weather()
        Dim gameDifficultyManager As New Random
        Dim diff As Integer = gameDifficultyManager.Next(1, 5)
        If diff = 1 Then
            Console.BackgroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine("    █████")
            Console.WriteLine("    █████")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("              █████████████████")
            Console.Write("              ██")
            Console.ForegroundColor = ConsoleColor.Black
            Console.Write("█████████████")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("██")
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.Write("              ██ ")
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.Write("██  ██  ██ ")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.Write(" ██")
            Console.WriteLine()
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              █████████████████")
            Thread.Sleep(1500)
            Console.Beep(264, 125)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(125)
            Console.Beep(297, 500)
            Thread.Sleep(125)
            Console.Beep(264, 500)
            Thread.Sleep(125)
            Console.Beep(352, 500)
            Thread.Sleep(125)
            Console.Beep(330, 1000)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(125)
            Console.Beep(297, 500)
            Thread.Sleep(125)
            Console.Beep(264, 500)
            Thread.Sleep(125)
            Console.Beep(396, 500)
            Thread.Sleep(125)
            Console.Beep(352, 1000)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(125)
            Console.Beep(440, 500)
            Thread.Sleep(125)
            Console.Beep(352, 250)
            Thread.Sleep(125)
            Console.Beep(352, 125)
            Thread.Sleep(125)
            Console.Beep(330, 500)
            Thread.Sleep(125)
            Console.Beep(297, 1000)
            Thread.Sleep(250)
            Console.Beep(466, 125)
            Thread.Sleep(250)
            Console.Beep(466, 125)
            Thread.Sleep(125)
            Console.Beep(440, 500)
            Thread.Sleep(125)
            Console.Beep(352, 500)
            Thread.Sleep(125)
            Console.Beep(396, 500)
            Thread.Sleep(125)
            Console.Beep(352, 1000)
            Console.ResetColor()
            Dim synth As SpeechSynthesizer = New SpeechSynthesizer()
            synth.SetOutputToDefaultAudioDevice()
            synth.Speak("Sunny")
            Console.WriteLine("Press a key to continue")
            Console.ReadKey()

            Game(diff)
        End If
        If diff = 2 Then
            Console.BackgroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("    █████           █████         ")
            Console.WriteLine(" ██████████     ██████████              ")
            Console.WriteLine()
            Console.WriteLine("            █████")
            Console.WriteLine("         ██████████")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("              █████████████████")
            Console.Write("              ██")
            Console.ForegroundColor = ConsoleColor.Black
            Console.Write("█████████████")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("██")
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.Write("              ██ ")
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.Write("██  ██  ██ ")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.Write(" ██")
            Console.WriteLine()
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              █████████████████")
            Thread.Sleep(1500)
            Console.Beep(264, 125)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(125)
            Console.Beep(297, 500)
            Thread.Sleep(125)
            Console.Beep(264, 500)
            Thread.Sleep(125)
            Console.Beep(352, 500)
            Thread.Sleep(125)
            Console.Beep(330, 1000)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(125)
            Console.Beep(297, 500)
            Thread.Sleep(125)
            Console.Beep(264, 500)
            Thread.Sleep(125)
            Console.Beep(396, 500)
            Thread.Sleep(125)
            Console.Beep(352, 1000)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(250)
            Console.Beep(264, 125)
            Thread.Sleep(125)
            Console.Beep(440, 500)
            Thread.Sleep(125)
            Console.Beep(352, 250)
            Thread.Sleep(125)
            Console.Beep(352, 125)
            Thread.Sleep(125)
            Console.Beep(330, 500)
            Thread.Sleep(125)
            Console.Beep(297, 1000)
            Thread.Sleep(250)
            Console.Beep(466, 125)
            Thread.Sleep(250)
            Console.Beep(466, 125)
            Thread.Sleep(125)
            Console.Beep(440, 500)
            Thread.Sleep(125)
            Console.Beep(352, 500)
            Thread.Sleep(125)
            Console.Beep(396, 500)
            Thread.Sleep(125)
            Console.Beep(352, 1000)
            Console.ResetColor()
            Dim synth As SpeechSynthesizer = New SpeechSynthesizer()
            synth.SetOutputToDefaultAudioDevice()
            synth.Speak("Cloudy")
            Console.WriteLine("Press a key to continue")
            Console.ReadKey()

            Game(diff)
        End If
        If diff = 3 Then
            Console.BackgroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Gray
            Console.WriteLine()
            Console.WriteLine("            █████")
            Console.WriteLine("         ██████████")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("            ██")
            Console.WriteLine("              ██")
            Console.WriteLine("            ██")
            Console.WriteLine("          ██")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("              █████████████████")
            Console.Write("              ██")
            Console.ForegroundColor = ConsoleColor.Black
            Console.Write("█████████████")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("██")
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.Write("              ██ ")
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.Write("██  ██  ██ ")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.Write(" ██")
            Console.WriteLine()
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              █████████████████")
            Thread.Sleep(1500)
            Dim Mary As Note() = {New Note(Tone.B, Duration.QUARTER), New Note(Tone.A, Duration.QUARTER), New Note(Tone.GbelowC, Duration.QUARTER), New Note(Tone.A, Duration.QUARTER), New Note(Tone.B, Duration.QUARTER), New Note(Tone.B, Duration.QUARTER), New Note(Tone.B, Duration.HALF), New Note(Tone.A, Duration.QUARTER), New Note(Tone.A, Duration.QUARTER), New Note(Tone.A, Duration.HALF), New Note(Tone.B, Duration.QUARTER), New Note(Tone.D, Duration.QUARTER), New Note(Tone.D, Duration.HALF)}
            Play(Mary)
            Console.ResetColor()
            Dim synth As SpeechSynthesizer = New SpeechSynthesizer()
            synth.SetOutputToDefaultAudioDevice()
            synth.Speak("Thunder")
            Console.WriteLine("Press a key to continue")
            Console.ReadKey()

            Game(diff)
        End If
        If diff = 4 Then
            Console.BackgroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkYellow
            Console.WriteLine("    ███████")
            Console.WriteLine("    ███████")
            Console.WriteLine("    ███████")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("              █████████████████")
            Console.Write("              ██")
            Console.ForegroundColor = ConsoleColor.Black
            Console.Write("█████████████")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.WriteLine("██")
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.WriteLine("              ██             ██")
            Console.Write("              ██ ")
            Console.ForegroundColor = ConsoleColor.DarkBlue
            Console.Write("██  ██  ██ ")
            Console.ForegroundColor = ConsoleColor.DarkGray
            Console.Write(" ██")
            Console.WriteLine()
            Console.WriteLine("              █████████████████")
            Console.WriteLine("              █████████████████")
            Thread.Sleep(1500)
            Console.Beep(1000, 500)
            Console.Beep(670, 250)
            Console.Beep(736, 250)
            Console.Beep(700, 250)
            Console.Beep(1000, 125)
            Console.Beep(736, 125)
            Console.Beep(700, 250)
            Console.Beep(670, 250)
            Console.Beep(500, 500)
            Console.Beep(500, 250)
            Console.Beep(736, 250)
            Console.Beep(1000, 500)
            Console.Beep(950, 250)
            Console.Beep(500, 250)
            System.Threading.Thread.Sleep(500)
            Console.ResetColor()
            Dim synth As SpeechSynthesizer = New SpeechSynthesizer()
            synth.SetOutputToDefaultAudioDevice()
            synth.Speak("Hot")
            Console.WriteLine("Press a key to continue")
            Console.ReadKey()

            Game(diff)
        End If
    End Sub

    Sub Game(ByVal Difficulty As Integer)
        Dim money As New Random()
        If players = 1 Then

            Console.Clear()
            Console.WriteLine("*** WATER LAND WATER SELL ***")
            Threading.Thread.Sleep(500)
            Console.WriteLine("Recommended price: " & Difficulty + Math.Ceiling(Rnd() * 6) & " cents")
            Console.WriteLine()
            Threading.Thread.Sleep(500)
            Console.WriteLine("You have " & cash & " cents!")
            Console.WriteLine()
            Threading.Thread.Sleep(500)
            Console.WriteLine("Enter how much glasses of water you wish to make:")
            Dim glasses = Console.ReadLine
            If Integer.TryParse(glasses, 1) Then
            Else
                Game(Difficulty)
            End If
            Threading.Thread.Sleep(500)
            Console.WriteLine("Enter how much ads you wish to make (10 cents each):")
            Dim signs = Console.ReadLine
            If Integer.TryParse(signs, 1) Then
            Else
                Game(Difficulty)
            End If
            Threading.Thread.Sleep(500)
            Console.WriteLine("Enter how expensive the glasses of water are:")
            Dim price = Console.ReadLine
            If Integer.TryParse(price, 1) Then
            Else
                Game(Difficulty)
            End If
            Threading.Thread.Sleep(500)
            Console.WriteLine("OK? Enter = yes")
            Console.ReadKey()
            Console.Clear()
            Console.WriteLine("*** Water Land Business Payouts ***")
            Threading.Thread.Sleep(500)
            If cash >= signs * 10 Then
                cash -= signs * 10
                Dim moneyz
                If glasses > 12 And glasses <= 35 Then
                    moneyz = money.Next(1, Convert.ToInt32(glasses) + signs) * price - Difficulty / Difficulty - price - price
                End If
                If glasses > 35 And glasses <= 60 Then
                    moneyz = money.Next(1, Convert.ToInt32(glasses) + signs) * price - Difficulty / Difficulty
                End If
                If glasses > 60 And glasses <= 100 Then
                    moneyz = money.Next(1, Convert.ToInt32(glasses) + signs) * price - Difficulty / Difficulty / Difficulty
                End If
                If glasses > 100 And glasses <= 150 Then
                    moneyz = money.Next(1, Convert.ToInt32(glasses)) * price - price / 2 / Difficulty / Difficulty / Difficulty - price
                End If
                If glasses <= 12 Then
                    moneyz = money.Next(1, Convert.ToInt32(glasses) + signs + 1) * price / Difficulty
                End If
                If glasses > 150 Then
                    Console.WriteLine("No customers came to the Water Stand!")
                    moneyz = 0
                End If
                If Not Difficulty = 4 Then
                    If price >= 15 Then
                        Console.WriteLine("No customers came to the Water Stand!")
                        moneyz = 0
                    End If
                Else
                    If price >= 27 Then
                        Console.WriteLine("No customers came to the Water Stand!")
                        moneyz = 0
                    End If
                End If

                Console.WriteLine("Water Stand: " & moneyz)
                cash += moneyz
                Threading.Thread.Sleep(500)
                Console.WriteLine("Water Stand Money: (in cents) " & cash)
                Console.ReadKey()
                Weather()
            Else
                Console.WriteLine("Water Stand: 0 (Not enough money for ads)")
                Console.ReadKey()
                Weather()
            End If
        End If
        If players >= 2 Then
            For d As Integer = 0 To glassesa.Count - 1
                glassesa.Remove(d)
            Next
            For d As Integer = 0 To signsa.Count - 1
                signsa.Remove(d)
            Next
            For d As Integer = 0 To glassesa.Count - 1
                pricea.Remove(d)
            Next
            For l As Integer = 0 To moreCash.Count - 1
                Console.Clear()
                Console.WriteLine("*** WATER LAND WATER SELL - STAND " & l + 1 & " ***")
                Threading.Thread.Sleep(500)
                Console.WriteLine("Recommended price: " & Difficulty + Math.Ceiling(Rnd() * 6) & " cents")
                Console.WriteLine()
                Threading.Thread.Sleep(500)
                Console.WriteLine("You have " & moreCash(l) & " cents!")
                Console.WriteLine()
                Threading.Thread.Sleep(500)
                Console.WriteLine("Enter how much glasses of water you wish to make:")
                Dim glasses = Console.ReadLine
                If Integer.TryParse(glasses, 1) Then
                Else
                    Game(Difficulty)
                End If
                Threading.Thread.Sleep(500)
                Console.WriteLine("Enter how much ads you wish to make (10 cents each):")
                Dim signs = Console.ReadLine
                If Integer.TryParse(signs, 1) Then
                Else
                    Game(Difficulty)
                End If
                Threading.Thread.Sleep(500)
                Console.WriteLine("Enter how expensive the glasses of water are:")
                Dim price = Console.ReadLine
                If Integer.TryParse(price, 1) Then
                Else
                    Game(Difficulty)
                End If
                Threading.Thread.Sleep(500)
                Console.WriteLine("OK? Enter = yes")
                Console.ReadKey()
                Console.Clear()

                glassesa.Add(Convert.ToInt32(glasses))
                pricea.Add(Convert.ToInt32(price))
                signsa.Add(Convert.ToInt32(signs))
            Next
            multiPlayerWinst(Difficulty, money)
        End If
    End Sub

    Sub multiPlayerWinst(ByVal difficulty As Integer, ByVal money As Random)
        Console.WriteLine("*** Water Land Business Payouts ***")
        Threading.Thread.Sleep(500)
        For n As Integer = 0 To moreCash.Count - 1
            If Not signsa(n) = 0 Then
                If moreCash(n) >= signsa(n) * 10 Then
                    moreCash(n) -= signsa(n) * 10
                    Dim moneyz
                    If glassesa(n) > 12 And glassesa(n) <= 35 Then
                        moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n)) * pricea(n) - difficulty / difficulty - pricea(n) - pricea(n)
                    End If
                    If glassesa(n) > 35 And glassesa(n) <= 60 Then
                        moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n)) * pricea(n) - difficulty / difficulty
                    End If
                    If glassesa(n) > 60 And glassesa(n) <= 100 Then
                        moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n)) * pricea(n) - difficulty / difficulty / difficulty
                    End If
                    If glassesa(n) > 100 And glassesa(n) <= 150 Then
                        moneyz = money.Next(1, Convert.ToInt32(glassesa(n))) * pricea(n) - pricea(n) / 2 / difficulty / difficulty / difficulty - pricea(n)
                    End If
                    If glassesa(n) <= 12 Then
                        moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n) + 1) * pricea(n) / difficulty
                    End If
                    If glassesa(n) > 150 Then
                        Console.WriteLine("No customers came to the Water Stand!")
                        moneyz = 0
                    End If
                    If Not difficulty = 4 Then
                        If pricea(n) >= 15 Then
                            Console.WriteLine("No customers came to the Water Stand!")
                            moneyz = 0
                        End If
                    Else
                        If pricea(n) >= 27 Then
                            Console.WriteLine("No customers came to the Water Stand!")
                            moneyz = 0
                        End If
                    End If

                    Console.WriteLine("Water Stand " & n + 1 & ": " & "" & moneyz)
                    moreCash(n) += moneyz
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("Water Stand " & n + 1 & " Money: (in cents) " & moreCash(n))
                Else
                    Console.WriteLine("Water Stand " & n + 1 & ": 0 (Not enough money for ads)")

                End If
            Else
                Dim moneyz
                If glassesa(n) > 12 And glassesa(n) <= 35 Then
                    moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n)) * pricea(n) - difficulty / difficulty - pricea(n) - pricea(n)
                End If
                If glassesa(n) > 35 And glassesa(n) <= 60 Then
                    moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n)) * pricea(n) - difficulty / difficulty
                End If
                If glassesa(n) > 60 And glassesa(n) <= 100 Then
                    moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n)) * pricea(n) - difficulty / difficulty / difficulty
                End If
                If glassesa(n) > 100 And glassesa(n) <= 150 Then
                    moneyz = money.Next(1, Convert.ToInt32(glassesa(n))) * pricea(n) - pricea(n) / 2 / difficulty / difficulty / difficulty - pricea(n)
                End If
                If glassesa(n) <= 12 Then
                    moneyz = money.Next(1, Convert.ToInt32(glassesa(n)) + signsa(n) + 1) * pricea(n) / difficulty
                End If
                If glassesa(n) > 150 Then
                    Console.WriteLine("No customers came to the Water Stand!")
                    moneyz = 0
                End If
                If Not difficulty = 4 Then
                    If pricea(n) >= 15 Then
                        Console.WriteLine("No customers came to the Water Stand!")
                        moneyz = 0
                    End If
                Else
                    If pricea(n) >= 27 Then
                        Console.WriteLine("No customers came to the Water Stand!")
                        moneyz = 0
                    End If
                End If

                Console.WriteLine("Water Stand " & n + 1 & ": " & "" & moneyz)
                moreCash(n) += moneyz
                Threading.Thread.Sleep(500)
                Console.WriteLine("Water Stand " & n + 1 & " Money: (in cents) " & moreCash(n))
            End If
        Next
        Console.WriteLine("Press a key to continue")
        Console.ReadKey()
        Console.WriteLine("Sure?")
        Console.ReadKey()
        Weather()
    End Sub
    Sub Play(ByVal tune As Note())
        For Each n As Note In tune

            If n.NoteTone = Tone.REST Then
                Thread.Sleep(CInt(n.NoteDuration))
            Else
                Console.Beep(CInt(n.NoteTone), CInt(n.NoteDuration))
            End If
        Next
    End Sub

    Enum Tone
        REST = 0
        GbelowC = 196
        A = 220
        Asharp = 233
        B = 247
        C = 262
        Csharp = 277
        D = 294
        Dsharp = 311
        E = 330
        F = 349
        Fsharp = 370
        G = 392
        Gsharp = 415
    End Enum

    Enum Duration
        WHOLE = 2360
        HALF = WHOLE / 2
        QUARTER = HALF / 2
        EIGHTH = QUARTER / 2
        SIXTEENTH = EIGHTH / 2
    End Enum

    Structure Note
        Private toneVal As Tone
        Private durVal As Duration

        Public Sub New(ByVal frequency As Tone, ByVal time As Duration)
            toneVal = frequency
            durVal = time
        End Sub

        Public ReadOnly Property NoteTone As Tone
            Get
                Return toneVal
            End Get
        End Property

        Public ReadOnly Property NoteDuration As Duration
            Get
                Return durVal
            End Get
        End Property
    End Structure
End Module
