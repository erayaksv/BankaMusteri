using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Program
{

    class Program 
    {
        static void Main(string[] args)
        {
			Musteri musteri1 = new Musteri();
		    musteri1.Adi = "Mehmet";
		    musteri1.Soyadi = "Karabıyık";
		    musteri1.MevcutBakiye = 1000;
		    
		    Musteri musteri2 = new Musteri();
		    musteri2.Adi = "Burak";
		    musteri2.Soyadi = "Kalın";
		    musteri2.MevcutBakiye = 1500;
		    
            	    Musteri musteri3 = new Musteri();
		    musteri3.Adi = "Aslı";
		    musteri3.Soyadi = "Girgin";
		    musteri3.MevcutBakiye = 3000;
		 
		    Musteri[] musteriler = {musteri1, musteri2, musteri3 };
		
        
           foreach (var musteri in musteriler)
           {
            	MusteriManager musteriManager = new MusteriManager();
            	musteriManager.MusteriEkle(musteri);
            	musteriManager.MusteriCikar(musteri);
           }
        }   
    
    }
}
