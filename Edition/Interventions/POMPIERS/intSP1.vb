Imports System.Speech.Recognition

Module intSP1


    Dim reco As New SpeechRecognitionEngine
    Dim voca As New GrammarBuilder

    Public Sub int1données()

        'données générales
        typeAdresseAppel = "maison"


        

    End Sub


    Public Sub int1SPquestion()


        'informations générales
        typeAdresseAppel = "maison"




        'question et réponnses

        Dim tempreponseSP As String = reponseSP


        
        If questionSP.Contains("POMPIER") Then
            reponseSP = "Oui bonjour je vous appel car j'ai ma maison qui commence à prendre feu là !"
        End If

        If questionSP.Contains("INTÉRIEUR") Or questionSP.Contains("DEDANS") Or questionSP.Contains("ENCORE DU MONDE") Then
            reponseSP = "Non non nous sommes tous sortis... mais faites vite ça brûle vite !"
        End If

        If questionSP.Contains("POMPIER") And questionSP.Contains("ARRIV") Or questionSP.Contains("POMPIER") And questionSP.Contains("PARTI") Then
            reponseSP = "Ok merci on vous attend !"
        End If

        If questionSP.Contains("TAGE") Then
            reponseSP = "Euh un seul étage"
        End If

        If questionSP.Contains("AUTRE") And questionSP.Contains("MAISON") Or questionSP.Contains("AUTRE") And questionSP.Contains("HABIT") Then
            reponseSP = "Oui mais il y a un grand jardin elles ne sont pas acollées "
        End If

        If questionSP.Contains("ORIGINE") Then
            reponseSP = "Je suis pas sûr mais peut être de la cuisine ! Mais ça se propage trop vite... !"
        End If

        If questionSP.Contains("VILLE") Or questionSP.Contains("COMMUNE") Then
            reponseSP = "On est dans la ville de " & villeAppel
        End If

        If questionSP.Contains("ADRESSE") Or questionSP.Contains("RUE") Then
            reponseSP = "Euh " & adresseAppel
        End If

        If reponseSP = tempreponseSP Then
            reponseSP = ""
        End If


        'affichage de la réponse
        cta_codis.FlatLabel9.Text = reponseSP
        cta_codis.TextBox5.Text = ""

        Try
            If Appels.FlatToggle2.Checked = True Then
                Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
                Form1.parole.SpeakAsync(reponseSP)
            End If
            
        Catch ex As Exception
        End Try

    End Sub

    


End Module
