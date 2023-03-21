using System;

public class tugas_5
{
    public static void Main()
    {
        Console.Write("Masukkan sebuah angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        string[] angkaTulisan = {
            "nol", "satu", "dua", "tiga", "empat", 
            "lima", "enam", "tujuh", "delapan", "sembilan"
        };

        string angkaString = angka.ToString();
        string angkaTulisanString = "";

        foreach(char digit in angkaString) {
            int digitAngka = (int)Char.GetNumericValue(digit);
            angkaTulisanString += angkaTulisan[digitAngka] + " ";
        }

        Console.WriteLine("Angka dalam bentuk tulisan: " + angkaTulisanString);

        Console.ReadLine();
    }
}