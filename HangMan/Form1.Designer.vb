<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.CaptDescription = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblMask = New System.Windows.Forms.Label()
        Me.txtGuesses = New System.Windows.Forms.TextBox()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.CaptGuesses = New System.Windows.Forms.Label()
        Me.lblGuesses = New System.Windows.Forms.Label()
        Me.CaptGuessaLetter = New System.Windows.Forms.Label()
        Me.tmrLetters = New System.Windows.Forms.Timer(Me.components)
        Me.tmrWin = New System.Windows.Forms.Timer(Me.components)
        Me.btnWhole = New System.Windows.Forms.Button()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.btnAddWords = New System.Windows.Forms.Button()
        Me.tmrEntertain = New System.Windows.Forms.Timer(Me.components)
        Me.picAnimate = New System.Windows.Forms.PictureBox()
        Me.PicHangMan = New System.Windows.Forms.PictureBox()
        Me.lblSpoof = New System.Windows.Forms.Label()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.tmrStat = New System.Windows.Forms.Timer(Me.components)
        Me.lblAlready = New System.Windows.Forms.Label()
        Me.tmrAlready = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picAnimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(38, 11)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 0
        Me.btnNewGame.TabStop = False
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnSolve
        '
        Me.btnSolve.Enabled = False
        Me.btnSolve.Location = New System.Drawing.Point(117, 11)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(69, 23)
        Me.btnSolve.TabIndex = 1
        Me.btnSolve.TabStop = False
        Me.btnSolve.Text = "Solve"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'CaptDescription
        '
        Me.CaptDescription.AutoSize = True
        Me.CaptDescription.Location = New System.Drawing.Point(2, 365)
        Me.CaptDescription.Name = "CaptDescription"
        Me.CaptDescription.Size = New System.Drawing.Size(66, 13)
        Me.CaptDescription.TabIndex = 2
        Me.CaptDescription.Text = "Description: "
        Me.CaptDescription.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(0, 379)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(237, 56)
        Me.lblDescription.TabIndex = 3
        '
        'lblWord
        '
        Me.lblWord.Location = New System.Drawing.Point(-4, 327)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(243, 26)
        Me.lblWord.TabIndex = 4
        Me.lblWord.Text = "Word"
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWord.Visible = False
        '
        'lblMask
        '
        Me.lblMask.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMask.Location = New System.Drawing.Point(-4, 327)
        Me.lblMask.Name = "lblMask"
        Me.lblMask.Size = New System.Drawing.Size(243, 26)
        Me.lblMask.TabIndex = 5
        Me.lblMask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGuesses
        '
        Me.txtGuesses.Location = New System.Drawing.Point(87, 251)
        Me.txtGuesses.MaxLength = 1
        Me.txtGuesses.Name = "txtGuesses"
        Me.txtGuesses.Size = New System.Drawing.Size(58, 20)
        Me.txtGuesses.TabIndex = 1
        Me.txtGuesses.Visible = False
        '
        'btnGuess
        '
        Me.btnGuess.Location = New System.Drawing.Point(151, 249)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(75, 23)
        Me.btnGuess.TabIndex = 8
        Me.btnGuess.TabStop = False
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        Me.btnGuess.Visible = False
        '
        'CaptGuesses
        '
        Me.CaptGuesses.AutoSize = True
        Me.CaptGuesses.Location = New System.Drawing.Point(3, 277)
        Me.CaptGuesses.Name = "CaptGuesses"
        Me.CaptGuesses.Size = New System.Drawing.Size(90, 13)
        Me.CaptGuesses.TabIndex = 9
        Me.CaptGuesses.Text = "Guessed Letters: "
        Me.CaptGuesses.Visible = False
        '
        'lblGuesses
        '
        Me.lblGuesses.Location = New System.Drawing.Point(7, 294)
        Me.lblGuesses.Name = "lblGuesses"
        Me.lblGuesses.Size = New System.Drawing.Size(219, 23)
        Me.lblGuesses.TabIndex = 10
        Me.lblGuesses.Visible = False
        '
        'CaptGuessaLetter
        '
        Me.CaptGuessaLetter.AutoSize = True
        Me.CaptGuessaLetter.Location = New System.Drawing.Point(3, 254)
        Me.CaptGuessaLetter.Name = "CaptGuessaLetter"
        Me.CaptGuessaLetter.Size = New System.Drawing.Size(78, 13)
        Me.CaptGuessaLetter.TabIndex = 11
        Me.CaptGuessaLetter.Text = "Guess a letter: "
        Me.CaptGuessaLetter.Visible = False
        '
        'tmrLetters
        '
        Me.tmrLetters.Interval = 1
        '
        'tmrWin
        '
        Me.tmrWin.Interval = 1000
        '
        'btnWhole
        '
        Me.btnWhole.Location = New System.Drawing.Point(6, 435)
        Me.btnWhole.Name = "btnWhole"
        Me.btnWhole.Size = New System.Drawing.Size(220, 23)
        Me.btnWhole.TabIndex = 12
        Me.btnWhole.TabStop = False
        Me.btnWhole.Text = "Guess the Whole Word"
        Me.btnWhole.UseVisualStyleBackColor = True
        Me.btnWhole.Visible = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.Red
        Me.lblGameOver.Location = New System.Drawing.Point(10, 244)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(213, 31)
        Me.lblGameOver.TabIndex = 13
        Me.lblGameOver.Text = "GAME OVER :("
        Me.lblGameOver.Visible = False
        '
        'btnAddWords
        '
        Me.btnAddWords.Enabled = False
        Me.btnAddWords.Location = New System.Drawing.Point(240, 11)
        Me.btnAddWords.Name = "btnAddWords"
        Me.btnAddWords.Size = New System.Drawing.Size(72, 23)
        Me.btnAddWords.TabIndex = 14
        Me.btnAddWords.TabStop = False
        Me.btnAddWords.Text = "Add Words"
        Me.btnAddWords.UseVisualStyleBackColor = True
        '
        'tmrEntertain
        '
        Me.tmrEntertain.Enabled = True
        Me.tmrEntertain.Interval = 700
        '
        'picAnimate
        '
        Me.picAnimate.Location = New System.Drawing.Point(6, 76)
        Me.picAnimate.Name = "picAnimate"
        Me.picAnimate.Size = New System.Drawing.Size(217, 353)
        Me.picAnimate.TabIndex = 15
        Me.picAnimate.TabStop = False
        '
        'PicHangMan
        '
        Me.PicHangMan.Image = Global.HangMan.My.Resources.Resources.hang0
        Me.PicHangMan.Location = New System.Drawing.Point(5, 41)
        Me.PicHangMan.Name = "PicHangMan"
        Me.PicHangMan.Size = New System.Drawing.Size(221, 202)
        Me.PicHangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicHangMan.TabIndex = 6
        Me.PicHangMan.TabStop = False
        Me.PicHangMan.Visible = False
        '
        'lblSpoof
        '
        Me.lblSpoof.AutoSize = True
        Me.lblSpoof.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpoof.Location = New System.Drawing.Point(36, 396)
        Me.lblSpoof.Name = "lblSpoof"
        Me.lblSpoof.Size = New System.Drawing.Size(159, 25)
        Me.lblSpoof.TabIndex = 16
        Me.lblSpoof.Text = "Save His Life!"
        '
        'lblStat
        '
        Me.lblStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStat.Location = New System.Drawing.Point(24, 210)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(199, 27)
        Me.lblStat.TabIndex = 17
        Me.lblStat.Text = "Lbl"
        Me.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblStat.Visible = False
        '
        'tmrStat
        '
        Me.tmrStat.Interval = 1000
        '
        'lblAlready
        '
        Me.lblAlready.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlready.Location = New System.Drawing.Point(24, 211)
        Me.lblAlready.Name = "lblAlready"
        Me.lblAlready.Size = New System.Drawing.Size(199, 27)
        Me.lblAlready.TabIndex = 18
        Me.lblAlready.Text = "Lbl"
        Me.lblAlready.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlready.Visible = False
        '
        'tmrAlready
        '
        Me.tmrAlready.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(148, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 459)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAlready)
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.btnAddWords)
        Me.Controls.Add(Me.btnWhole)
        Me.Controls.Add(Me.CaptGuessaLetter)
        Me.Controls.Add(Me.lblGuesses)
        Me.Controls.Add(Me.CaptGuesses)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.txtGuesses)
        Me.Controls.Add(Me.PicHangMan)
        Me.Controls.Add(Me.lblMask)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.CaptDescription)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblSpoof)
        Me.Controls.Add(Me.picAnimate)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblDescription)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HangMan"
        CType(Me.picAnimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnSolve As System.Windows.Forms.Button
    Friend WithEvents CaptDescription As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents lblMask As System.Windows.Forms.Label
    Friend WithEvents PicHangMan As System.Windows.Forms.PictureBox
    Friend WithEvents txtGuesses As System.Windows.Forms.TextBox
    Friend WithEvents btnGuess As System.Windows.Forms.Button
    Friend WithEvents CaptGuesses As System.Windows.Forms.Label
    Friend WithEvents lblGuesses As System.Windows.Forms.Label
    Friend WithEvents CaptGuessaLetter As System.Windows.Forms.Label
    Friend WithEvents tmrLetters As System.Windows.Forms.Timer
    Friend WithEvents tmrWin As System.Windows.Forms.Timer
    Friend WithEvents btnWhole As System.Windows.Forms.Button
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents btnAddWords As System.Windows.Forms.Button
    Friend WithEvents tmrEntertain As System.Windows.Forms.Timer
    Friend WithEvents picAnimate As System.Windows.Forms.PictureBox
    Friend WithEvents lblSpoof As System.Windows.Forms.Label
    Friend WithEvents lblStat As System.Windows.Forms.Label
    Friend WithEvents tmrStat As System.Windows.Forms.Timer
    Friend WithEvents lblAlready As System.Windows.Forms.Label
    Friend WithEvents tmrAlready As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
