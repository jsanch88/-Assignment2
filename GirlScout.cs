using System;
using SalesPersonDemo;

namespace SalesPersonDemo
{
    class GirlScout: SalesPerson, ISellable
    {
        private int cookiesBoxes;

        public int CookiesBoxes
        {
        get
        {
        return cookiesBoxes;
        }
        set
        {
        cookiesBoxes = value;
        }
    }

        public GirlScout(string fname, string lname) :base(fname, lname)
        {
        cookiesBoxes = 0;
        }
        //Implmentation of ISellable interface
        public void SalesSpeech()
        {
        Console.WriteLine("Hi! My name is " + FullName() + ". Please buy some girl scout cookies!\n");
        }
        public void MakeSale(int boxes)
        {
        cookiesBoxes = cookiesBoxes + boxes;
        }
    }
}