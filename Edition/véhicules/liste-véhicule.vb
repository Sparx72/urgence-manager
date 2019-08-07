Module liste_véhicule

    Public Sub véhiculeSP()

        nouveauVéhicule.ListBox1.Items.Clear()

        'principaux
        nouveauVéhicule.ListBox1.Items.Add("[CCFM] Camion Citerne Feu de Forêt Moyen")
        nouveauVéhicule.ListBox1.Items.Add("[FPT] Fourgon Pompe-Tonne")
        nouveauVéhicule.ListBox1.Items.Add("[FPTSR] Fourgon Pompe-Tonne Secours Routier")
        nouveauVéhicule.ListBox1.Items.Add("[FSR] Fourgon Secours Routier")

        nouveauVéhicule.ListBox1.Items.Add("[VID] Véhicule d'Interventions Diverses")

        nouveauVéhicule.ListBox1.Items.Add("[VLI] Véhicule Léger Infirmier")
        nouveauVéhicule.ListBox1.Items.Add("[VLM] Véhicule Léger Médicalisé")

        nouveauVéhicule.ListBox1.Items.Add("[VPRO] Véhicule de Protection")
        nouveauVéhicule.ListBox1.Items.Add("[VTU] Véhicule Tout Usages")
        nouveauVéhicule.ListBox1.Items.Add("[VTUTP] Véhicule Tout Usages Transport de Personnel")

        nouveauVéhicule.ListBox1.Items.Add("[VSAV] Véhicule de Secours et d'Assistance aux Victimes")
        nouveauVéhicule.ListBox1.Items.Add("[VSAVHR] Véhicule de Secours et d'Assistance aux Victimes Hors Route")

        nouveauVéhicule.ListBox1.Items.Add("[VSR] Véhicule Secours Routier")

        nouveauVéhicule.ListBox1.Items.Add("[VSS] Véhicule de Soutien Sanitaire")

    End Sub


    Public Sub véhiculeFDO()

        nouveauVéhicule.ListBox1.Items.Clear()

    End Sub


    Public Sub véhiculeSAMU()

        nouveauVéhicule.ListBox1.Items.Clear()

        'principaux
        nouveauVéhicule.ListBox1.Items.Add("[VLM] Véhicule Léger Médicalisé")

    End Sub


    Public Sub véhiculeSC()

        nouveauVéhicule.ListBox1.Items.Clear()

    End Sub



    Public Sub véhiculeDIR()

        nouveauVéhicule.ListBox1.Items.Clear()

    End Sub


    Public Sub véhiculeRDF()

        nouveauVéhicule.ListBox1.Items.Clear()

    End Sub

End Module
