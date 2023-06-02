== apel : { mangga == apel}
");
    Console.WriteLine($"Mangga != apel : {mangga != apel}");
}

static void OperatorPenugasan()
{
    int mangga = 10;
    int apel = 8;


    //isi ulang variabel
    //mangga = 15;

    Console.WriteLine("-----OPERATOR PENUGASAN-----");
    Console.Write("Masukkan Mangga : ");
    mangga = int.Parse(Console.ReadLine()); //INPUT
    Console.WriteLine($"mangga : {mangga}");

    //Opreator Penugasan
    //apel += 6;
    Console.Write("Masukkan Apel : ");
    apel = int.Parse(Console.ReadLine()); //INPUT
    Console.WriteLine($"apel : {apel}");

}


static void Modulus()
{
    int mangga, orang, hasil = 0;

    Console.WriteLine("Modulus");
    Console.Write("Masukkan Mangga : ");
    mangga = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Orang : ");
    orang = int.Parse(Console.ReadLine());

    hasil = mangga % orang;

    Console.WriteLine($"Hasil mangga % orang = {hasil}");

}

static void OperatorAritmatika()
{
    int mangga, apel, hasil = 0;

    Console.WriteLine("--Operator Aritmatika--");
    Console.Write("Masukan mangga : ");
    mangga = int.Parse(Console.ReadLine());
    Console.Write("Masukan apel : ");
    apel = int.Parse(Console.ReadLine());

    hasil = mangga + apel;

    Console.WriteLine($"Hasil mangga + apel ={hasil}");

}

static void Konversi()
{
    Console.WriteLine("--Konversi--");

    int myInt = 100;
    double myDouble = 5.25;
    bool myBool = true;

    string strMyInt = Convert.ToString(myInt);
    string strMyInt2 = myInt.ToString();

    Console.WriteLine(strMyInt);
    Console.WriteLine(strMyInt2);
    Console.WriteLine(Convert.ToDouble(myInt));
    Console.WriteLine(Convert.ToString(myDouble));
    Console.WriteLine(Convert.ToString(myBool));
};