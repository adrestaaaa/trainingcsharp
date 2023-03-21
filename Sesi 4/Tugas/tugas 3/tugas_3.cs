using System;

public class tugas_3
{
    public static void Main()
    {
        Console.Write("Masukkan bilangan: ");
        int bilangan = int.Parse(Console.ReadLine());
        int faktorial = 1;
        
        for (int i = 1; i <= bilangan; i++)
        {
            faktorial *= i;
        }
        
        Console.WriteLine("Faktorial dari " + bilangan + " adalah " + faktorial);
    }
}
