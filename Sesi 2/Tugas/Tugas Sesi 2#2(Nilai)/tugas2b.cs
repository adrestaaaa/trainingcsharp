using System;

class tugas2b
{

    static void Main(string[] args)
    {

    Console.Write("Masukkan Nilai :");
    int nilai = int.Parse(Console.ReadLine());


    // menggunakan logika 
    if(nilai <=100 && nilai> 80)
    {
        Console.WriteLine("Nilai anda : A");
        Console.WriteLine("Sangat Baik");

    }
    else if(nilai > 70 && nilai < 80)
    {
        Console.WriteLine("Nilai anda : B");
        Console.WriteLine("Baik");
    }
    else if(nilai > 60 && nilai < 70)
    {
        Console.WriteLine("Nilai anda : C");
        Console.WriteLine("Cukup");
    }
    else if(nilai >= 50 && nilai < 60)
    {
        Console.WriteLine("Nilai anda : D");
        Console.WriteLine("Kurang");
    }
    else if (nilai >= 0 && nilai <=49)
    {
       Console.WriteLine("Nilai anda : E");
       Console.WriteLine("Sangat Kurang");
    }
    else
    {
        Console.WriteLine("Data Tidak Valid");
    }

    }
}