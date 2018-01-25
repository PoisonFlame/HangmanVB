Imports System.Text.RegularExpressions
Imports System.Media

Public Class Form1
    Dim word As String
    Dim orgWord As String
    Dim numGuess As Integer = 10
    Dim description As String
    Dim wordShell As String
    Dim wordShelll As String
    Dim maskLength As Integer
    Dim number As String
    Dim gameisOver As Integer = 0 ' 0  = StillGoing, 1 = GameOver 
    Dim formTitle, handlemewithcare As Integer
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        newGame()
    End Sub

    Sub newGame()
        number = 0
        lblGuesses.Text = ""
        numGuess = 10
        gameisOver = 0
        ChooseWord()
        picAnimate.Visible = False
        btnNewGame.Enabled = False
        btnAddWords.Enabled = False
        lblStat.Visible = False
        lblSpoof.Visible = False
        btnSolve.Enabled = True
        CaptDescription.Visible = True
        txtGuesses.Visible = True
        lblGuesses.Visible = True
        CaptGuesses.Visible = True
        btnGuess.Visible = True
        CaptGuessaLetter.Visible = True
        btnGuess.Enabled = True
        btnWhole.Visible = True
        txtGuesses.Enabled = True
        txtGuesses.Text = ""
        PicHangMan.Visible = True
        PicHangMan.Image = My.Resources.hang0
        tmrLetters.Start()
        tmrWin.Start()
        Dim wordLength As Integer = word.Length
        txtGuesses.Focus()
        lblGameOver.Visible = False
        lblDescription.Text = description
        lblWord.Text = word
        lblMask.Text = wordShell


    End Sub
    Public Sub ChooseWord()
        Randomize()
        Dim generate As System.Random = New System.Random
        Dim random As Integer = generate.Next(1, 30)
        ' MsgBox(random)


        Dim words(30) As String

        words(1) = "Hello"
        words(2) = "NailPolish"
        words(3) = "Peanuts"
        words(4) = "Juice"
        words(5) = "Earthquake"
        words(6) = "Carrot"
        words(7) = "Mouse"
        words(8) = "Cat"
        words(9) = "Cloud"
        words(10) = "Sun"
        words(11) = "Computer"
        words(12) = "Smile"
        words(13) = "Queen"
        words(14) = "Table"
        words(15) = "Light"
        words(16) = "Collect"
        words(17) = "Crime"
        words(18) = "Basketball"
        words(19) = "Yellow"
        words(20) = "Smart"
        words(21) = "Sober"
        words(22) = "Fragile"
        words(23) = "Confirm"
        words(24) = "Rare"
        words(25) = "Vacant"
        words(26) = "Hostile"
        words(27) = "Impatient"
        words(28) = "Civilian"
        words(29) = "Shrink"
        words(30) = "Complicated"

        Dim wordMask(30) As String

        wordMask(1) = "_ _ _ _ _"
        wordMask(2) = "_ _ _ _ _ _ _ _ _ _"
        wordMask(3) = "_ _ _ _ _ _ _"
        wordMask(4) = "_ _ _ _ _"
        wordMask(5) = "_ _ _ _ _ _ _ _ _ _"
        wordMask(6) = "_ _ _ _ _ _"
        wordMask(7) = "_ _ _ _ _"
        wordMask(8) = "_ _ _"
        wordMask(9) = "_ _ _ _ _"
        wordMask(10) = "_ _ _"
        wordMask(11) = "_ _ _ _ _ _ _ _"
        wordMask(12) = "_ _ _ _ _"
        wordMask(13) = "_ _ _ _ _"
        wordMask(14) = "_ _ _ _ _"
        wordMask(15) = "_ _ _ _ _"
        wordMask(16) = "_ _ _ _ _ _ _"
        wordMask(17) = "_ _ _ _ _"
        wordMask(18) = "_ _ _ _ _ _ _ _ _ _"
        wordMask(19) = "_ _ _ _ _ _"
        wordMask(20) = "_ _ _ _ _"
        wordMask(21) = "_ _ _ _ _"
        wordMask(22) = "_ _ _ _ _ _ _"
        wordMask(23) = "_ _ _ _ _ _ _"
        wordMask(24) = "_ _ _ _"
        wordMask(25) = "_ _ _ _ _ _"
        wordMask(26) = "_ _ _ _ _ _ _"
        wordMask(27) = "_ _ _ _ _ _ _ _ _"
        wordMask(28) = "_ _ _ _ _ _ _ _"
        wordMask(29) = "_ _ _ _ _ _"
        wordMask(30) = "_ _ _ _ _ _ _ _ _ _ _"

        Dim Desc(30) As String

        Desc(1) = "A word used to greet other With."
        Desc(2) = "Girls use these for their fashion needs."
        Desc(3) = "A Brown type of nuts."
        Desc(4) = "Something liquid that comes in different flavours"
        Desc(5) = "A Natural Disaster"
        Desc(6) = "A Vegetable"
        Desc(7) = "A small animal"
        Desc(8) = "A animal that hunts mouses"
        Desc(9) = "A visible body of white moving things"
        Desc(10) = "A Big Yellow Substance"
        Desc(11) = "An object where you can virtualize just about anything"
        Desc(12) = "A face expression"
        Desc(13) = "A Very powerful person"
        Desc(14) = "An object where you can place other objects on"
        Desc(15) = "Energy from bulbs"
        Desc(16) = "getting things and putting them together"
        Desc(17) = "A thing you can be arrested for if caught"
        Desc(18) = "A game which uses a ball"
        Desc(19) = "A light color"
        Desc(20) = "A type of person who knows what he is doing"
        Desc(21) = "Not drunk, serious"
        Desc(22) = "Breakable"
        Desc(23) = "Tell the truth, not deny"
        Desc(24) = "Uncommon"
        Desc(25) = "Available"
        Desc(26) = "Not Peaceful"
        Desc(27) = "In a hurry, not patient"
        Desc(28) = "Not in the armed services or police forces"
        Desc(29) = "Get shorter."
        Desc(30) = "Not easy."

        word = words(random)
        description = Desc(random)
        wordShell = wordMask(random)
        wordShelll = wordMask(random)
        orgWord = words(random)
        maskLength = wordMask(random).Replace(" ", "").Length


        If words(random).Length <> maskLength Then
            MsgBox(words.Length & " " & maskLength)
            MsgBox("An Error Occured. A New Word Will be Chosen.", MsgBoxStyle.OkOnly, "Error")
            newGame()

        End If

    End Sub
    Private Sub btnSolve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSolve.Click
        Solve()
    End Sub

    Sub Solve()

        btnSolve.Enabled = False
        btnNewGame.Enabled = True
        txtGuesses.Visible = False
        btnWhole.Visible = False
        lblMask.Text = word
        gameisOver = 1
        PicHangMan.Image = My.Resources.hang10
        'lblGuesses.Visible = True
        'CaptGuesses.Visible = True
        btnGuess.Visible = False
        CaptGuessaLetter.Visible = False
        tmrLetters.Stop()
        lblGameOver.Visible = True
        MsgBox("Game Over. The word was " & word)

    End Sub

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        guess()

        If lblMask.Text.IndexOf("_") = -1 Then

            Win()

        End If

    End Sub

    Sub guess()


        Dim max_guesses As String = 10
        Dim guess As String = txtGuesses.Text
        word = word.ToLower()

        If lblGuesses.Text.Contains(guess) Then
            lblAlready.ForeColor = Color.OrangeRed
            lblAlready.Visible = True
            lblAlready.Text = "You Already Guessed '" & guess.ToUpper & "'"
            tmrAlready.Start()
        End If


        If word.Contains(guess.ToLower) Then

            If Not lblGuesses.Text.Contains(guess) Then

                lblStat.ForeColor = Color.Lime
                lblStat.Visible = True
                lblStat.Text = "Correct Guess!"
                tmrStat.Start()

            End If


            Dim wordPos As Integer = word.IndexOfAny(guess.ToLower) ' txtGuesses.text
            Dim tempPos As Integer = word.IndexOfAny(guess.ToLower)
            ' Dim tempPos As Integer = orgWord.IndexOf(guess.ToLower)
            ' Need to lower length of wordShell

            While wordPos >= 0
                wordShell = wordShell.Replace(" ", "")
                wordShell = wordShell.Remove(wordPos, 1)
                wordShell = wordShell.Insert(wordPos, guess)
                wordPos = word.IndexOfAny(guess, wordPos + 1)
            End While


            For i As Integer = wordShell.Length - 1 To 1 Step -1

                wordShell = wordShell.Insert(i, " ")

            Next
            Me.lblMask.Text = wordShell

        Else


            If Not lblGuesses.Text.Contains(guess) Then ' if  lblGuesses.text.indexof(guess) = -1 then
                number += 1
                numGuess -= 1
                lblStat.ForeColor = Color.Red
                lblStat.Text = "Wrong Guess!"
                lblStat.Visible = True
                tmrStat.Start()
            End If


            'Dim wrong_sound As New SoundPlayer(My.Resources.wrong)
            'wrong_sound.play()
        End If

        If lblGuesses.Text.Contains(txtGuesses.Text) Then

            'Do Nothing
        Else



            lblGuesses.Text = lblGuesses.Text & " " & guess & " "

        End If




        Select Case number
            Case 1
                PicHangMan.Image = My.Resources.hang1
            Case 2
                PicHangMan.Image = My.Resources.hang2
            Case 3
                PicHangMan.Image = My.Resources.hang3
            Case 4
                PicHangMan.Image = My.Resources.hang4
            Case 5
                PicHangMan.Image = My.Resources.hang5
            Case 6
                PicHangMan.Image = My.Resources.hang6
            Case 7
                PicHangMan.Image = My.Resources.hang7
            Case 8
                PicHangMan.Image = My.Resources.hang8
            Case 9
                PicHangMan.Image = My.Resources.hang9
            Case 10
                PicHangMan.Image = My.Resources.hang10

        End Select


        If number >= 10 Then

            gameOver()
            gameisOver = 1
        End If

        txtGuesses.Text = Nothing



    End Sub

    Sub gameOver()


        MsgBox("Game Over. The Word Was " & word)
        btnNewGame.Enabled = True
        btnSolve.Enabled = False
        txtGuesses.Enabled = False
        btnGuess.Enabled = False
        btnGuess.Visible = False
        txtGuesses.Visible = False
        CaptGuessaLetter.Visible = False
        btnWhole.Visible = False
        '  lblMask.Text = word
        gameisOver = 1
        lblGameOver.Visible = True
        Dim fail_sound As New SoundPlayer(My.Resources.fail_trombone_01)
        fail_sound.Play()

    End Sub

    Private Sub tmrLetters_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLetters.Tick
        If txtGuesses.Text = Nothing Then

            btnGuess.Enabled = False

        Else

            btnGuess.Enabled = True

        End If


        If IsNumeric(txtGuesses.Text) Then

            txtGuesses.Text = ""

        End If
    End Sub

    Sub Win()

        MsgBox("You Got the Word!!")
        btnNewGame.Enabled = True
        btnSolve.Enabled = False
        txtGuesses.Enabled = False
        btnGuess.Enabled = False
        lblMask.Text = word
        btnWhole.Visible = False
        tmrStat.Stop()
        lblStat.ForeColor = Color.Cyan
        lblStat.Visible = True
        lblStat.Text = "You Got the Word!!!"
        Dim win_sound As New SoundPlayer(My.Resources.Ta_Da_SoundBible_com_1884170640)
        win_sound.Play()
    End Sub

    Private Sub btnWhole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhole.Click
        Dim qq As String = InputBox("Guess the whole word! If you get it wrong its game over! If you cancel you lose a guess.", "Guess the word!")




        'qq = InputBox("Guess the whole word! If you get it wrong its game over!", "Guess the word!")


        If qq.Length = 0 Then

            MsgBox("You Didn't Input a Value! You will lose a guess. :(")
            number += 1
            numGuess -= 1
        End If

        If qq.ToLower = word.ToLower And qq.Length <> 0 Then

            Win()
        ElseIf qq.ToLower <> word.ToLower And qq.Length <> 0 Then

            gameOver()

        End If

        Select Case number
            Case 1
                PicHangMan.Image = My.Resources.hang1
            Case 2
                PicHangMan.Image = My.Resources.hang2
            Case 3
                PicHangMan.Image = My.Resources.hang3
            Case 4
                PicHangMan.Image = My.Resources.hang4
            Case 5
                PicHangMan.Image = My.Resources.hang5
            Case 6
                PicHangMan.Image = My.Resources.hang6
            Case 7
                PicHangMan.Image = My.Resources.hang7
            Case 8
                PicHangMan.Image = My.Resources.hang8
            Case 9
                PicHangMan.Image = My.Resources.hang9
            Case 10
                PicHangMan.Image = My.Resources.hang10

        End Select

        If number >= 10 Then

            gameOver()
            gameisOver = 1
        End If

    End Sub

    Private Sub Form1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus


        ' Do Nothing
        For i As Integer = 0 To Controls.Count - 1

            Controls(i).TabStop = False

        Next


    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then

            btnGuess.PerformClick()

        End If

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True
        'ggf
        picAnimate.BringToFront()
        lblSpoof.BringToFront()
        picAnimate.Image = My.Resources.hangman
    End Sub

    

    Private Sub tmrEntertain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEntertain.Tick

        tmrEntertain.Interval = 100

        Select Case handlemewithcare
            Case 0
                lblSpoof.ForeColor = Color.Aqua
                handlemewithcare = 1
            Case 1
                lblSpoof.ForeColor = Color.DeepSkyBlue
                handlemewithcare = 2
            Case 2
                lblSpoof.ForeColor = Color.Chocolate
                handlemewithcare = 3
            Case 3
                lblSpoof.ForeColor = Color.Cyan
                handlemewithcare = 4
            Case 4
                lblSpoof.ForeColor = Color.Lime
                handlemewithcare = 5
            Case 5
                lblSpoof.ForeColor = Color.Gray
                handlemewithcare = 0
        End Select

        tmrEntertain.Interval = 700


        Select Case formTitle
            Case 0
                Me.Text = "Hangman Game"
                formTitle = 1
            Case 1

                If word = Nothing Then

                    Me.Text = "Good Luck!"
                    formTitle = 2
                Else

                    Me.Text = numGuess & " Guesses Left"
                    formTitle = 2

                End If


            Case 2
                formTitle = 0
        End Select

    End Sub

    Private Sub tmrStat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStat.Tick
        lblStat.Visible = False
        tmrStat.Stop()
    End Sub

    Private Sub tmrAlready_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAlready.Tick
        lblAlready.Visible = False
        tmrAlready.Stop()
    End Sub

    Private Sub txtGuesses_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuesses.KeyPress
        If e.KeyChar = Chr(13) Then e.Handled = True

    End Sub
End Class
