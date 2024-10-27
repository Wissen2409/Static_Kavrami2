public class Ogrenci{

    // static olmayan bir sınıf içerisinde static bir üye yazabiliriz!!!!



    static Ogrenci()
    {

        // non static bir sınıf içerisinde static ctor yazılabilir!!!
    }
    public Ogrenci(){

        // non static ctor!!!
        NesneSayisiStatic++;

        NesneSayisiNonStatic++;
    } 

    public static int NesneSayisiStatic { get; set; } 
    public int NesneSayisiNonStatic { get; set; }


    public void DersCalis(){

        Console.WriteLine("Ders çalışdı");

    }
    public static void OkulaGit(){

        // Örnektende görülebileceği gibi, non static bir sınıf içerisinde static bir üye olabilir!!!

        Console.WriteLine("Okula Gidildi");

    }


}
