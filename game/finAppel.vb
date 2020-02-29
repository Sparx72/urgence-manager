Module finAppel


    Public Sub exFinAppel()


        game.Panel4.Visible = False
        game.Panel1.Visible = False
        game.Panel5.Visible = False
        game.PanelCallout.Visible = False
        zoom = 15
        cartevide()
        game.TimerChrono.Enabled = False
        game.chrono = 0


        Dim random As New Random(), rndnbr As Integer
        Randomize()
        rndnbr = random.Next(25000, 100000)
        game.TimerAppel.Interval = rndnbr
        game.TimerAppel.Enabled = True



        'donnés sp
        donnéeAppelSP.TextBox1.Text = ""
        donnéeAppelSP.TextBox2.Text = ""
        donnéeAppelSP.TextBox3.Text = ""
        donnéeAppelSP.TextBox4.Text = ""
        donnéeAppelSP.TextBox5.Text = ""
        donnéeAppelSP.TextBox6.Text = ""
        donnéeAppelSP.TextBox7.Text = ""
        donnéeAppelSP.ComboBox1.Text = ""
        donnéeAppelSP.ComboBox2.Text = ""
        donnéeAppelSP.FlatComboBox3.Text = ""

        'données fdo
        donnéeAppelFDO.TextBox1.Text = ""
        donnéeAppelFDO.TextBox2.Text = ""
        donnéeAppelFDO.TextBox3.Text = ""
        donnéeAppelFDO.TextBox4.Text = ""
        donnéeAppelFDO.TextBox5.Text = ""
        donnéeAppelFDO.TextBox6.Text = ""
        donnéeAppelFDO.TextBox7.Text = ""
        donnéeAppelFDO.ComboBox1.Text = ""
        donnéeAppelFDO.FlatComboBox3.Text = ""


        'donnés samu
        donnéeAppelSAMU.TextBox1.Text = ""
        donnéeAppelSAMU.TextBox2.Text = ""
        donnéeAppelSAMU.TextBox3.Text = ""
        donnéeAppelSAMU.TextBox4.Text = ""
        donnéeAppelSAMU.TextBox5.Text = ""
        donnéeAppelSAMU.TextBox6.Text = ""
        donnéeAppelSAMU.TextBox7.Text = ""
        donnéeAppelSAMU.TextBox8.Text = ""
        donnéeAppelSAMU.TextBox9.Text = ""
        donnéeAppelSAMU.TextBox10.Text = ""
        donnéeAppelSAMU.ComboBox1.Text = ""
        donnéeAppelSAMU.ComboBox2.Text = ""
        donnéeAppelSAMU.FlatComboBox3.Text = ""

    End Sub

End Module
