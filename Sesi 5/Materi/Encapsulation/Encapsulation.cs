class Pesawat
{
   public string nama = " ";
   private string ketinggian = " ";
   /*public string Ketinggian
   {
    get { return ketinggian;}
    set {Ketinggian = value;}
   } -ini punya dotnet 5 */
   public string Ketinggian {
     get => ketinggian;
     set => ketinggian = value; //get dan set ini untuk yang private
   }
   public void terbang()
   {
    Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
   }

   public void sudahterbang()
   {
        Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.Ketinggian);
   }
 }  
