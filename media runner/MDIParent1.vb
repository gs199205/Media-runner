Imports System.Windows.Forms

Public Class MDIParent1

    

    Private Sub MUSICToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MUSICToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub VIDEOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIDEOToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub PICTUREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PICTUREToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

   

    Private Sub VISITBLOGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VISITBLOGToolStripMenuItem.Click
        Form4.Show()

    End Sub
End Class






