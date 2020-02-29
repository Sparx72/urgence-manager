Imports System.IO

Public Class vehicules

    Public centreVehicule As String


    Public Sub actualiserVehicule()

        ListBox2.Items.Clear()
        For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & centreVehicule).GetFiles()
            Me.ListBox2.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & centreVehicule & "\" & Fichier.Name, "données", "nom"))
        Next



    End Sub

    Private Sub vehicules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlatButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton20.Click

        actualiserVehicule()

    End Sub

    Private Sub FlatButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton12.Click

        Me.Close()
        centreIncendieSecours.Close()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Me.Close()

    End Sub


End Class