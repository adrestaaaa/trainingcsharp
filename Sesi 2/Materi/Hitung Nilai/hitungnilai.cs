using System;

class hitungnilai
{

    public static void Main(string[] args)
    {

      int pertama, kedua, ketiga, total;
      double rata;
        Console.WriteLine("=====Menghitung Nilai=====");
        Console.Write("Masukkan nilai Pertama : ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai Kedua : ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai Ketiga : ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rata = total/3.0;
        Console.Write("Total Nilai adalah : " + total);
        Console.Write("Rata - Rata Nilai adalah: " + rata);
        Console.Read();
    
    }
}