using System;

class tugas_1
{
    static void Main(string[] args)
    {
        int n = 5; // jumlah baris

        for (int i = 0; i < n; i++)
        {
            // mencetak spasi pada setiap baris
            for (int j = n - i; j > 1; j--)
            {
                Console.Write(" ");
            }

            // mencetak alphabet pada setiap baris
            for (int k = 0; k <= i; k++)
            {
                Console.Write((char)('a' + k));
            }

            // mencetak ulang alphabet pada setiap baris
            for (int l = i - 1; l >= 0; l--)
            {
                Console.Write((char)('a' + l));
            }

            Console.WriteLine();
        }
    }
}
