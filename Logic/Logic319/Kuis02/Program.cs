//TugasSatu();
//TugasDua();
//TugasTiga();
TugasEmpat();
//TugasLima();
//TugasEnam();
//TugasTujuh();
//TugasDelapan();


Console.ReadKey();
static void TugasSatu()
{
    Console.WriteLine("---SOAL 1---");
    Console.WriteLine();
    Console.Write("Masukkan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    string grade;

    if (nilai >= 90 && nilai <= 100)
    {
        grade = "A";
        Console.WriteLine("Grade = " + grade);
    }
    else if (nilai >= 70 && nilai <= 89)
    {
        grade = "B";
        Console.WriteLine("Grade = " + grade);
    }
    else if (nilai >= 50 && nilai <= 69)
    {
        grade = "C";
        Console.WriteLine("Grade = " + grade);
    }
    else if (nilai >= 0 && nilai <= 50)
    {
        grade = "E";
        Console.WriteLine("Grade = " + grade);
    }
    else
    {
        Console.WriteLine("Masukkan Nilai dari 0 sampai 100");
    }
}

static void TugasDua()
{
    Console.WriteLine("---SOAL 2---");
    Console.WriteLine();
    Console.Write("Masukkan Jumlah Pulsa Yang Dibeli : ");
    int JumlahPulsa = int.Parse(Console.ReadLine());
    int point = 0;

    if (JumlahPulsa > 0 && JumlahPulsa < 10000)
    {
        point = 0;
        Console.WriteLine("Anda mendapatkan Point = " + point);
        Console.WriteLine("Silahkan Beli Pulsa Harga 10.000 - 100.000 Untuk Mendapatkan Point!!");
    }
    else if (JumlahPulsa >= 10000 && JumlahPulsa < 25000)
    {
        point = 80;
        Console.WriteLine("Anda mendapatkan Point = " + point);
    }
    else if (JumlahPulsa >= 25000 && JumlahPulsa < 50000)
    {
        point = 200;
        Console.WriteLine("Anda mendapatkan Point = " + point);
    }
    else if (JumlahPulsa >= 50000 && JumlahPulsa < 100000)
    {
        point = 400;
        Console.WriteLine("Anda mendapatkan Point = " + point);
    }
    else if (JumlahPulsa == 100000)
    {
        point = 800;
        Console.WriteLine("Anda mendapatkan Point = " + point);
    }
    else
    {
        Console.WriteLine("Silahkan Beli Pulsa Harga 10.000 - 100.000 Untuk Mendapatkan Point!!");
    }
}

static void TugasTiga()
{
    Console.WriteLine("--Soal 3--");
    Console.WriteLine();
    const int MinimumBelanja = 30000;
    const int MaxDiskon = 30000;
    const int OngkosKirimPerKM = 5000;
    const int BiayaTambahanPerKM = 1000;

    Console.Write(" Masukan Input Belanja : ");
    int belanja = Convert.ToInt32(Console.ReadLine());

    Console.Write(" Masukan Jarak : ");
    int jarak = Convert.ToInt32(Console.ReadLine());

    Console.Write(" Masukan Promo : ");
    string promo = Console.ReadLine();

    Console.WriteLine(" Belanja : {0}", belanja);

    int diskon = 0;
    if (promo == "JKTOVO" && belanja >= MinimumBelanja)
    {
        diskon = (int)(belanja * 0.4);
        if (diskon > MaxDiskon)
            diskon = MaxDiskon;
    }
    Console.WriteLine(" Diskon 40% : {0}", diskon);

    int ongkir = OngkosKirimPerKM * (jarak / 5);
    if (jarak % 5 != 0)
        ongkir += BiayaTambahanPerKM * (jarak % 5);
    Console.WriteLine(" Ongkir : {0}", ongkir);

    int totalBelanja = belanja - diskon + ongkir;
    Console.WriteLine(" Total Belanja : {0}", totalBelanja);
}

static void TugasEmpat()
{
    int total;
    Console.WriteLine("--SOAL 4--");
    Console.WriteLine("Voucher Sopi :");
    Console.WriteLine("1. Min Order 30rb free ongkir 5rb dan potongan harga belanja 5rb");
    Console.WriteLine("2. Min Order 50rb free ongkir 10rb dan potongan harga belanja 10rb");
    Console.WriteLine("3. Min Order 100rb free ongkir 20rb dan potongan harga belanja 10rb \n");

    Console.Write("Inputkan Total Belanja \t = ");
    int shop = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Ongkos Kirim \t = ");
    int ongkir = int.Parse(Console.ReadLine());
    Console.Write("Pilih Voucher \t = ");
    int promo = int.Parse(Console.ReadLine());

    if (shop >= 30000 && promo == 1)
    {
        total = shop + ongkir - 5000 - 5000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 5000 ");
        Console.WriteLine("Diskon Belanja \t : 5000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else if (shop >= 50000 && promo == 2)
    {
        total = shop + ongkir - 10000 - 10000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 10000 ");
        Console.WriteLine("Diskon Belanja \t : 10000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else if (shop >= 100000 && promo == 3)
    {
        total = shop + ongkir - 20000 - 10000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 20000 ");
        Console.WriteLine("Diskon Belanja \t : 10000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else
    {
        Console.WriteLine("Tidak Dapat Menggunakan Voucher");
    }

}

static void TugasLima()
{
    Console.WriteLine("--SOAL 5--");
    Console.WriteLine();
    Console.Write("Masukkan nama anda : ");
    string nama = Console.ReadLine();
    Console.Write("Tahun berapa anda lahir : ");
    int tahun = int.Parse(Console.ReadLine());

    if (tahun >= 1944 && tahun <= 1964)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong 'Baby Boomer'");
    }
    else if (tahun >= 1965 && tahun <= 1979)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong 'Generasi X'");
    }
    else if (tahun >= 1980 && tahun <= 1994)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong 'Generasi Y(Millenials)'");
    }
    else if (tahun >= 1995 && tahun <= 2015)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong 'Generasi Z'");
    }
    else if (tahun >= 2016 && tahun <= 2023)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong 'Bau kencur'");
    }
    else if (tahun >= 2024)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong 'Belum Lahir'");
    }
    else
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong 'Sudah jadi fossil'");
    }
}

