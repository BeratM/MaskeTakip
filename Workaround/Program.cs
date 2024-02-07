using Business.Concrete;
using Entities.Concrete;

namespace Workaround
  
{
    internal class Program
    {        
        static void Main(string[] args)
        {
                       
            Beginning();

            Citizen citizen1 = new Citizen();

            SayHello(name: "Engin");
            SayHello(name: "Berat");
            SayHello(name: "Ahmet");
            SayHello();

            int resault = Add(86);
            int resault2 = Add(6,38);

            // Diziler - Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);


            string[] ogrenciler = new string[3];
            
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "Ilker";
            

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakir" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            Console.WriteLine(
                              );
            Console.WriteLine("Sonraki ornek");
          
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);
            Console.WriteLine(
                              );
            Console.WriteLine("Sonraki ornek");


            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);

            }

            List<string> yeniSehirler = new List<string> { "Ankara 1", "Istanbul 1", "Izmir 1" };
            yeniSehirler.Add("Malatya");

            foreach (var yeniSehir in yeniSehirler)
            {
                Console.WriteLine(yeniSehir);

            }

            Console.WriteLine(
                              );
            Console.WriteLine("Sonraki ornek");

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demirog";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 47263550170;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            Person person3 = new Person();
            person3.FirstName = "Berat";
            person3.LastName = "Macit";
            person3.DateOfBirthYear = 1996;
            person3.NationalIdentity = 47263550170;

            Person person4 = new Person();
            person4.FirstName = "Berat Bekir";
            person4.LastName = "Macit";
            person4.DateOfBirthYear = 1996;
            person4.NationalIdentity = 47263550170;



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            pttManager.GiveMask(person3);

            pttManager.GiveMask(person4);

            Console.ReadLine();

        }

        static void SayHello(string name = "Ketch")
        {
            Console.WriteLine("Hello " + name);
        }

        static int Add(int num1 = 5, int num2 = 10)
        {
            int resault = num1 + num2;
            Console.WriteLine("Toplam : " + resault);
            return resault;
        }

        Citizen citizen1 = new Citizen();
        

        private static void Beginning()
        {
            string massage = "Hello, World";
            double price = 10000;

            int number = 100;

            bool isItLoggedIn = false;

            string name = "Berat";
            string lastName = "Macit";
            int birthyear = 1996;
            long tcNo = 12345678910;


            Console.WriteLine(price * 1.2);

            Console.WriteLine(price * 1.2);

            Console.WriteLine(massage);
            Console.WriteLine(massage);
            
        }
    }

     public class Citizen
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Birthyear { get; set; }
        public long TcNo { get; set; }
    }
}
