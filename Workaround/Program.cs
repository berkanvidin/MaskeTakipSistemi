
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        // Bu proje şimdilik bu şekilde kalacak.Zamanı gelince geliştireceğim.
        static void Main(string[] args)
        {
            //Degiskenler();
            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();
            int sonuc = Topla(50);

            // Diziler - Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler;
            sehirler[0] = "Adana";
            Console.WriteLine(sehirler[0]);
            Person person1 = new Person();
            person1.FirstName = "BERKAN";
            person1.LastName = "VİDİN";
            person1.DateOfBirthYear = 1995;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler = new List<string> { "Ankara 1", "İstabul 1", "İzmir 1" };
            yeniSehirler.Add("Isparta");

            foreach (string sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        //
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);

        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);

        }
    }

    //Pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
