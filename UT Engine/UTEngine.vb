Imports System.IO

Module UTEngine

    Public Sub scriptUTEngine()




        ' -------- DIMMINUTION DU TEMPS INTERS




        'partie POMPIER

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "cache\UTEngine\18\").GetDirectories()


            Dim interEnCoursUT As String = Repertoires.Name





            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\engins\").GetFiles()

                Dim temps As Integer = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\engins\" & Fichier.Name, "données", "temps")


                'véhicule en route

                If temps > 0 Then

                    temps = temps - 1
                    Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\engins\" & Fichier.Name, "données", "temps", temps)

                End If




                'premier véhicule sur les lieux
                If temps = 0 Then

                    Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\" & Repertoires.Name & ".ini", "données", "état", "Sur les lieux")

                End If


            Next




            'ajout du temps sll


            If Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\" & interEnCoursUT & ".ini", "données", "état") = "Sur les lieux" Then


                If Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\" & interEnCoursUT & ".ini", "données", "tempsSll") = "" Then
                    Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\" & interEnCoursUT & ".ini", "données", "tempsSll", "0")
                End If

                Dim tempsSll As Integer = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\" & interEnCoursUT & ".ini", "données", "tempsSll")
                tempsSll = tempsSll + 1
                Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\" & interEnCoursUT & ".ini", "données", "tempsSll", tempsSll)






                'lecture des messages radio


                Dim interChargéUT As String = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\" & interEnCoursUT & ".ini", "données", "interChargé")

                For Each Fichiers As FileInfo In New DirectoryInfo(appdata & "workshop\callout\" & interChargéUT & "\messages\").GetFiles()



                    MsgBox(Cls_Ini.INIRead(appdata & "workshop\callout\" & interChargéUT & "\messages\" & Fichiers.Name, "données", "temps"))


                    'en fonction du temps sll

                    If Cls_Ini.INIRead(appdata & "workshop\callout\" & interChargéUT & "\radio\" & Fichiers.Name, "données", "temps") = tempsSll Then



                        UTEngineSPmessage.TopLevel = False
                        Form1.Panel6.Controls.Clear()
                        UTEngineSPmessage.FlatLabel1.Text = "CODIS de " & Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCoursUT & "\engins\" & "VSAV 01 Indéterminé", "données", "nom") & " " & Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "message")
                        Form1.Panel6.Controls.Add(UTEngineSPmessage)
                        UTEngineSPmessage.Show()
                        Form1.Panel6.Visible = True


                        Try
                            If Cls_Ini.INIRead(appdata & "config.ini", "données", "voix") = "oui" Then
                                Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
                                Form1.parole.SpeakAsync(UTEngineSPmessage.FlatLabel1.Text)
                            End If

                        Catch ex As Exception
                        End Try




                    End If


                Next


            End If


        Next


    End Sub

End Module
