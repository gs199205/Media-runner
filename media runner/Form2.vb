
Public Class Form2



    Private Sub play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles play.Click

        Const DATA_FILE_EXTENSION As String = ".mp3"
        Dim dlgFileDialog As New OpenFileDialog
        With dlgFileDialog
            .Filter = DATA_FILE_EXTENSION & _
            " files (*" & DATA_FILE_EXTENSION & "|*" & DATA_FILE_EXTENSION
            .FilterIndex = 1
            .RestoreDirectory = True
            If .ShowDialog() = DialogResult.OK Then
                'Play the sound file
                Me.AxWindowsMediaPlayer1.URL = dlgFileDialog.FileName
            End If
        End With

    End Sub

    
End Class

