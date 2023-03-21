public class Pesawat
{
    public string Nama = "", Ketinggian = "", JumlahPenumpang = "";
    public int JumlahRoda;
    public void terbang()
    {
        Console.WriteLine ("Pesawat tempur dengan nama {0} \n" +
                            "yang mempunyai jumlah roda {1} \n"+
                            "sedang berada pada ketinggian {2} \n"+
                            "dengan membawa penumpang sebanyak {3} \n"+
                            "akan meledakan senjata",
        this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
    }
}

class pesawat_tempur:Pesawat 
{
    public void terbangtinggi()
    {
        Console.WriteLine();
        Console.WriteLine (
            "Pesawat tempur dengan nama {0} \n" +
                            "yang mempunyai jumlah roda {1} \n"+
                            "sedang berada pada ketinggian {2} \n"+
                            "dengan membawa penumpang sebanyak {3} \n"+
                            "akan meledakan senjata",
        this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
    }
}