Imports System.Numerics

Public Class PraktikTugas
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim Nama As String
        Dim Kelas As String
        Dim NilaiTugas As Double
        Dim NilaiUTS As Double
        Dim NilaiUAS As Double
        Dim RataRata As Double

        Nama = (txtNama.Text)
        Kelas = (txtKelas.Text)
        NilaiTugas = CDbl(txtTugas.Text)
        NilaiUTS = CDbl(txtUTS.Text)
        NilaiUAS = CDbl(txtUAS.Text)


        RataRata = (NilaiTugas + NilaiUTS + NilaiUAS) / 3
        txtHasil.Text = RataRata.ToString(0.00)

        'txtHasil.Text =  '"Nama : " & Nama & vbCrLf &
        '"Kelas : " & Kelas & vbCrLf &
        '"Nilai Tugas : " & NilaiTugas & vbCrLf &
        '"Nilai UTS : " & NilaiUTS & vbCrLf &
        '"Nilai UAS : " & NilaiUAS & vbCrLf &
        Format(RataRata, "0.00")

    End Sub
    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        txtNama.Clear()
        txtKelas.Clear()
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
        txtHasil.Clear()
        txtNama.Focus()
    End Sub

End Class