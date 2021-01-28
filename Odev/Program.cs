using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Marka = "Happiness İst.";
            product1.Ozellikler = "Kadın Mavi Blok Renkli Oversize Polar Sweatshirt";
            product1.YorumSayısı = 12336;
            product1.EskiFiyat = 144.95;
            product1.YeniFiyat = 79.72;
            product1.İndirimOranı = 45;

            Product product2 = new Product();
            product2.Marka = "Trend Alaçatı";
            product2.Ozellikler = "Kadın Siyah Şardonlu Renk Bloklu Oversize Kapşonlu Sweatshirt";
            product2.YorumSayısı = 706;
            product2.EskiFiyat = 124.97;
            product2.YeniFiyat = 49.99;
            product2.İndirimOranı = 60;

            Product product3 = new Product();
            product3.Marka = "ELBİSEN";
            product3.Ozellikler = "Kadın Sİyah Eteği TShirt Görünümlü Tasarım Sweatshirt";
            product3.YorumSayısı = 76;
            product3.EskiFiyat = 159.83;
            product3.YeniFiyat = 79.60;
            product3.İndirimOranı = 40;

            Product product4 = new Product();
            product4.Marka = "TRENDYOLMİLLA";
            product4.Ozellikler = "Mürdüm Kanguru Cepli Kapüşonlu Boyfriend Örme Sweatshirt";
            product4.YorumSayısı = 1741;
            product4.EskiFiyat = 69.99;
            product4.YeniFiyat = 55.99;
            product4.İndirimOranı = 20;

            Product[] urunler = new Product[] {product1, product2, product3, product4 };

            Console.WriteLine("************");
            Console.WriteLine("FOR DÖNGÜSÜ");
            Console.WriteLine("************");
            Console.WriteLine(" ");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Marka + " " + urunler[i].Ozellikler);
                Console.WriteLine("Yorum sayısı: " + urunler[i].YorumSayısı);
                Console.WriteLine("Eski fiyat: " + urunler[i].EskiFiyat);
                Console.WriteLine("Yeni Fiyat: " + urunler[i].YeniFiyat + " ( Sepette %" + urunler[i].İndirimOranı + " İndirim)");
                Console.WriteLine(" ");
            }

            Console.WriteLine("***************");
            Console.WriteLine("FOREACH DÖNGÜSÜ");
            Console.WriteLine("***************");
            Console.WriteLine(" ");

            foreach (var product in urunler)
            {
                Console.WriteLine(product.Marka + " " + product.Ozellikler);
                Console.WriteLine("Yorum sayısı: " + product.YorumSayısı);
                Console.WriteLine("Eski fiyat: " + product.EskiFiyat);
                Console.WriteLine("Yeni Fiyat: " + product.YeniFiyat + " ( Sepette %" + product.İndirimOranı + " İndirim)" );
                Console.WriteLine(" ");
            }

            Console.WriteLine("*************");
            Console.WriteLine("WHİLE DÖNGÜSÜ");
            Console.WriteLine("*************");
            Console.WriteLine(" ");

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].Marka + " " + urunler[j].Ozellikler);
                Console.WriteLine("Yorum sayısı: " + urunler[j].YorumSayısı);
                Console.WriteLine("Eski fiyat: " + urunler[j].EskiFiyat);
                Console.WriteLine("Yeni Fiyat: " + urunler[j].YeniFiyat + " ( Sepette %" + urunler[j].İndirimOranı + " İndirim)");
                j++;
                Console.WriteLine(" ");
            }
            
        }
    }
    class Product
    {
        public string Marka { get; set; }
        public string Ozellikler { get; set; }
        public int YorumSayısı { get; set; }
        public double EskiFiyat { get; set; }
        public double YeniFiyat { get; set; }
        public int İndirimOranı { get; set; }
    }
}
