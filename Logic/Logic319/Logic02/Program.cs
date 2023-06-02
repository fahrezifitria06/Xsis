//IfStatement();
//IfElseStatement();
//IfElseIf();
//IfNested();
//Ternary();
//SwitchPadaC();

Console.ReadKey();


static void SwitchPadaC()
{
    Console.WriteLine("---SWITCH---");
    Console.Write("Pilih Buah Kesukaan Anda (apel, jeruk, pisang) : ");
    string pilihan = Console.ReadLine().ToLower();

    switch (pilihan)
    {
        case "apel":
            Console.WriteLine("Anda Memilih buah apel");
            break;
        case "jeruk":
            Console.WriteLine("Anda Memilih buah jeruk");
            break;
        case "pisang":
            Console.WriteLine("Anda Memilih buah pisang");
            break;
        default:
            Console.WriteLine("Anda Memilih Buah yang Lain");
            break;
    }

}

static void Ternary()
{
    Console.WriteLine("---TERNARY---");
    Console.Write("Masukkan x : ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Masukkan y : ");
    int y = int.Parse(Console.ReadLine());
    string z;

    if (y > x)
    {
        Console.WriteLine("y lebih besar daripada x");
    }
    else
    {
        Console.WriteLine("x lebih besar daripada dari y");
    }
    z = (y > x) ? "y lebih besar daripada x" : "x lebih besar daripada y";
    Console.WriteLine(z);

}

static void IfNested()
{
    Console.WriteLine("---IF NESTED---");
    Console.Write("Masukkan nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    if (nilai >= 50)
    {
        Console.WriteLine("Kamu Berhasil");

        if (nilai == 100)
        {
            Console.WriteLine("Kamu Keren");
        }
    }
    else
    {
        Console.WriteLine("Coba Lagi");
    }
}
static void IfElseIf()
{
    Console.WriteLine("---IF ELSE IF---");
    Console.Write("Masukkan Nilai x : ");
    int x = int.Parse(Console.ReadLine());


    if (x == 10)
    {
        Console.WriteLine("x equals to 10");
    }
    else if (x > 10)
    {
        Console.WriteLine("x greater than 10");
    }
    else
    {
        Console.WriteLine("x less than 10");
    }
}



static void IfElseStatement()
{
    Console.WriteLine("---Statement Else---");
    Console.Write("Masukkan Nilai x : ");
    int x = int.Parse(Console.ReadLine());

    if (x >= 10)
    {
        Console.WriteLine("x is greater than or equals 10");
    }
    else
    {
        Console.WriteLine("x is less than 10");
    }
}

static void IfStatement()
{
    Console.WriteLine("---If Statement---");
    Console.Write("Masukkan Nilai x : ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Nilai y : ");
    int y = int.Parse(Console.ReadLine());

    if (x >= 10)
    {
        Console.WriteLine("x is greater than or equal than 10");
    }
    if (y <= 5)
    {
        Console.WriteLine("y is lesser than or equal 5");
    }
}