static void TugasEnam()
{
    Console.WriteLine("--SOAL 6--");
    Console.WriteLine();
    Console.Write("Masukkan Nama: ");
    string nama = Console.ReadLine();

    Console.Write("Tunjangan: ");
    int tunjangan = Convert.ToInt32(Console.ReadLine());

    Console.Write("Gapok: ");
    int gapok = Convert.ToInt32(Console.ReadLine());

    Console.Write("Banyak Bulan: ");
    int banyakBulan = Convert.ToInt32(Console.ReadLine());

    double pajak, bpjs, gajiPerBulan, totalGaji;

    double totalPendapatan = gapok + tunjangan;

    if (totalPendapatan <= 5000000)
    {
        pajak = 0.05 * totalPendapatan;
    }
    else if (totalPendapatan <= 10000000)
    {
        pajak = 0.1 * totalPendapatan;
    }
    else
    {
        pajak = 0.15 * totalPendapatan;
    }

    bpjs = 0.03 * totalPendapatan;

    gajiPerBulan = totalPendapatan - (pajak + bpjs);
    totalGaji = gajiPerBulan * banyakBulan;

    Console.WriteLine("\nKaryawan atas nama {0} slip gaji sebagai berikut:", nama);
    Console.WriteLine("Pajak\t\tRp{0:#,0}", pajak);
    Console.WriteLine("BPJS\t\tRp{0:#,0}", bpjs);
    Console.WriteLine("Gaji/bulan\tRp{0:#,0}", gajiPerBulan);
    Console.WriteLine("Total gaji/{0} bulan\tRp{1:#,0}", banyakBulan, totalGaji);
}

static void TugasTujuh()
{
    Console.WriteLine("--SOAL 7--");
    Console.WriteLine();
    Console.Write("Masukkan berat badan anda : ");
    float kg = float.Parse(Console.ReadLine());
    Console.Write("Masukkan tinggi badan anda : ");
    float cm = float.Parse(Console.ReadLine());
    float m = cm / 100;
    float mkuadrat = m * m;
    float bwi = kg / mkuadrat;
    Console.WriteLine($"Nilai BWI anda adalah : {bwi}");

    if (bwi < 18.5)
    {
        Console.Write("Anda terlalu kurus");
    }
    else if (bwi >= (185 / 10) && bwi < 25)
    {
        Console.Write("Anda terlalu langsing/sehat");
    }
    else if (bwi > 25)
    {
        Console.Write("Anda terlalu Gemuk");
    }
    else
    {
        Console.WriteLine("Input tidak valid");
    }
}

static void TugasDelapan()
{
    Console.WriteLine("---SOAL 8---");
    Console.WriteLine();
    Console.Write("Masukkan Nilai MTK : ");
    int mtk = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Nilai Fisika : ");
    int fis = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Nilai Kimia : ");
    int kim = int.Parse(Console.ReadLine());

    int rata = (mtk + fis + kim) / 3;
    Console.WriteLine("Nilai Rata-rata : " + rata);

    if (rata >= 50 && rata <= 100)
    {
        Console.WriteLine("Selamat Kamu Berhasil Kamu Hebat");

    }
    else if (rata >= 0 && rata < 50)
    {
        Console.WriteLine("Maaf Kamu Gagal");
    }
    else
    {
        Console.WriteLine("Masukkan Nilai 0 sampai 100");
    }
}