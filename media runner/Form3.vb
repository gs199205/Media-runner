Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Const DATA_FILE_EXTENSION As String = ""
        Dim dlgFileDialog As New OpenFileDialog
        With dlgFileDialog
            .Filter = DATA_FILE_EXTENSION & _
            " files (*" & DATA_FILE_EXTENSION & "|*" & DATA_FILE_EXTENSION
            .FilterIndex = 23
            .RestoreDirectory = True
            If .ShowDialog() = DialogResult.OK Then
                'Play the MEDIA file
                Me.AxWindowsMediaPlayer1.URL = dlgFileDialog.FileName

                Me.AxWindowsMediaPlayer1.Width = 1000
                Me.AxWindowsMediaPlayer1.Height = 800
                Me.WindowState = FormWindowState.Maximized
                Try

                Catch err As Exception
                    MsgBox("Invalid Input", MsgBoxStyle.Critical)

                End Try
            End If
        End With
    End Sub
End Class