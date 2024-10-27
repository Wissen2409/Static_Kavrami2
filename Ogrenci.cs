public class Ogrenci{

    // static olmayan bir sınıf içerisinde static bir üye yazabiliriz!!!!



    static Ogrenci()
    {

        // non static bir sınıf içerisinde static ctor yazılabilir!!!
        Console.WriteLine("Static ctor çalıştı!!");

        // bir sınıfın içerisindeki static yada nonstatic ctor olduğu zaman, her zaman static ctor daha önce çalışmaktadır!!
        // non static ctorlar static ctorlardan sonra çalışır!!
        
    }
    public Ogrenci(){

        // non static ctor!!!
        NesneSayisiStatic++;
        Console.WriteLine("Non static ctor çalıştı!!");

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
