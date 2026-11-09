function daftarEkskul(nama, ekskul) {
    console.log("=== DATA PENDAFTARAN ===");
    console.log("Nama Siswa: " + nama);
    console.log("Ekstrakurikuler: " + ekskul);

    document.write("<h3>Data Pendaftaran</h3>");
    document.write("Nama Siswa: " + nama + "<br>");
    document.write("Ekstrakurikuler: " + ekskul);
}

var nama = prompt("Masukkan nama siswa:");

var pilihan = prompt(
    "PILIH EKSTRAKURIKULER:\n" +
    "1. PMR\n" +
    "2. Rohis\n" +
    "3. Pramuka\n" +
    "4. KIR"
);

var ekskul;

if (pilihan == "1") {
    ekskul = "PMR";
} else if (pilihan == "2") {
    ekskul = "Rohis";
} else if (pilihan == "3") {
    ekskul = "Pramuka";
} else if (pilihan == "4") {
    ekskul = "KIR";
} else {
    ekskul = "Pilihan tidak valid";
}

daftarEkskul(nama, ekskul);
