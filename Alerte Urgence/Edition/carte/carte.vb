Imports System.IO
Module carte

    Public renduCarte As String = "sat"

    Public latInter As String
    Public lonInter As String

    Public lonSMURC15 As String
    Public latSMURC15 As String
    Public descriptionSMURC15 As String

    Public lonSMUR2 As String
    Public latSMUR2 As String
    Public descriptionSMUR2 As String

    Public lonSMUR3 As String
    Public latSMUR3 As String
    Public descriptionSMUR3 As String

    Public lonSMUR4 As String
    Public latSMUR4 As String
    Public descriptionSMUR4 As String

    Public lonSMUR5 As String
    Public latSMUR5 As String
    Public descriptionSMUR5 As String

    Public lonSMUR6 As String
    Public latSMUR6 As String
    Public descriptionSMUR6 As String

    Public lonSMUR7 As String
    Public latSMUR7 As String
    Public descriptionSMUR7 As String

    Public lonSMUR8 As String
    Public latSMUR8 As String
    Public descriptionSMUR8 As String

    Public lonSMUR9 As String
    Public latSMUR9 As String
    Public descriptionSMUR9 As String

    Public lonSMUR10 As String
    Public latSMUR10 As String
    Public descriptionSMUR10 As String

    Public Sub cartevide()



        '//Définir variable

        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte") = "sat" Then
            renduCarte = "sat"
        ElseIf Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte") = "OSM" Then
            renduCarte = "OSM"
        Else
            renduCarte = "sat"
        End If


        Dim zoom As String = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom")
        If zoom = "" Then
            zoom = "12"
        End If




        Dim sw As New StreamWriter(appdata & "cache/" & "carte.html", False, System.Text.Encoding.UTF8)


        'entête
        sw.WriteLine("<!DOCTYPE html>")
        sw.WriteLine("<html>")
        sw.WriteLine("<head>")
        sw.WriteLine("<meta charset=""utf-8""/>")
        sw.WriteLine("<link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.css"" integrity=""sha512-Rksm5RenBEKSKFjgI3a41vrjkw4EVPlJ3+OiI65vTjIdo9brlAacEuKOiQ5OFh7cOI1bkDwLqdLw3Zg0cRJAAQ=="" crossorigin="""" />")
        sw.WriteLine("<script src=""https://unpkg.com/leaflet@1.3.1/dist/leaflet.js"" integrity=""sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw=="" crossorigin=""""></script>")


        'centrer carte
        sw.WriteLine("<script type=""text/javascript"">")

        Dim latDefaut As String = "48.833"
        Dim lonDefaut As String = "2.333"

        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat") <> "" And Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon") <> "" Then

            latDefaut = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat")
            lonDefaut = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon")

        End If



        If latInter <> "" And lonInter <> "" Then
            sw.WriteLine("var lat = " & latInter & ";")
            sw.WriteLine("var lon = " & lonInter & ";")
        Else
            sw.WriteLine("var lat = " & latDefaut & ";")
            sw.WriteLine("var lon = " & lonDefaut & ";")
            sw.WriteLine("var zoom = " & zoom & ";")
        End If


        sw.WriteLine("var macarte = null;")


        'initialisation carte
        sw.WriteLine("function initMap() {")
        sw.WriteLine("macarte = L.map('map').setView([lat, lon], zoom);")


        If renduCarte = "OSM" Then
            sw.WriteLine("L.tileLayer('http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {")
            sw.WriteLine("attribution: 'Données : © OpenStreetMap/ODbL - Rendu : OSM France',")
        End If

        If renduCarte = "sat" Then
            sw.WriteLine("L.tileLayer('https://api.tiles.mapbox.com/v4/{id}/{z}/{x}/{y}.png?access_token=pk.eyJ1IjoiYW50cjcyIiwiYSI6ImNqdTVncXRpODBrYjUzeW81bnBpMHpydGwifQ.MjB953HsGxS6bicFwQuYHQ', {")
            sw.WriteLine("attribution: 'Données : © OpenStreetMap/ODbL - Contributeur : CC-BY-SA - Rendu : Mapbox',")
            sw.WriteLine("id: 'mapbox.streets-satellite',")
        End If

        sw.WriteLine("minZoom: 1,")
        sw.WriteLine("maxZoom: 20")
        sw.WriteLine("}).addTo(macarte);")



        '//// AJOUT DES ICONES


        'icone appel
        sw.WriteLine("var iconeAppel = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/14/6/1554554988-emergencyphone.png',")
        sw.WriteLine("iconSize: [32, 37] });")


        'icone smur cpi
        sw.WriteLine("var iconeCPI = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/21/4/1558614163-cpi.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone smur cs
        sw.WriteLine("var iconeCS = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/21/4/1558614171-cs.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone smur csp
        sw.WriteLine("var iconeCSP = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/21/4/1558614173-csp.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone smur cta
        sw.WriteLine("var iconeCTA = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/21/4/1558614174-ctai.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone smur ddis
        sw.WriteLine("var iconeDDIS = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/21/4/1558614175-ddis.png',")
        sw.WriteLine("iconSize: [37, 18] });")



        'icone hpn
        sw.WriteLine("var iconeHPN = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559741531-hpn.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone pn
        sw.WriteLine("var iconePN = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559741800-pn.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone pm
        sw.WriteLine("var iconePM = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559742301-pm.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone gn
        sw.WriteLine("var iconeGN = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/22/3/1559161840-gn.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone bri
        sw.WriteLine("var iconeBRI = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559742496-bri.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone agign
        sw.WriteLine("var iconeAGIGN = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559742540-agign.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone psig
        sw.WriteLine("var iconePSIG = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559742626-psig.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone araid
        sw.WriteLine("var iconeARAID = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559742693-raid.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone cic
        sw.WriteLine("var iconeCIC = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559742759-cic.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone cog
        sw.WriteLine("var iconeCOG = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559742778-cog.png',")
        sw.WriteLine("iconSize: [37, 18] });")


        'icone smur
        sw.WriteLine("var iconeSMUR = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/1/1554711511-smur.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone ch
        sw.WriteLine("var iconeCH = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559743873-ch.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone ap
        sw.WriteLine("var iconeAP = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559743912-ap.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone C15
        sw.WriteLine("var iconeC15 = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559744073-c15.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone uiisc
        sw.WriteLine("var iconeUIISC = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/6/1559986363-uiisc.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone basc
        sw.WriteLine("var iconeBASC = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559744871-basc.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone ghsc
        sw.WriteLine("var iconeGHSC = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559744953-ghsc.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone rcsc
        sw.WriteLine("var iconeRCSC = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559744976-rcsc.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone crf
        sw.WriteLine("var iconeCRF = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559745031-crf.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone adpc
        sw.WriteLine("var iconeADPC = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559745090-anpc.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone snsm
        sw.WriteLine("var iconeSNSM = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559745130-snsm.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone dir
        sw.WriteLine("var iconeDIR = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559745444-dir.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone patr
        sw.WriteLine("var iconePATR = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559745511-patr.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone erdf
        sw.WriteLine("var iconeERDF = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/23/3/1559745656-erdf.png',")
        sw.WriteLine("iconSize: [37, 18] });")

        'icone grdf
        sw.WriteLine("var iconeGRDF = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/26/1/1561393972-grdf.png',")
        sw.WriteLine("iconSize: [37, 18] });")





        'icone avp
        sw.WriteLine("var iconeAVP = L.icon({")
        sw.WriteLine("iconUrl: 'http://image.noelshack.com/fichiers/2019/24/1/1560156839-grdf.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone défenestration
        sw.WriteLine("var iconeDefenestre = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987187-defensetration.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone agression
        sw.WriteLine("var iconeAgression = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987269-agression.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone noyade
        sw.WriteLine("var iconeNoyade = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987394-noyade.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone arme
        sw.WriteLine("var iconeArme = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987466-arme-a-feu.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone couteau
        sw.WriteLine("var iconeCouteau = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987570-arme-blanche.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone sport
        sw.WriteLine("var iconeSport = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987781-sport.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone sport
        sw.WriteLine("var iconePendu = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987833-pendu.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone feu
        sw.WriteLine("var iconeFeu = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987891-feu.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone feu
        sw.WriteLine("var iconeExplosion = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554987964-explosion.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone écrasement
        sw.WriteLine("var iconeEcrasement = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988057-ecasement.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone toxique
        sw.WriteLine("var iconeToxique = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988101-toxique.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone chute
        sw.WriteLine("var iconeChute = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988188-chute.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone élec
        sw.WriteLine("var iconeElec = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988263-lect.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone pro
        sw.WriteLine("var iconePro = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988349-trauma-pro.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone maison
        sw.WriteLine("var iconeMaison = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988418-pro-maison.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone secondaire
        sw.WriteLine("var iconeSecondaire = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988465-secondaire.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone autre
        sw.WriteLine("var iconeAutre = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988549-autre.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone cata
        sw.WriteLine("var iconeCata = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988583-cata.png',")
        sw.WriteLine("iconSize: [32, 37] });")

        'icone zero
        sw.WriteLine("var iconeZero = L.icon({")
        sw.WriteLine("iconUrl: 'https://image.noelshack.com/fichiers/2019/15/4/1554988608-non-trauma.png',")
        sw.WriteLine("iconSize: [32, 37] });")


        '//// AJOUT DES MARQUEURS

        'ajouter marqueur intervention
        If latInter <> "" Or lonInter <> "" Then
            sw.WriteLine("var marker = L.marker([" & latInter & ", " & lonInter & "],{icon: iconeAppel}).addTo(macarte)")
            sw.WriteLine(".bindPopup('<b>Appel au Centre 15</b>');")
        End If








        '//// AJOUT DES SAPEURS-POMPIERS

        If partieEnCours <> "" Then

            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\").GetDirectories()

                'CIS
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Centre d'Incendie et de Secours (CIS)" Then



                    'CSP
                    If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "sous-type") = "Centre de Secours Principal (CSP)" Then

                        Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                        Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                        Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                        Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                        nom = nom.Replace("'", "\'")

                        sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCSP}).addTo(macarte)")
                        sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                    End If


                    'CS
                    If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "sous-type") = "Centre de Secours (CS)" Then

                        Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                        Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                        Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                        Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                        nom = nom.Replace("'", "\'")

                        sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCS}).addTo(macarte)")
                        sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                    End If



                    'CPI
                    If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "sous-type") = "Centre de Première Intervention (CPI)" Then

                        Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                        Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                        Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                        Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                        nom = nom.Replace("'", "\'")

                        sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCPI}).addTo(macarte)")
                        sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                    End If



                End If

                'CTA
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Centre Opérationnel Départemental d'Incendie et de Secours (CTA-CODIS)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCTA}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'DDIS
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Direction Départementale d'Incendie et de Secours (DDIS)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeDDIS}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If

            Next



        End If






        '//// AJOUT POLICE GENDARMERIE



        If partieEnCours <> "" Then

            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\fdo\").GetDirectories()


                'HPN
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Hôtel de Police" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeHPN}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'PN
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Commissariat de Police Nationale" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeHPN}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'PM
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Bureau de Police Municipale" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconePM}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'GN
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Brigade de Gendarmerie" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeGN}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'BRI
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Brigade Rapide d'Intervention (BRI)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeBRI}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'AGIGN
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Antenne GIGN" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeAGIGN}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'PSIG
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Peloton de surveillance et d'intervention de la Gendarmerie (PSIG)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconePSIG}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'ARAID
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Antenne RAID" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeARAID}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If




                'CIC
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Centre d'Information et de Commandement (CIC)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCIC}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If




                'COG
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Centre Opérationnel de Gendarmerie (COG)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCOG}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


            Next

        End If





        '//// AJOUT DU SAMU

        If partieEnCours <> "" Then

            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\samu\").GetDirectories()


                'SMUR
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Service Mobile d'Urgence et de Réanimation (SMUR)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeSMUR}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'CH
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Centre Hospitalier (CH)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCH}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'AP
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Société d'Ambulance Privée" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeAP}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'C15
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Centre de Réception et de Régulation des Appels - Centre 15" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeC15}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


            Next

        End If






        '//// AJOUT SÉCURITÉ CIVILE ET ASSOCIATIONS AGRÉES

        If partieEnCours <> "" Then

            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sc\").GetDirectories()



                'UIISC
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Unité d'Instruction et d'Intervention de la Sécurité-Civile (UIISC)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeUIISC}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'BASC
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Base d'Avions de la Sécurité Civile (BASC)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeBASC}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'GHSC
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Groupement d'Hélicoptères de la Sécurité Civile (GHSC)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeGHSC}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'RCSC
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Réserves communales de sécurité civile (RCSC)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeRCSC}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'CRF
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Croix Rouge Française (CRF)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeCRF}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If



                'ADPC
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Association Départementale de Protection Civile (ADPC)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeADPC}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'SNSM
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Société Nationale de Sauvetage en Mer (SNSM)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeSNSM}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If

            Next

        End If





        '//// AJOUT DE LA DIR

        If partieEnCours <> "" Then

            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\dir\").GetDirectories()


                'DIR
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Direction Interdépartementale des Routes (DIR)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeDIR}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'PATR
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Patrouilleur Autoroutier" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconePATR}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


            Next

        End If






        '//// AJOUT ERDF ET GRDF

        If partieEnCours <> "" Then

            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\rdf\").GetDirectories()


                'DIR
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Électricité Réseau Distribution de France (ENEDIS)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeERDF}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


                'PATR
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "type") = "Gaz Réseau Distribution de France (GRDF)" Then

                    Dim lat = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat")
                    Dim lon = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon")
                    Dim nom = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "nom")
                    Dim img = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "urlImage")
                    nom = nom.Replace("'", "\'")

                    sw.WriteLine("var marker = L.marker([" & lat & ", " & lon & "],{icon: iconeGRDF}).addTo(macarte)")
                    sw.WriteLine(".bindPopup('<b><center>" & nom & "</center></b></br><img style=""width: 200px;"" src=""" & img & """/>');")

                End If


            Next

        End If




        'script pour afficher les coordonnées
        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick") = "oui" Then
            sw.WriteLine("var popup = L.popup();")
            sw.WriteLine("function onMapClick(e) {")
            sw.WriteLine("popup")
            sw.WriteLine(".setLatLng(e.latlng)")
            sw.WriteLine(".setContent(""Coordonnées GPS : "" + e.latlng.toString())")
            sw.WriteLine(".openOn(macarte);")
            sw.WriteLine("}")
            sw.WriteLine("macarte.on('click', onMapClick);")
        End If
        






        'suite
        sw.WriteLine("}")
        sw.WriteLine("window.onload = function(){")
        sw.WriteLine("initMap(); ")
        sw.WriteLine("};")
        sw.WriteLine("</script>")
        sw.WriteLine("<style type=""text/css"">")
        sw.WriteLine("#map{")
        sw.WriteLine("height:" & Form1.WebBrowser2.Height - 22 & "px;")
        sw.WriteLine("margin-left:-10px;")
        sw.WriteLine("margin-top:-15px;")
        sw.WriteLine("margin-right:-10px;")
        sw.WriteLine("margin-buttom:-10px;")
        sw.WriteLine("</style>")
        sw.WriteLine("<title>Carte</title>")
        sw.WriteLine("</head>")
        sw.WriteLine("<body>")
        sw.WriteLine("<div id=""map"">")
        sw.WriteLine("</div>")
        sw.WriteLine("</body>")
        sw.WriteLine("</html>")



        sw.Close()

        Form1.WebBrowser2.Navigate(appdata & "cache/" & "carte.html")
    End Sub

End Module
