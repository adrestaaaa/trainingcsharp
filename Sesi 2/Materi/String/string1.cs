using System;

class string1
{

    public static void Main(string[] args)
    {
        //membuat variabel kosong
       string nama;
       int umur; 

        Console.WriteLine("=====PROGRAM PENDFTARAN PENDUDUK=====");
        Console.WriteLine("Masukkan nama : ");
        nama = Console.ReadLine();
        Console.WriteLine("Masukkan alamat : ");
        var alamat = Console.ReadLine();
        Console.WriteLine("Masukkan umur : ");
        umur = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Terimakasih !");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama :{nama}");
        Console.WriteLine($"Alamat :{alamat}");
        Console.WriteLine($"Umur :{umur} tahun");
        Console.WriteLine("SUDAH DISIMPAN ! ");
    }
}