<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class departement
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
        Me.FlatComboBox2 = New SAMU_Centre_15.FlatComboBox()
        Me.FlatLabel5 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel9 = New SAMU_Centre_15.FlatLabel()
        Me.SuspendLayout()
        '
        'FlatComboBox2
        '
        Me.FlatComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.FlatComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatComboBox2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox2.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox2.FormattingEnabled = True
        Me.FlatComboBox2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatComboBox2.ItemHeight = 18
        Me.FlatComboBox2.Items.AddRange(New Object() {"Marseille", "01 Ain", "02 Aisne", "03 Allier", "04 Alpes-de-Haute-Provence", "05 Hautes-Alpes", "06 Alpes-Maritimes", "07 Ardèche", "08 Ardennes", "09 Ariège", "10 Aube", "11 Aude", "12 Aveyron", "13 Bouches-du-Rhône", "14 Calvados", "15 Cantal", "16 Charente", "17 Charente-Maritime", "18 Cher", "19 Corrèze", "2A Corse-du-Sud", "2B Haute-Corse", "21 Côte-d'Or", "22 Côtes d'Armor", "23 Creuse", "24 Dordogne", "25 Doubs", "26 Drôme", "27 Eure", "28 Eure-et-Loir", "29 Finistère", "30 Gard", "31 Haute-Garonne", "32 Gers", "33 Gironde", "34 Hérault", "35 Ille-et-Vilaine", "36 Indre", "37 Indre-et-Loire", "38 Isère", "39 Jura", "40 Landes", "41 Loir-et-Cher", "42 Loire", "43 Haute-Loire", "44 Loire-Atlantique", "45 Loiret", "46 Lot", "47 Lot-et-Garonne", "48 Lozère", "49 Maine-et-Loire", "50 Manche", "51 Marne", "52 Haute-Marne", "53 Mayenne", "54 Meurthe-et-Moselle", "55 Meuse", "56 Morbihan", "57 Moselle", "58 Nièvre", "59 Nord", "60 Oise", "61 Orne", "62 Pas-de-Calais", "63 Puy-de-Dôme", "64 Pyrénées-Atlantiques", "65 Hautes-Pyrénées", "66 Pyrénées-Orientales", "67 Bas-Rhin", "68 Haut-Rhin", "69 Rhône", "70 Haute-Saône", "71 Saône-et-Loire", "72 Sarthe", "73 Savoie", "74 Haute-Savoie", "75 Paris", "76 Seine-Maritime", "77 Seine-et-Marne", "78 Yvelines", "79 Deux-Sèvres", "80 Somme", "81 Tarn", "82 Tarn-et-Garonne", "83 Var", "84 Vaucluse", "85 Vendée", "86 Vienne", "87 Haute-Vienne", "88 Vosges", "89 Yonne", "90 Territoire de Belfort", "91 Essonne", "92 Hauts-de-Seine", "93 Seine-St-Denis", "94 Val-de-Marne", "95 Val-D'Oise", "971 Guadeloupe", "972 Martinique", "973 Guyane", "974 La Réunion", "976 Mayotte"})
        Me.FlatComboBox2.Location = New System.Drawing.Point(24, 96)
        Me.FlatComboBox2.Name = "FlatComboBox2"
        Me.FlatComboBox2.Size = New System.Drawing.Size(390, 24)
        Me.FlatComboBox2.TabIndex = 48
        '
        'FlatLabel5
        '
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FlatLabel5.Location = New System.Drawing.Point(21, 57)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(689, 27)
        Me.FlatLabel5.TabIndex = 47
        Me.FlatLabel5.Text = "Choisir le département que vous souhaitez couvrir pour la réception des appels :"
        '
        'FlatLabel9
        '
        Me.FlatLabel9.AutoSize = True
        Me.FlatLabel9.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel9.ForeColor = System.Drawing.Color.White
        Me.FlatLabel9.Location = New System.Drawing.Point(16, 18)
        Me.FlatLabel9.Name = "FlatLabel9"
        Me.FlatLabel9.Size = New System.Drawing.Size(122, 25)
        Me.FlatLabel9.TabIndex = 46
        Me.FlatLabel9.Text = "Département"
        '
        'departement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(737, 467)
        Me.Controls.Add(Me.FlatComboBox2)
        Me.Controls.Add(Me.FlatLabel5)
        Me.Controls.Add(Me.FlatLabel9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "departement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "cartographie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatComboBox2 As SAMU_Centre_15.FlatComboBox
    Friend WithEvents FlatLabel5 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel9 As SAMU_Centre_15.FlatLabel
End Class
