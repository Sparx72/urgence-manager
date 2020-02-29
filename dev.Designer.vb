<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dev
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
        Me.FlatLabel1 = New SAMU_Centre_15.FlatLabel()
        Me.FlatButton1 = New SAMU_Centre_15.FlatButton()
        Me.FlatCheckBox1 = New SAMU_Centre_15.FlatCheckBox()
        Me.FlatButton2 = New SAMU_Centre_15.FlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlatLabel1
        '
        Me.FlatLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FlatLabel1.Location = New System.Drawing.Point(209, 90)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(461, 113)
        Me.FlatLabel1.TabIndex = 0
        Me.FlatLabel1.Text = "Urgence Manager 2020 est en cours de développement et n'est pas disponible pour l" & _
            "e moment. N'hésitez pas à nous suivre sur les réseaux sociaux pour suivre le dév" & _
            "eloppement du jeu."
        Me.FlatLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FlatButton1
        '
        Me.FlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(365, 219)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = True
        Me.FlatButton1.Size = New System.Drawing.Size(149, 32)
        Me.FlatButton1.TabIndex = 1
        Me.FlatButton1.Text = "Fermer"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatCheckBox1
        '
        Me.FlatCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatCheckBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatCheckBox1.Checked = False
        Me.FlatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatCheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatCheckBox1.ForeColor = System.Drawing.Color.White
        Me.FlatCheckBox1.Location = New System.Drawing.Point(232, 289)
        Me.FlatCheckBox1.Name = "FlatCheckBox1"
        Me.FlatCheckBox1.Options = SAMU_Centre_15.FlatCheckBox._Options.Style1
        Me.FlatCheckBox1.Size = New System.Drawing.Size(414, 22)
        Me.FlatCheckBox1.TabIndex = 2
        Me.FlatCheckBox1.Text = "Je souhaite tester cette version de développement (Très instable)"
        '
        'FlatButton2
        '
        Me.FlatButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(275, 329)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = True
        Me.FlatButton2.Size = New System.Drawing.Size(329, 32)
        Me.FlatButton2.TabIndex = 3
        Me.FlatButton2.Text = "Utiliser cette build de développement"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatButton2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SAMU_Centre_15.My.Resources.Resources.Urgence_Manager_2020_blanc_couleur
        Me.PictureBox1.Location = New System.Drawing.Point(647, 396)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'dev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(878, 448)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatCheckBox1)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.FlatLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dev"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Version de développement"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlatLabel1 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatButton1 As SAMU_Centre_15.FlatButton
    Friend WithEvents FlatCheckBox1 As SAMU_Centre_15.FlatCheckBox
    Friend WithEvents FlatButton2 As SAMU_Centre_15.FlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
