using System;

class tugas_2
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan angka: ");
        int n = int.Parse(Console.ReadLine()); // jumlah baris

        for (int i = 0; i < n; i++)
        {
            // mencetak spasi pada setiap baris
            for (int j = n - i; j > 1; j--)
            {
                Console.Write(" ");
            }

            // mencetak angka pada setiap baris
            for (int k = 1; k <= i + 1; k++)
            {
                Console.Write(k);
            }

            // mencetak ulang angka pada setiap baris
            for (int l = i; l >= 1; l--)
            {
                Console.Write(l);
            }

            Console.WriteLine();
        }
    }
}