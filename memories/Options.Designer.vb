<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.CheckBoxTime = New System.Windows.Forms.CheckBox()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.CheckBoxPause = New System.Windows.Forms.CheckBox()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.btnLeave = New System.Windows.Forms.Button()
        Me.RadioButtonOn = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOff = New System.Windows.Forms.RadioButton()
        Me.GroupBoxMusic = New System.Windows.Forms.GroupBox()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTh1 = New System.Windows.Forms.Label()
        Me.lblTh2 = New System.Windows.Forms.Label()
        Me.RadioButtonTheme2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTheme1 = New System.Windows.Forms.RadioButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxMusic.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBoxTime
        '
        Me.CheckBoxTime.AutoSize = True
        Me.CheckBoxTime.Location = New System.Drawing.Point(46, 71)
        Me.CheckBoxTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBoxTime.Name = "CheckBoxTime"
        Me.CheckBoxTime.Size = New System.Drawing.Size(73, 27)
        Me.CheckBoxTime.TabIndex = 0
        Me.CheckBoxTime.Text = "Timer"
        Me.CheckBoxTime.UseVisualStyleBackColor = True
        '
        'TextBoxTime
        '
        Me.TextBoxTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.TextBoxTime.Location = New System.Drawing.Point(176, 70)
        Me.TextBoxTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.Size = New System.Drawing.Size(164, 24)
        Me.TextBoxTime.TabIndex = 1
        '
        'CheckBoxPause
        '
        Me.CheckBoxPause.AutoSize = True
        Me.CheckBoxPause.Location = New System.Drawing.Point(46, 108)
        Me.CheckBoxPause.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBoxPause.Name = "CheckBoxPause"
        Me.CheckBoxPause.Size = New System.Drawing.Size(135, 27)
        Me.CheckBoxPause.TabIndex = 2
        Me.CheckBoxPause.Text = "Bouton Pause"
        Me.CheckBoxPause.UseVisualStyleBackColor = True
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(348, 70)
        Me.LabelTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(131, 23)
        Me.LabelTime.TabIndex = 3
        Me.LabelTime.Text = "Temps souhaité"
        '
        'btnLeave
        '
        Me.btnLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLeave.Location = New System.Drawing.Point(176, 545)
        Me.btnLeave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLeave.Name = "btnLeave"
        Me.btnLeave.Size = New System.Drawing.Size(167, 78)
        Me.btnLeave.TabIndex = 5
        Me.btnLeave.Text = "Sauvegarder et Quitter "
        Me.btnLeave.UseVisualStyleBackColor = False
        '
        'RadioButtonOn
        '
        Me.RadioButtonOn.AutoSize = True
        Me.RadioButtonOn.Location = New System.Drawing.Point(59, 57)
        Me.RadioButtonOn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonOn.Name = "RadioButtonOn"
        Me.RadioButtonOn.Size = New System.Drawing.Size(52, 27)
        Me.RadioButtonOn.TabIndex = 6
        Me.RadioButtonOn.TabStop = True
        Me.RadioButtonOn.Text = "On"
        Me.RadioButtonOn.UseVisualStyleBackColor = True
        '
        'RadioButtonOff
        '
        Me.RadioButtonOff.AutoSize = True
        Me.RadioButtonOff.Location = New System.Drawing.Point(151, 57)
        Me.RadioButtonOff.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButtonOff.Name = "RadioButtonOff"
        Me.RadioButtonOff.Size = New System.Drawing.Size(53, 27)
        Me.RadioButtonOff.TabIndex = 7
        Me.RadioButtonOff.TabStop = True
        Me.RadioButtonOff.Text = "Off"
        Me.RadioButtonOff.UseVisualStyleBackColor = True
        '
        'GroupBoxMusic
        '
        Me.GroupBoxMusic.Controls.Add(Me.RadioButtonOff)
        Me.GroupBoxMusic.Controls.Add(Me.RadioButtonOn)
        Me.GroupBoxMusic.Location = New System.Drawing.Point(46, 145)
        Me.GroupBoxMusic.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxMusic.Name = "GroupBoxMusic"
        Me.GroupBoxMusic.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxMusic.Size = New System.Drawing.Size(284, 129)
        Me.GroupBoxMusic.TabIndex = 8
        Me.GroupBoxMusic.TabStop = False
        Me.GroupBoxMusic.Text = "Musique"
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.Font = New System.Drawing.Font("Comfortaa", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOption.Location = New System.Drawing.Point(127, 9)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(246, 45)
        Me.lblOption.TabIndex = 9
        Me.lblOption.Text = "Options du jeu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTh1)
        Me.GroupBox1.Controls.Add(Me.lblTh2)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTheme2)
        Me.GroupBox1.Controls.Add(Me.RadioButtonTheme1)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 200)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thème"
        '
        'lblTh1
        '
        Me.lblTh1.Location = New System.Drawing.Point(36, 77)
        Me.lblTh1.Name = "lblTh1"
        Me.lblTh1.Size = New System.Drawing.Size(59, 23)
        Me.lblTh1.TabIndex = 11
        Me.lblTh1.Text = "1"
        '
        'lblTh2
        '
        Me.lblTh2.Location = New System.Drawing.Point(126, 77)
        Me.lblTh2.Name = "lblTh2"
        Me.lblTh2.Size = New System.Drawing.Size(62, 23)
        Me.lblTh2.TabIndex = 12
        Me.lblTh2.Text = "2"
        '
        'RadioButtonTheme2
        '
        Me.RadioButtonTheme2.AutoSize = True
        Me.RadioButtonTheme2.Location = New System.Drawing.Point(151, 41)
        Me.RadioButtonTheme2.Name = "RadioButtonTheme2"
        Me.RadioButtonTheme2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonTheme2.TabIndex = 1
        Me.RadioButtonTheme2.TabStop = True
        Me.RadioButtonTheme2.UseVisualStyleBackColor = True
        '
        'RadioButtonTheme1
        '
        Me.RadioButtonTheme1.AutoSize = True
        Me.RadioButtonTheme1.Location = New System.Drawing.Point(59, 41)
        Me.RadioButtonTheme1.Name = "RadioButtonTheme1"
        Me.RadioButtonTheme1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonTheme1.TabIndex = 0
        Me.RadioButtonTheme1.TabStop = True
        Me.RadioButtonTheme1.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Comfortaa", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(415, 513)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 31)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Recherche"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'TextBoxPath
        '
        Me.TextBoxPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TextBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPath.Font = New System.Drawing.Font("Comfortaa", 5.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.TextBoxPath.Location = New System.Drawing.Point(47, 519)
        Me.TextBoxPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(361, 16)
        Me.TextBoxPath.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Chemin d'accès de la sauvegarde"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 634)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblOption)
        Me.Controls.Add(Me.GroupBoxMusic)
        Me.Controls.Add(Me.btnLeave)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.CheckBoxPause)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.CheckBoxTime)
        Me.Font = New System.Drawing.Font("Comfortaa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Game - Options"
        Me.GroupBoxMusic.ResumeLayout(False)
        Me.GroupBoxMusic.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxTime As CheckBox
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents CheckBoxPause As CheckBox
    Friend WithEvents LabelTime As Label
    Friend WithEvents btnLeave As Button
    Friend WithEvents RadioButtonOn As RadioButton
    Friend WithEvents RadioButtonOff As RadioButton
    Friend WithEvents GroupBoxMusic As GroupBox
    Friend WithEvents lblOption As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonTheme2 As RadioButton
    Friend WithEvents RadioButtonTheme1 As RadioButton
    Friend WithEvents lblTh1 As Label
    Friend WithEvents lblTh2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnSearch As Button
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents Label1 As Label
End Class
