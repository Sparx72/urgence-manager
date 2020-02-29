<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cartographie
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
        Me.FlatNumeric1 = New SAMU_Centre_15.FlatNumeric()
        Me.FlatLabel10 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel2 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel4 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel3 = New SAMU_Centre_15.FlatLabel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FlatLabel1 = New SAMU_Centre_15.FlatLabel()
        Me.FlatCheckBox1 = New SAMU_Centre_15.FlatCheckBox()
        Me.FlatLabel8 = New SAMU_Centre_15.FlatLabel()
        Me.FlatComboBox1 = New SAMU_Centre_15.FlatComboBox()
        Me.FlatLabel6 = New SAMU_Centre_15.FlatLabel()
        Me.FlatLabel7 = New SAMU_Centre_15.FlatLabel()
        Me.SuspendLayout()
        '
        'FlatNumeric1
        '
        Me.FlatNumeric1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatNumeric1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatNumeric1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FlatNumeric1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatNumeric1.ForeColor = System.Drawing.Color.White
        Me.FlatNumeric1.Location = New System.Drawing.Point(345, 182)
        Me.FlatNumeric1.Maximum = CType(20, Long)
        Me.FlatNumeric1.Minimum = CType(1, Long)
        Me.FlatNumeric1.Name = "FlatNumeric1"
        Me.FlatNumeric1.Size = New System.Drawing.Size(75, 30)
        Me.FlatNumeric1.TabIndex = 55
        Me.FlatNumeric1.Text = "FlatNumeric1"
        Me.FlatNumeric1.Value = CType(1, Long)
        '
        'FlatLabel10
        '
        Me.FlatLabel10.AutoSize = True
        Me.FlatLabel10.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel10.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel10.ForeColor = System.Drawing.Color.White
        Me.FlatLabel10.Location = New System.Drawing.Point(27, 192)
        Me.FlatLabel10.Name = "FlatLabel10"
        Me.FlatLabel10.Size = New System.Drawing.Size(231, 13)
        Me.FlatLabel10.TabIndex = 54
        Me.FlatLabel10.Text = "Niveau de zoom (1 = éloigné, 20 = proche) :"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FlatLabel2.Location = New System.Drawing.Point(27, 61)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(683, 27)
        Me.FlatLabel2.TabIndex = 53
        Me.FlatLabel2.Text = "Indiquez les coordonnées GPS du lieu que vous souhaitez afficher/centrer au lance" & _
            "ment de cette partie :"
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(22, 22)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(247, 25)
        Me.FlatLabel4.TabIndex = 52
        Me.FlatLabel4.Text = "Point d'affichage de la carte"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(24, 149)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(66, 13)
        Me.FlatLabel3.TabIndex = 51
        Me.FlatLabel3.Text = "Longitude :"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(96, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(324, 27)
        Me.TextBox4.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(96, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(324, 27)
        Me.TextBox1.TabIndex = 49
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(24, 116)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(55, 13)
        Me.FlatLabel1.TabIndex = 50
        Me.FlatLabel1.Text = "Latitude :"
        '
        'FlatCheckBox1
        '
        Me.FlatCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.FlatCheckBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatCheckBox1.Checked = False
        Me.FlatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatCheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatCheckBox1.Location = New System.Drawing.Point(30, 433)
        Me.FlatCheckBox1.Name = "FlatCheckBox1"
        Me.FlatCheckBox1.Options = SAMU_Centre_15.FlatCheckBox._Options.Style1
        Me.FlatCheckBox1.Size = New System.Drawing.Size(390, 22)
        Me.FlatCheckBox1.TabIndex = 60
        Me.FlatCheckBox1.Text = "Afficher coordonnées GPS lors d'un clic sur la carte"
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(25, 393)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(275, 25)
        Me.FlatLabel8.TabIndex = 59
        Me.FlatLabel8.Text = "Coordonnées GPS lors d'un clic"
        '
        'FlatComboBox1
        '
        Me.FlatComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.FlatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox1.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox1.FormattingEnabled = True
        Me.FlatComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatComboBox1.ItemHeight = 18
        Me.FlatComboBox1.Items.AddRange(New Object() {"Mapbox streets-satellite", "OSM France"})
        Me.FlatComboBox1.Location = New System.Drawing.Point(30, 326)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New System.Drawing.Size(390, 24)
        Me.FlatComboBox1.TabIndex = 58
        '
        'FlatLabel6
        '
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FlatLabel6.Location = New System.Drawing.Point(27, 296)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(307, 27)
        Me.FlatLabel6.TabIndex = 57
        Me.FlatLabel6.Text = "Choisissez un fond de carte pour cette partie :"
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(22, 257)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(201, 25)
        Me.FlatLabel7.TabIndex = 56
        Me.FlatLabel7.Text = "Rendu cartographique"
        '
        'cartographie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(737, 467)
        Me.Controls.Add(Me.FlatCheckBox1)
        Me.Controls.Add(Me.FlatLabel8)
        Me.Controls.Add(Me.FlatComboBox1)
        Me.Controls.Add(Me.FlatLabel6)
        Me.Controls.Add(Me.FlatLabel7)
        Me.Controls.Add(Me.FlatNumeric1)
        Me.Controls.Add(Me.FlatLabel10)
        Me.Controls.Add(Me.FlatLabel2)
        Me.Controls.Add(Me.FlatLabel4)
        Me.Controls.Add(Me.FlatLabel3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FlatLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cartographie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "cartographie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlatNumeric1 As SAMU_Centre_15.FlatNumeric
    Friend WithEvents FlatLabel10 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel2 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel4 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel3 As SAMU_Centre_15.FlatLabel
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FlatLabel1 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatCheckBox1 As SAMU_Centre_15.FlatCheckBox
    Friend WithEvents FlatLabel8 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatComboBox1 As SAMU_Centre_15.FlatComboBox
    Friend WithEvents FlatLabel6 As SAMU_Centre_15.FlatLabel
    Friend WithEvents FlatLabel7 As SAMU_Centre_15.FlatLabel
End Class
