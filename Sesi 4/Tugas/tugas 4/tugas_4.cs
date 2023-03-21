using System;

class tugas_4 {
  static void Main(string[] args) {
    Console.Write("Masukkan angka: ");
    int angka = Convert.ToInt32(Console.ReadLine());
    
    int angkaTerbalik = 0;
    while (angka > 0) {
      int digit = angka % 10;
      angkaTerbalik = (angkaTerbalik * 10) + digit;
      angka = angka / 10;
    }
    
    Console.WriteLine("Angka terbalik: {0}", angkaTerbalik);
  }
}
