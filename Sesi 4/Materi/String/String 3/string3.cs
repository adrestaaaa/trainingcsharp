using System;

class string3 {
    static void Main() {
        string[] str = {"Ini", "adalah", "sebuah", "test."};
        Console.WriteLine("Array asli :");

        for (int i=0; i< str.Length; i++)
            Console.Write(str[i] + " ");

        Console.WriteLine("\n");

        //Mengubah String
        str[1] = "Merupakan";
        str[3] = "test, juga!";
        Console.WriteLine("Array termodifikasi :");

        for (int i=0; i<str.Length; i++)
            Console.Write(str[i] + " ");
    }
}