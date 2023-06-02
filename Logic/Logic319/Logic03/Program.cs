//PerulanganWhile();
//PerulanganWhile2();
//PerulanganDoWhile();
//PerulanganFor();
//Break();
//Continue();
//ForNested();
//Foreach();
//Length(); 
//RemoveString();
//InsertString();
//ReplaceString();
//ContainString();
//SplitAndJoin();  
//SubString();
//ToCharArray();
//ConvertStringArrayToInt();
//ConvertAll();

Console.ReadKey();

static void ConvertAll()
{
    Console.WriteLine("---Convert All---");
    Console.Write("Masukkan input angka (pakai spasi) : ");
    string input = Console.ReadLine();

    int sum = 0;

    int[] array = Array.ConvertAll(input.Split(" "), int.Parse);

    foreach (int x in array)
    {
        sum += x;
    }
    Console.WriteLine($"Jumlah = {sum}");
}


static void ConvertStringArrayToInt()
{
    Console.WriteLine("---Convert String Array To Int");
    Console.Write("Masukkan input (pakai spasi) : ");
    string input = Console.ReadLine();

    int sum = 0;

    string[] array = input.Split(" ");

    foreach (string str in array)
    {
        sum += Convert.ToInt32(str);
        //sum += int.Parse(str);
    }
    Console.WriteLine($"Jumlah = {sum}");
}

static void ToCharArray()
{
    Console.WriteLine("---String ToCharArray");
    Console.Write("Masukkan Kalimat : ");
    string kalimat = Console.ReadLine();

    char[] array = kalimat.ToCharArray();

    foreach (char x in array)
    {
        Console.WriteLine(x);
    }
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

static void SubString()
{
    Console.WriteLine("--SUB STRING--");
    Console.Write("Masukkan kode : ");
    string kode = Console.ReadLine();
    Console.Write("Masukkan parameter 1 : ");
    int param1 = int.Parse(Console.ReadLine());
    Console.Write("Masukkan Parameter 2 : ");
    int param2 = int.Parse(Console.ReadLine());

    if (param2 == 0)
    {
        Console.WriteLine($"Hasil Substring = {kode.Substring(param1)}");
    }
    else
    {
        Console.WriteLine($"Hasil Substring = {kode.Substring(param1, param2)}");
    }
}

static void SplitAndJoin()
{
    Console.WriteLine("--SPLIT AND JOIN STRING--");
    Console.Write("Masukkan kalimat : ");
    string kalimat = Console.ReadLine();
    Console.Write("Masukkan Split : ");
    string split = Console.ReadLine();

    string[] katakata = kalimat.Split(split);

    foreach (string kata in katakata)
    {
        Console.WriteLine(kata);
    }

    Console.WriteLine(string.Join(" + ", katakata));

    Console.WriteLine();

    int[] deret = { 1, 2, 3, 4, 5, 6 };
    string strDeret = string.Join(" + ", deret);
    Console.WriteLine(strDeret);
}



static void ContainString()
{
    Console.WriteLine("--CONTAIN STRING--");
    Console.Write("Masukkan kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukkan contain : ");
    string contain = Console.ReadLine();

    if (kata.Contains(contain))
    {
        Console.WriteLine($"Kata {kata} mengandung {contain}");
    }
    else
    {
        Console.WriteLine($"Kata {kata} tidak mengandung {contain}");
    }

}


static void ReplaceString()
{
    Console.WriteLine("--REPLACE STRING--");
    Console.Write("Masukkan kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukkan kata yang akan di replace : ");
    string kataLama = Console.ReadLine();
    Console.Write("Masukkan kata yang baru : ");
    string kataBaru = Console.ReadLine();

    Console.WriteLine($"{kata.Replace(kataLama, kataBaru)}");

}

Console.ReadKey();

static void InsertString()
{
    Console.WriteLine("--INSERT STRING--");
    Console.Write("Masukkan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukkan Index Insert : ");
    int index = int.Parse(Console.ReadLine());
    Console.Write("Masukkan kata yang di Insert : ");
    string insertKata = Console.ReadLine();

    Console.WriteLine($"{kata.Insert(index, insertKata)}");
}

static void RemoveString()
{
    Console.WriteLine("--REMOVE STRING--");
    Console.Write("Masukkan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukkan Index Remove : ");
    int index = int.Parse(Console.ReadLine());

    Console.WriteLine($"{kata.Remove(index)}");
}





static void Length()
{
    Console.WriteLine("--LENGTH--");
    Console.Write("Masukkan Kata : ");
    string kata = Console.ReadLine();

    Console.WriteLine($"Kata {kata} mempunyai panjang karakter = {kata.Length}");
}

static void Foreach()
{
    int[] array = { 89, 90, 91, 92, 93 };
    int sum = 0;

    foreach (int x in array)
    {
        sum += x;
        Console.WriteLine(x);
    }

    Console.WriteLine($"Jumlah = {sum}");

    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
        Console.WriteLine(array[i]);
    }
    Console.WriteLine($"Jumlah = {sum}");
}

static void ForNested()
{
    for (int i = 0; i < 3; i++) // iterasi baris
    {
        for (int j = 0; j < 3; j++) // iterasi kolom
        {
            Console.Write($"({i},{j})");
        }
        Console.Write("\n");
    }
}


static void Continue()
{
    for (int i = 0; i < 10; i++)
    {
        if (i <= 7 && i >= 2)
        { // berarti 7 yg ga nampil (0 1 2 3 4 5 6 8 9)
            continue;
        }
        Console.WriteLine(i);
    }
}
static void Break()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i); // output 0 1 2 3 4 5 6
        if (i == 6)
        {
            break;
        }
        // Console.WriteLine(i); kalo output disini maka 0 1 2 3 4 5 
    }
}

static void PerulanganFor()
{
    for (int i = 0; i < 5; i++)
    {
        Console.Write(i + "\t\n");
    }

    Console.WriteLine("\n");

    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
}

static void PerulanganDoWhile()
{
    Console.WriteLine("--PERULANGAN DO WHILE--");
    Console.Write("Masukkan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine(nilai);
        nilai++;
    } while (nilai < 6);
}
static void PerulanganWhile2()
{
    bool ulangi = true;

    Console.WriteLine("--PERULANGAN WHILE 2--");
    Console.Write("Masukkan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    while (ulangi)
    {
        Console.WriteLine($"Proses ke {nilai}");
        nilai++;

        Console.Write("Ulangi Proses ? (y/n) : ");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }
    }
}


static void PerulanganWhile()
{
    Console.WriteLine("--PERULANGAN WHILE--");
    Console.Write("Masukkan Nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    while (nilai < 6)
    {
        Console.WriteLine(nilai);
        nilai++;
    }
}