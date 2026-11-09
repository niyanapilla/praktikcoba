Public Class Form4
    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click

        Dim Nama As String
        Dim GajiPokok As Double
        Dim Tunjangan As Decimal
        Dim Total As Decimal

        Nama = txtNama.Text
        GajiPokok = CDbl(txtGajiPokok.Text)
        Tunjangan = CDec(txtTunjangan.Text)
        Total = GajiPokok + Tunjangan

        MessageBox.Show("nama : " & Nama & vbCrLf &
                         "Total Gaji : Rp " & Format(Total, "#,##0"))
    End Sub
End Class