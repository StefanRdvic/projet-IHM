<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.ComboBox_name = New System.Windows.Forms.ComboBox()
        Me.btn_score = New System.Windows.Forms.Button()
        Me.btn_options = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.btn_jouer = New System.Windows.Forms.Button()
        Me.lab_name = New System.Windows.Forms.Label()
        Me.LabelRule = New System.Windows.Forms.Label()
        Me.ButtonRule = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_name
        '
        Me.ComboBox_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ComboBox_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox_name.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.ComboBox_name.FormattingEnabled = True
        Me.ComboBox_name.Location = New System.Drawing.Point(209, 155)
        Me.ComboBox_name.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox_name.Name = "ComboBox_name"
        Me.ComboBox_name.Size = New System.Drawing.Size(140, 26)
        Me.ComboBox_name.TabIndex = 0
        '
        'btn_score
        '
        Me.btn_score.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_score.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_score.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_score.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btn_score.Location = New System.Drawing.Point(63, 211)
        Me.btn_score.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_score.Name = "btn_score"
        Me.btn_score.Size = New System.Drawing.Size(140, 60)
        Me.btn_score.TabIndex = 1
        Me.btn_score.Text = "Voir les scores"
        Me.btn_score.UseVisualStyleBackColor = False
        '
        'btn_options
        '
        Me.btn_options.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_options.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_options.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btn_options.Location = New System.Drawing.Point(209, 211)
        Me.btn_options.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(140, 60)
        Me.btn_options.TabIndex = 2
        Me.btn_options.Text = "Options"
        Me.btn_options.UseVisualStyleBackColor = False
        '
        'btn_quitter
        '
        Me.btn_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btn_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_quitter.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btn_quitter.Location = New System.Drawing.Point(355, 211)
        Me.btn_quitter.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(140, 60)
        Me.btn_quitter.TabIndex = 3
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = False
        '
        'btn_jouer
        '
        Me.btn_jouer.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btn_jouer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_jouer.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_jouer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btn_jouer.Location = New System.Drawing.Point(366, 138)
        Me.btn_jouer.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jouer.Name = "btn_jouer"
        Me.btn_jouer.Size = New System.Drawing.Size(109, 57)
        Me.btn_jouer.TabIndex = 4
        Me.btn_jouer.Text = "Jouer"
        Me.btn_jouer.UseVisualStyleBackColor = False
        '
        'lab_name
        '
        Me.lab_name.AutoSize = True
        Me.lab_name.Font = New System.Drawing.Font("Comfortaa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lab_name.Location = New System.Drawing.Point(52, 158)
        Me.lab_name.Name = "lab_name"
        Me.lab_name.Size = New System.Drawing.Size(151, 23)
        Me.lab_name.TabIndex = 5
        Me.lab_name.Text = "Entrez votre nom : "
        '
        'LabelRule
        '
        Me.LabelRule.AutoSize = True
        Me.LabelRule.Font = New System.Drawing.Font("Comfortaa", 8.1!)
        Me.LabelRule.Location = New System.Drawing.Point(110, 285)
        Me.LabelRule.Name = "LabelRule"
        Me.LabelRule.Size = New System.Drawing.Size(468, 89)
        Me.LabelRule.TabIndex = 6
        Me.LabelRule.Text = resources.GetString("LabelRule.Text")
        Me.LabelRule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelRule.UseCompatibleTextRendering = True
        '
        'ButtonRule
        '
        Me.ButtonRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ButtonRule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonRule.Location = New System.Drawing.Point(12, 308)
        Me.ButtonRule.Name = "ButtonRule"
        Me.ButtonRule.Size = New System.Drawing.Size(92, 42)
        Me.ButtonRule.TabIndex = 7
        Me.ButtonRule.Text = "But du Jeu"
        Me.ButtonRule.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.memories.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(2, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 139)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(174, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 66)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Memory Game !"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(578, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonRule)
        Me.Controls.Add(Me.LabelRule)
        Me.Controls.Add(Me.lab_name)
        Me.Controls.Add(Me.btn_jouer)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_options)
        Me.Controls.Add(Me.btn_score)
        Me.Controls.Add(Me.ComboBox_name)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Comfortaa", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memory Game - Accueil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_name As ComboBox
    Friend WithEvents btn_score As Button
    Friend WithEvents btn_options As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents btn_jouer As Button
    Friend WithEvents lab_name As Label
    Friend WithEvents LabelRule As Label
    Friend WithEvents ButtonRule As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
