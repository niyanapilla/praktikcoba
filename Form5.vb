Public Class Form5
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim angka As String = "150"

        Dim hasil As Integer = CInt(angka)

        MessageBox.Show("Hasil : " & hasil)

    End Sub
End Class