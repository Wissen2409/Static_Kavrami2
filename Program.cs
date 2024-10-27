
// Static olmayan bir üyeye erişim
using System.Net.Http.Headers;


// Ogrenci class'ını ilk yazdığımız anda static ctor çalışır!!! 
Ogrenci o = new Ogrenci();
o.DersCalis();


//Static olan bir üyeye erişim!!
Ogrenci.OkulaGit();


Ogrenci o1 = new Ogrenci();
Ogrenci o2 = new Ogrenci();
Ogrenci o3 = new Ogrenci();

Console.WriteLine("Nesne Sayisi : "+Ogrenci.NesneSayisiStatic);

o2=null;


Console.WriteLine("Nesne Sayisi : "+Ogrenci.NesneSayisiStatic);
