using System;

namespace TestClassifiedAd
{
    class Program
    {
        static void Main(string[] args)
        {
            string category1, category2;
            int numWords1, numWords2;

            ClassifiedAd ad1 = new ClassifiedAd();
            Console.WriteLine("Please enter the category of ad 1");
            category1 = Console.ReadLine();
            Console.WriteLine("Please enter the number of words");
            numWords1 = Convert.ToInt32(Console.ReadLine());
            ad1.Category = category1;
            ad1.Words = numWords1;

            ClassifiedAd ad2 = new ClassifiedAd();
            Console.WriteLine("Please enter the category of ad 2");
            category2 = Console.ReadLine();
            Console.WriteLine("Please enter the number of words");
            numWords2 = Convert.ToInt32(Console.ReadLine());
            ad2.Category = category2;
            ad2.Words = numWords2;

            Console.WriteLine($"Advert 1: \n Category: {ad1.Category} \n Words: {ad1.Words} \n Price {ad1.Price}");
            Console.WriteLine("..............................");
            Console.WriteLine($"Advert 2: \n Category: {ad2.Category} \n Words: {ad2.Words} \n Price {ad2.Price}");
        }
    }
}
