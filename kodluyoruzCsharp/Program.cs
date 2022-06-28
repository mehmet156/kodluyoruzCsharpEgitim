using System;

namespace kodluyoruzCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string yirmi = "20";
            // int yirmiInt = 20;
            // string sonuc = null;

            //sonuc =yirmi+yirmiInt.ToString();
            // Console.WriteLine(sonuc);
            string sayi1 = null;
            string sayi2 = null;

            Console.WriteLine("sayi1 giriniz");
            sayi1 = Console.ReadLine();
            Console.WriteLine("sayi2 giriniz");
            sayi2 = Console.ReadLine();
            Convert.ToInt32(sayi1);

            if (Convert.ToInt32(sayi1) <= Convert.ToInt32(sayi2))
            {
                Console.WriteLine("sayi1 küçük yada eşit");
            }
            else
                Console.WriteLine("sayi1 büyük");


        }
    }
}
