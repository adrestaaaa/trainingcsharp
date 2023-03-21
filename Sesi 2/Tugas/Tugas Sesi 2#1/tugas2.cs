using System;

class tugas2
{

    public static void Main(string[] args)
    {
        //membuat variabel kosong
       string customer;
       string produk;
       int jumlah; 
       double harga;



        Console.WriteLine("=====Kasir=====");
        Console.Write("Masukkan Nama Customer : ");
        customer = Console.ReadLine();
        Console.Write("Masukkan Produk : ");
        produk = Console.ReadLine();
        Console.Write("Masukkan Jumlah Produk : ");
        jumlah = int.Parse(Console.ReadLine());
        Console.Write("Masukkan Harga Produk : ");
        harga = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Terimakasih Sudah Belanja !");
        Console.WriteLine("Berikut");
        Console.WriteLine($"Nama Customer :{customer}");
        Console.WriteLine($"Nama Produk :{produk}");
        Console.WriteLine($"Jumlah :{jumlah} ");
        Console.WriteLine($"Harga :{harga} ");
        Console.WriteLine($"Total Harga :{harga*jumlah} ");
        Console.WriteLine("SUDAH DISIMPAN ! ");
    }
}