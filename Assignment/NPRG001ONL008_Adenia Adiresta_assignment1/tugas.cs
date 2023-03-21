using System;
class tugas
{
    static void Main()
    {
        string repeat = "N";
        string input = "";

        do {
            Console.WriteLine("Assigment 1");
            Console.WriteLine("Biodata :");
            Console.WriteLine("Nama : Adenia Adiresta");
            Console.WriteLine("Kode Peserta : NPRG001ONL008");
            Console.WriteLine();

            Console.WriteLine("Daftar Soal:");
            Console.WriteLine("Tugas 1 - Segitiga Alphabet");
            Console.WriteLine("Tugas 2 - Segitiga Angka");
            Console.WriteLine("Tugas 3 - Faktorial");
            Console.WriteLine("Tugas 4 - Reversed Number");
            Console.WriteLine("Tugas 5 - Number to String");
            Console.WriteLine("");
            Console.Write("Masukkan Angka Sesuai Nomor Tugas :");
            input = Console.ReadLine();

            switch (input)
                {
                    case "1": {
                    Console.WriteLine("Soal Nomor 1 - Segitiga Alphabet");
                    
                    int n = 5; // jumlah baris

                    for (int i = 0; i < n; i++) {
                            // mencetak spasi pada setiap baris
                            for (int j = n - i; j > 1; j--) {
                                Console.Write(" ");
                            }
                            // mencetak alphabet pada setiap baris
                            for (int k = 0; k <= i; k++) {
                                Console.Write((char)('a' + k));
                            }
                            // mencetak ulang alphabet pada setiap baris
                            for (int l = i - 1; l >= 0; l--) {
                                Console.Write((char)('a' + l));
                            }
                            Console.WriteLine();
                            
                        } break;
                    }
                    case "2": {
                    Console.WriteLine("Soal Nomor 2 - Segitiga Angka dengan Inputan");
                    Console.Write("Masukkan angka: ");
                    int n = int.Parse(Console.ReadLine()); // jumlah baris

                    for (int i = 0; i < n; i++) {
                        // mencetak spasi pada setiap baris
                            for (int j = n - i; j > 1; j--) {
                                Console.Write(" ");
                            }
                            // mencetak angka pada setiap baris
                            for (int k = 1; k <= i + 1; k++) {
                            Console.Write(k);
                            }
                            // mencetak ulang angka pada setiap baris
                            for (int l = i; l >= 1; l--) {
                            Console.Write(l);
                            }
                            Console.WriteLine(); 
                        } break;
                    }
                    case "3":{
                    Console.WriteLine("Soal Nomor 3 - Faktorial");
                    Console.Write("Masukkan bilangan: ");
                    int bilangan = int.Parse(Console.ReadLine());
                    int faktorial = 1;            
                    
                    for (int i = 1; i <= bilangan; i++) {
                            faktorial *= i;
                        }
                    Console.WriteLine("Faktorial dari " + bilangan + " adalah " + faktorial);
                    break;
                    }
                    case "4" : {
                    Console.WriteLine("Soal Nomor 4 - Reversed Number");
                    Console.Write("Masukkan angka: ");
                    int angka = Convert.ToInt32(Console.ReadLine());
                    int angkaTerbalik = 0;
                    while (angka > 0) {
                    int digit = angka % 10;
                    angkaTerbalik = (angkaTerbalik * 10) + digit;
                    angka = angka / 10;
                    }
                    Console.WriteLine("Angka terbalik: {0}", angkaTerbalik);
                    break;
                    }
                    case "5": {
                    Console.WriteLine("Soal Nomor 5 - Number to String");
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
                        break;
                    }
                    default:{
                        Console.WriteLine("Invalid Number, Try Again !");
                        break;
                    }
                    }
                    //kembali ke menu awal
                    Console.Write("Kembali ke menu awal (Y/N) : ");
                    repeat = Console.ReadLine();
                    repeat = repeat.ToUpper();
                
        } while (repeat == "Y");
    }
}
    

