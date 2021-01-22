using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Program
{

    public class MusteriManager 
    {
        public void  MusteriEkle(Musteri musteri) 
        {
        	Console.WriteLine("Bankamıza Hoşgeldiniz. " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void MusteriCikar(Musteri musteri)
        {
        	Console.WriteLine("Aramızdan ayrıldın :( " + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}