Public Class Form2
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        Dim nama As String = txtNama.Text
        Dim kelas As String = txtKelas2.Text
        Dim jurusan As String = txtJurusan3.Text

        MessageBox.Show("Nama :" & nama & vbCrLf &
                         "Kelas :" & kelas & vbCrLf &
                         "jurusan : " & jurusan)

    End Sub
End Class