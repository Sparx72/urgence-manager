<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lancerJeuLibreSolo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatAlertBox1 = New SAMU_Centre_15.FlatAlertBox()
        Me.FlatButton5 = New SAMU_Centre_15.FlatButton()
        Me.FlatButton6 = New SAMU_Centre_15.FlatButton()
        Me.FlatLabel1 = New SAMU_Centre_15.FlatLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlatLabel8 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel7 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel6 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel4 = New SAMU_Centre_15.FlatLabel()
        Me.FlatButton4 = New SAMU_Centre_15.FlatButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.FlatButton1 = New SAMU_Centre_15.FlatButton()
        Me.FlatStatusBar1 = New SAMU_Centre_15.FlatStatusBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.FlatAlertBox1)
        Me.Panel1.Controls.Add(Me.FlatButton5)
        Me.Panel1.Controls.Add(Me.FlatButton6)
        Me.Panel1.Controls.Add(Me.FlatLabel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 46)
        Me.Panel1.TabIndex = 19
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = SAMU_Centre_15.FlatAlertBox._Kind.[Error]
        Me.FlatAlertBox1.Location = New System.Drawing.Point(450, 2)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(342, 42)
        Me.FlatAlertBox1.TabIndex = 41
        Me.FlatAlertBox1.Text = "Aucune partie sélectionnée"
        Me.FlatAlertBox1.Visible = False
        '
        'FlatButton5
        '
        Me.FlatButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.DarkGreen
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(805, 6)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = True
        Me.FlatButton5.Size = New System.Drawing.Size(198, 32)
        Me.FlatButton5.TabIndex = 40
        Me.FlatButton5.Text = "LANCER LA PARTIE"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton6.Location = New System.Drawing.Point(12, 6)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(36, 32)
        Me.FlatButton6.TabIndex = 2
        Me.FlatButton6.Text = "<"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(62, 8)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(141, 30)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "Jeu Libre Solo"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel3.Controls.Add(Me.FlatLabel8)
        Me.Panel3.Controls.Add(Me.FlatLabel7)
        Me.Panel3.Controls.Add(Me.FlatLabel6)
        Me.Panel3.Controls.Add(Me.FlatLabel4)
        Me.Panel3.Controls.Add(Me.FlatButton4)
        Me.Panel3.Controls.Add(Me.ListBox1)
        Me.Panel3.Controls.Add(Me.FlatButton1)
        Me.Panel3.Location = New System.Drawing.Point(341, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 486)
        Me.Panel3.TabIndex = 38
        '
        'FlatLabel8
        '
        Me.FlatLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel8.Location = New System.Drawing.Point(106, 369)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(11, 13)
        Me.FlatLabel8.TabIndex = 45
        Me.FlatLabel8.Text = "-"
        '
        'FlatLabel7
        '
        Me.FlatLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(17, 369)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(83, 13)
        Me.FlatLabel7.TabIndex = 44
        Me.FlatLabel7.Text = "Département : "
        '
        'FlatLabel6
        '
        Me.FlatLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.Silver
        Me.FlatLabel6.Location = New System.Drawing.Point(80, 343)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(11, 13)
        Me.FlatLabel6.TabIndex = 43
        Me.FlatLabel6.Text = "-"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(17, 343)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(57, 13)
        Me.FlatLabel4.TabIndex = 42
        Me.FlatLabel4.Text = "Création :"
        '
        'FlatButton4
        '
        Me.FlatButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(14, 400)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(307, 32)
        Me.FlatButton4.TabIndex = 41
        Me.FlatButton4.Text = "Gérer les parties"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(14, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(307, 317)
        Me.ListBox1.TabIndex = 28
        '
        'FlatButton1
        '
        Me.FlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(14, 438)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(307, 32)
        Me.FlatButton1.TabIndex = 39
        Me.FlatButton1.Text = "Nouvelle partie"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 558)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(1015, 23)
        Me.FlatStatusBar1.TabIndex = 41
        Me.FlatStatusBar1.Text = "Alerte d'Urgence 2020 / Jouez en mode libre en gérant vos services de secours com" & _
            "me bon vous semble sans gestion de budget"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SAMU_Centre_15.My.Resources.Resources.Alerte_d_Urgence_2020_blanc_couleur
        Me.PictureBox1.Location = New System.Drawing.Point(784, 512)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'lancerJeuLibreSolo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1015, 581)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlatStatusBar1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "lancerJeuLibreSolo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pic"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlatLabel1 As SAMU_Centre_15.FlatLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FlatButton5 As SAMU_Centre_15.FlatButton
    Friend WithEvents FlatButton4 As SAMU_Centre_15.FlatButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents FlatButton1 As SAMU_Centre_15.FlatButton
    Friend WithEvents FlatButton6 As SAMU_Centre_15.FlatButton
    Friend WithEvents FlatStatusBar1 As SAMU_Centre_15.FlatStatusBar
    Friend WithEvents FlatLabel8 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel7 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel6 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel4 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatAlertBox1 As SAMU_Centre_15.FlatAlertBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
