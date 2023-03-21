using System;

class Program
{
    static void Main()
    {

        string name,address,hobi,pekerjaan;
        Console.Write("Nama lengkap :  ");
        name = Console.ReadLine();
        Console.Write("Alamat  : ");
         address = Console.ReadLine();
        Console.Write("Hobi : ");
         hobi = Console.ReadLine();
        Console.Write("Pekerjaan : ");
         pekerjaan = Console.ReadLine();
        Console.WriteLine("\nNama Lengkap :" + name );
        Console.WriteLine("Alamat : " + address );
        Console.WriteLine("Hobi: " + hobi );
        Console.WriteLine("Pekerjaan : " + pekerjaan );
    }
}