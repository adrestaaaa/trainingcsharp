using System;

public class logika2 //logika 2
{
    public static void Main()
    {
        int nilai = 75;

        if(nilai < 60){
            Console.WriteLine("Nilai kamu C");

        }
        else if (nilai < 80){
            Console.WriteLine("Nilai kamu B");

        }
        else {
            Console.WriteLine("Nilai Kamu A");
        }
    }
}