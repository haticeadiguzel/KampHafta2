using System;

namespace KampHafta2
{
    class Program
    {
        static void Main(string[] args)
        {
            //in c# there are type safety instead of phyton
            
            
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            bool SistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis butonu");
            } else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artis butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }



            if (SistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}