using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Product urun1 = new Product();
        urun1.urunAdi = "Maskara";
        urun1.urunFiyati = 15;
        urun1.Markası = "Loreal Paris";
        urun1.Kategori = "Makyaj";

        Product urun2 = new Product();
        urun2.urunAdi = "Ruj";
        urun2.urunFiyati = 35;
        urun2.Markası = "Essence";
        urun2.Kategori = "Makyaj";


        Product urun3 = new Product();
        urun3.urunAdi = "El Kremi";
        urun3.urunFiyati = 88;
        urun3.Markası = "Cerave";
        urun3.Kategori = "Cilt Bakımı";



        Product[] urunler = new Product[] { urun1, urun2, urun3 };


        Console.WriteLine("***** While Döngüsünde*******");
        int i = 0;
        while (i < urunler.Length)
        {
            Console.WriteLine(urunler[i].urunAdi + urunler[i].urunFiyati + urunler[i].Markası + urunler[i].Kategori);
            i++;


        }
        Console.WriteLine("*******For Döngüsünde * ******");
        for (int i = 0; i < urunler.Length; i++)
        {
            Console.WriteLine(urunler[i].urunAdi + urunler[i].urunFiyati + urunler[i].Markası + urunler[i].Kategori);

        }
        Console.WriteLine("****Foreach Döngüsünde****");
        foreach (Product urun in urunler)
        {
            Console.WriteLine(urun.urunAdi + urun.urunFiyati + urun.Markası + urun.Kategori);

        }


    }
    class Product
    {
        public string urunAdi { get; set; }
        public int urunFiyati { get; set; }
        public string Markası { get; set; }
        public string Kategori { get; set; }

    }
}