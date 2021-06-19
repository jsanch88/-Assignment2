using System;
using SalesPersonDemo;

// Abstract class
abstract class SalesPerson
{
    // Data members
    private string fname;
    private string lname;

    public string Fname
    {
    get
    {
    return fname;
    }
    set
    {
        fname = value;
    }
    }

    // Declare a Lname property
    public string Lname
    {
        get
    {
        return lname;
    }
    set
    {
        lname = value;
    }
    }
    public SalesPerson()
    {
        fname = null;
        lname = null;
    }
    public SalesPerson(string fnm, string lnm)
    {
        fname = fnm;
        lname = lnm;
    }
    // Method returns the full name of the person
    public string FullName()
    {
        return fname + " " + lname;
    }

}