﻿
// Static olmayan bir üyeye erişim
using System.Net.Http.Headers;

Ogrenci o = new Ogrenci();
o.DersCalis();


//Static olan bir üyeye erişim!!
Ogrenci.OkulaGit();


Ogrenci o1 = new Ogrenci();
Ogrenci o2 = new Ogrenci();

Console.WriteLine("Nesne Sayisi : "+Ogrenci.NesneSayisiStatic);

Console.WriteLine("Nesne Sayisi : "+o2.NesneSayisiNonStatic);