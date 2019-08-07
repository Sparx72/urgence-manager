Imports System.IO
Public Class dev

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try


            If Directory.Exists(appdata) Then
                My.Computer.FileSystem.DeleteDirectory(appdata, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If


            Me.Close()

        Catch ex As Exception
            MsgBox("Échec lors de la suppression, vérifiez que vous n'utilisez pas les données dans un logiciel tiers.", MsgBoxStyle.Critical)
        End Try


    End Sub
End Class