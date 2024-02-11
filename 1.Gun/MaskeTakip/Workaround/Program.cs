
using Business.Concrete;
using Entites.Concrete;
using System;
using System.Transactions;
using System.Xml.Serialization;

namespace Workaround
{
    class Program
    {

        static void Main(String[] args)
        {        
           Person person1 = new Person();
            person1.Firstname = "Melih Kaan";
            person1.Lastname = "Ermekin";
            person1.DateOfBirthYear = 1997;
            person1.NationanalIdentitiy = 123;
       
            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(person1);
        }

        static void Selamver(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
        public void OtherFunction()
        {
            Selamver(isim: "Engin");
            Selamver(isim: "Ahmet");
            Selamver(isim: "Ayse");
            Selamver();

            int sonuc = Topla(6, 58);


            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";


            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[2] = "İlker";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);

            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach (var sehir in yeniSehirler1)
            {

                Console.WriteLine(sehir);

            }
        }
    }

}
