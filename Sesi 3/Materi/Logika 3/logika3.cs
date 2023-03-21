using System;

public class logika3 //logika 3
{
    public static void Main()
    {
        string username;
        string password;
        
        //digunakan untuk menginput, isikan username = abcd dan password = boothcamp
        Console.Write("Username: ");
        username = Console.ReadLine();
        Console.Write("Password: ");
        password = Console.ReadLine();

        if(username == "abcd" && password == "boothcamp")
        Console.WriteLine("Anda Berhasil Login");

        else
        Console.WriteLine("Username atau Password Anda Salah");
    }
}