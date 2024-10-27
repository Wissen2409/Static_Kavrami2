public class Ogrenci{

    // static olmayan bir sınıf içerisinde static bir üye yazabiliriz!!!!



    static Ogrenci()
    {

        // non static bir sınıf içerisinde static ctor yazılabilir!!!
    }
    public Ogrenci(){

        // non static ctor!!!
        NesneSayisiStatic++;

    } 

    public static int NesneSayisiStatic { get; set; } 
 

    // Static sınıfın üyesidir;!!!
    // NonStatic nesnenin üyesidir!!

    // Static tüm nesneleri kapsar!! çünkü nesnelerden üstündür ve bağımsız hareket eder!!!


    public void DersCalis(){

        Console.WriteLine("Ders çalışdı");

    }
    public static void OkulaGit(){

        // Örnektende görülebileceği gibi, non static bir sınıf içerisinde static bir üye olabilir!!!

        Console.WriteLine("Okula Gidildi");

    }


}
