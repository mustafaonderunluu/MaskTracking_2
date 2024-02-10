
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {

            SelamVer(isim: "Onder");
            int sonuc = Topla(5, 3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Cengiz";
            ogrenciler[2] = "Deniz";
            ogrenciler = new string[4];
            ogrenciler[3] = "tekin";

            for (int i = 0; i < ogrenciler.Length; i++)
            {

                Console.WriteLine(ogrenciler[i]);


            }


            string[] sehirler1 = { "ankara", "istanbul", "izmir" };
            string[] sehirler2 = { "bursa", "antalya", "diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "adana";
            Console.WriteLine(sehirler1);


            List<string> sehirler3 = new List<string> { "adıyaman", "niğde", "bayburt" };
            sehirler3.Add("kars");
            foreach (string s in sehirler3) {

                Console.WriteLine(s);
            }







            Console.ReadLine();
        }
        static void SelamVer(string isim)
        {

            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            Console.WriteLine("Sonuc:" + sonuc);
            return sonuc;
        }


    }
    public class Vatandas
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DoğumYili { get; set; }
        public long TcNo { get; set; }


    }
}
