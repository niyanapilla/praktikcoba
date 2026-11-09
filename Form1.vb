Public Class Form1
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click

        Dim nama As String = "Budi"
        Dim umur As Integer = 17
        Dim tinggi As Double = 168.5
        Dim aktif As Boolean = True

        MessageBox.Show("nama : " & nama & vbCrLf &
                        "umur : " & umur & vbCrLf &
                        "tinggi : " & tinggi & vbCrLf &
                        "aktif : " & aktif)

    End Sub
End Class