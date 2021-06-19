using System;
using SalesPersonDemo;

public interface ISellable
{
    void SalesSpeech();
    void MakeSale(int value);

}

// Class that inherits class SalesPerson
// Implements ISellable interface
class RealEstateSalesperson:SalesPerson, ISellable
{
    public double totalValueSold;
    public double totalCommission;
    public double commissionRate;
    public double TotalValueSold
    {
        get
    {
        return totalValueSold;
    }
    set
    {
        totalValueSold = value;
    }
    }
    // Declaring TotalComission
    public double TotalComission
    {
        get
    {
        return totalCommission;
    }
    set
    {
        totalCommission = value;
    }
    }

    // Declaring CommissionRate
    public double CommissionRate
    {
        get
    {
        return commissionRate;
    }
    set
    {
        commissionRate = value;
    }
    }
    public RealEstateSalesperson()
    {
        totalValueSold = 0;
        totalCommission = 0;
    }
    //Constructor that calls the base class
    public RealEstateSalesperson(string fname, string lname, double r) :base(fname, lname)
    {
        commissionRate = r;
    }
    // Implementation of ISellable interface
    public void SalesSpeech()
    {
        Console.WriteLine("Hi, my name is" + FullName() + ", a real estate person who sells homes.");
    }
    public void MakeSale(int value)
    {
        totalValueSold = (totalValueSold + value);
        totalCommission = commissionRate * totalValueSold;
    }

}