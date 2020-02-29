Imports System.IO

Public Class demarrage


    Enum FsModifiers
        None = 0
        Alt = 1
        Control = 2
        Shift = 4
        Windows = 8
        Alt_Ctrl = 3
        Alt_Shift = 5
        Alt_Windows = 9
        Ctrl_Shift = 6
        Ctrl_Windows = 10
        Shift_Windows = 12
        No_Repeat = 16384
    End Enum
    Declare Auto Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Integer, ByVal fsModifier As FsModifiers, ByVal vk As Keys) As Boolean
    Declare Auto Function UnregisterHotKey Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal id As Integer) As Integer
    Private Const HOTKEY_CONSOLE As Integer = 571584
    Private Const WM_HOTKEY As Integer = 786


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg 'on va tester le message reçu à chaque appel de cette fonction
            Case WM_HOTKEY 'si il s'agit du message WM_HOTKEY (si l'utilisateur a appuyé sur CTRL + ALT + B)
                If m.WParam = HOTKEY_CONSOLE Then 'on cherche quelle hotkey a déclenché l'évènement
                    console.Show()
                    console.TextBox2.Text = "> "
                    console.TextBox2.SelectionStart = console.TextBox2.Text.Length
                    console.TextBox2.SelectionLength = console.TextBox2.Text.Length
                    console.TextBox2.Focus()
                End If
        End Select
        MyBase.WndProc(m)
    End Sub





    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        End
    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Dim okLancement As Boolean = True


        If File.Exists(Application.StartupPath & "/AxInterop.WMPLib.dll") = False Then
            okLancement = False
            MsgBox("Le fichier AxInterop.WMPLib.dll est manquant. Tentez de réinstallez le jeu ou contactez nous sur le forum d'Urgence Manager.", MsgBoxStyle.Critical)
        End If

        If File.Exists(Application.StartupPath & "/Interop.WMPLib.dll") = False Then
            okLancement = False
            MsgBox("Le fichier Interop.WMPLib.dll est manquant. Tentez de réinstallez le jeu ou contactez nous sur le forum d'Urgence Manager.", MsgBoxStyle.Critical)
        End If

        If okLancement = True Then
            Me.Hide()
            splash.Show()

            If paramètres.CheckBox1.Checked = True Then
                console.Show()
            End If



            'racourcis clavier

        End If

        

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        paramètres.ShowDialog()
    End Sub

    Private Sub demarrage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "UM ALPHA " & versionPublic & " (Build " & buildPublic & ")"


        'racourcis claviers
        RegisterHotKey(Me.Handle, HOTKEY_CONSOLE, FsModifiers.Ctrl_Shift, Keys.F3)
    End Sub
End Class