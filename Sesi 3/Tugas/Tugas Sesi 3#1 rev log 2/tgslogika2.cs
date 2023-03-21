using System;

public class tgslogika2 //logika 2
{
    public static void Main()
    {

    Console.Write("Masukkan Nilai :");
    int nilai = int.Parse(Console.ReadLine());
    
        if(nilai >= 0 && nilai <= 59){
            Console.WriteLine("Nilai kamu C");

        }
        else if (nilai >= 60 && nilai <=80){
            Console.WriteLine("Nilai kamu B");

        }
        else if (nilai <= 100 && nilai >80){
    
            Console.WriteLine("Nilai Kamu A");
        }
        else 
        {
            Console.WriteLine("Data Tidak Valid");
        
        }
    }
}