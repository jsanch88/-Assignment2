using System;
using SalesPersonDemo;

namespace SalesPersonDemo
{
    class SalesPersonDemo
    {
        static void Main(string[] args)
        {
            // Creating object class RealEstateSalesperson
            RealEstateSalesperson r  = new RealEstateSalesperson(" Jonathan", "Sanchez", 0.10);

            // Creating object class GirlScout
            GirlScout g = new GirlScout("Yajaira", "Lara-Sanchez");
            
            // Call method SalesSpeech of object r
            r.SalesSpeech();

            // Call method to MakeSale of object r
            r.MakeSale(1000);
            
            Console.WriteLine("After sale 1:");
            Console.WriteLine("Total value sold: " + r.TotalValueSold.ToString("C"));
            Console.WriteLine("Total Commission Earned: " + r.totalCommission.ToString("C") + "\n");
            
            r.MakeSale(10000);

            Console.WriteLine("After sale 2:");
            Console.WriteLine("$Total value sold: " + r.TotalValueSold.ToString("C"));
            Console.WriteLine("Total Comission Earned: " + r.totalCommission.ToString("C") + "\n");

            // Call method SalesSpeech of object g
            g.SalesSpeech();
            // Call method MakeSale of object g
            g.MakeSale(100);
            Console.WriteLine("After sale 1:");
            Console.WriteLine("Total Cookies Sold: " + g.CookiesBoxes);

            g.MakeSale(200);
            Console.WriteLine("After sale 2:");
            Console.WriteLine("Total Cookies Sold:" + g.CookiesBoxes);
            Console.ReadLine();

        }
    }
}
