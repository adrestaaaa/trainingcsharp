using System;

public class logika7
{
    public static void Main()
    {

        for (int a =10; a<20; a = a+1)
        {
            if (a==12) 
                Console.WriteLine ("Iterasi ke -" +a + " Saya Belajar C#");
            else {
                if(a==15)continue;
                Console.WriteLine("Iterasi ke -" + a);
            }
        }
    }
}