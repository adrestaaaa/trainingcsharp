using System;

class hitungnilai4
{

    static void Main(string[] args)
    {

    Console.Write("Enter your age :");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Password :");
    string password = Console.ReadLine();

    bool isAdult = age > 18; // pernyatan 1
    bool isPasswordValid = password == "OCBC"; //pernyataan 2

    // menggunakan logika AND
    if(isAdult && isPasswordValid)

    {
        Console.WriteLine("Welcome to the Club !");

    }
    else
    {
        Console.WriteLine("Sorry, try again !");
    }

    }
}