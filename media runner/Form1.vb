

Public Class Form1

    Private Sub browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse.Click
        'code for seleccting picture for click event.
        If ofdpictureviewer.ShowDialog = DialogResult.OK Then
            'the code for loading picture into picture box.
            PictureBox1.Image = Image.FromFile(ofdpictureviewer.FileName)
            ' Show the name of the file in the form's caption.
            Me.Text = "Picture Viewer(" & ofdpictureviewer.FileName & ")"

        End If
    End Sub

    Private Sub quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quit.Click
        ' Close the window and exit the application
        Me.Close()
    End Sub


    Private Sub music_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles music.Click
        'show the form
        Form2.Show()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form3.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()

    End Sub
End Class








