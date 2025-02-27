﻿using System;
using System.Reflection;
using System.Collections.Generic;


[AttributeUsage(AttributeTargets.All)]
public class SoftwareAttribute : Attribute
{
    String ProjectName;
    String Description;
    String ClientName;
    String StartedDate;
    String EndDate;

    public SoftwareAttribute(String p, String d, String c, String s, String e)
    {
        ProjectName = p;
        Description = d;
        ClientName = c;
        StartedDate = s;
        EndDate = e;

    }

    public static void AttributeDisplay(Type classType)
    {
        Console.WriteLine("Methods of class {0}", classType.Name);



        MethodInfo[] methods = classType.GetMethods();



        for (int i = 0; i < methods.GetLength(0); i++)
        {


            object[] attributesArray = methods[i].GetCustomAttributes(true);

            foreach (Attribute item in attributesArray)
            {
                if (item is SoftwareAttribute)
                {


                    SoftwareAttribute attributeObject = (SoftwareAttribute)item;
                    Console.WriteLine("{0} - {1}, {2}, {3} , {4} ,{5} ", methods[i].Name, attributeObject.ProjectName, attributeObject.Description, attributeObject.ClientName, attributeObject.EndDate, attributeObject.EndDate);
                }
            }
        }
    }
}
class ICICI
{
    double AccountNumber;
    string Name;
    double Bankbalance;
    public ICICI(double a, string n, double b)
    {
        AccountNumber = a;
        Name = n;
        Bankbalance = b;
    }
    [SoftwareAttribute("accessor", "gives the values of account number", "client name icici", "5th aug", "5th aug")]
    public double getAccountNumber()
    {
        return AccountNumber;
    }
    [SoftwareAttribute("accessor", "gives the values of account holder name", "client name icici", "5th aug", "5th aug")]
    public string getName()
    {
        return Name;
    }
    [SoftwareAttribute("accessor", "gives the values of bankbalance", "client name icici", "5th aug", "5th aug")]
    public double getbankbalance()
    {
        return Bankbalance;
    }
}
class HDFC
{
    double AccountNumber;
    string Name;
    double Bankbalance;
    public HDFC(double accountNumber, string name, double bankbalance)
    {
        AccountNumber = accountNumber;
        Name = name;
        Bankbalance = bankbalance;
    }
    [SoftwareAttribute("accessor", "gives the values of account number", "client name HDFC", "5th aug", "5th aug")]
    public double getAccountNumber()
    {
        return AccountNumber;
    }
    [SoftwareAttribute("accessor", "gives the values of account holder name", "client name HDFC", "5th aug", "5th aug")]
    public string getName()
    {
        return Name;
    }
    [SoftwareAttribute("accessor", "gives the values of account holder name", "client name HDFC", "5th aug", "5th aug")]
    public double getbankbalance()
    {
        return Bankbalance;
    }
}
class Program
{


    static void Main(string[] args)
    {


        SoftwareAttribute.AttributeDisplay(typeof(ICICI));

        Console.WriteLine();

        SoftwareAttribute.AttributeDisplay(typeof(HDFC));
    }
}

