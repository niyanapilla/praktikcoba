Public Class Form3
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim umur As Integer
        umur = CInt(txtUmur.Text)

        Dim TahunDepan As Integer
        TahunDepan = umur + 1

        MessageBox.Show(" Umur tahun depan : " & TahunDepan)
    End Sub
End Class