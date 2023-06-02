//TugasSatu();
//TugasDua();
//TugasTiga();
//TugasEmpat();
//TugasLima();
//TugasEnam();

Console.ReadKey();

static void TugasEnam()
{
    Console.WriteLine("");
    Console.WriteLine("***********SOAL 6***********");
    Console.Write("Masukkan Angka: ");
    int angka = int.Parse(Console.ReadLine());

    if (angka % 2 == 0)
    {
        Console.WriteLine("Angka {0} adalah bilangan genap", angka);
    }
    else
    {
        Console.WriteLine("Angka {0} adalah bilanagan ganjil", angka);
    }
    Console.ReadLine();
}

static void TugasLima()
{
    Console.WriteLine("***********SOAL 5***********");
    Console.Write("Masukkan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    string grade;

    if (nilai >= 80 && nilai <= 100)
    {
        grade = "A";
        Console.WriteLine("Grade = " + grade);
    }
    else if (nilai >= 60 && nilai < 80)
    {
        grade = "B";
        Console.WriteLine("Grade = " + grade);
    }
    else if (nilai < 60 && nilai >= 0)
    {
        grade = "C";
        Console.WriteLine("Grade = " + grade);
    }
    else
    {
        Console.WriteLine("Input Nilai dari 0 sampai 100");
    }
}

static void TugasEmpat()
{
    Console.WriteLine("");
    Console.WriteLine("***********SOAL 4***********");
    Console.Write("Masukkan Jumlah Puntung Rokok yang Dikumpulkan: ");
    int jumlahPuntung = Convert.ToInt32(Console.ReadLine());

    int batangRokok = 0;
    int sisaPuntung = 0;

    // hitung jumlah puntung yang bisa dirakit
    batangRokok = jumlahPuntung / 8;

    //hitung sisa puntung rokok
    sisaPuntung = jumlahPuntung % 8;

    Console.WriteLine("Jumlah Batang Rokok yang berhasil dirangkai : " + batangRokok);
    Console.Write("Sisa Puntung Rokok = " + sisaPuntung);
    Console.ReadLine();

    // harga satu batang rokok
    int hargaRokok = 500;

    // hitung penghasilan
    int penghasilan = batangRokok * hargaRokok;

    Console.WriteLine("Penghasilan dari penjualan rokok = Rp " + penghasilan);
}

static void TugasTiga()
{
    Console.WriteLine("");
    Console.WriteLine("***********SOAL 3***********");
    Console.Write("Masukkan Angka1 : ");
    int angka1 = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Angka2 : ");
    int angka2 = int.Parse(Console.ReadLine());

    if (angka1 % angka2 == 0)
    {
        Console.WriteLine("Hasil Mod = 0");
        Console.WriteLine($"{angka1}%{angka2} = 0");
    }
    else
    {
        int hasil = angka1 % angka2;
        Console.WriteLine("Hasil Mod = {hasil}");
        Console.WriteLine($"{angka1}%{angka2} = {hasil}");
    }
}


static void TugasDua()
{
    Console.WriteLine("");
    Console.WriteLine("***********SOAL 2***********");
    Console.Write("Masukkan Nilai Sisi : ");
    int sisi = int.Parse(Console.ReadLine());

    int luas;
    int keliling;

    luas = sisi * sisi;
    Console.WriteLine($"Luas : {luas} cm");

    keliling = 4 * sisi;
    Console.WriteLine($"Keliling : {keliling} cm2");
}


static void TugasSatu()
{
    Console.WriteLine("***********SOAL 1***********");
    Console.Write("Masukkan Jari-Jari : ");
    double jari = Convert.ToDouble(Console.ReadLine());

    double luas;
    double keliling;

    luas = Math.PI * jari * jari;
    Console.WriteLine($"Luas = {Math.Round(luas)} cm");

    keliling = 2 * Math.PI * jari;
    Console.WriteLine($"Keliling = {Math.Round(keliling)} cm2");
}