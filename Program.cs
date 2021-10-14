using System;

namespace StaticKeyowrdDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer aCustomer = new Customer { CustomerCode="",CustomerName="44444"};
            aCustomer.Insert();


            CountryMaster aCountryMaster = new CountryMaster();
            aCountryMaster.Insert();


            Console.ReadKey();
        }
    }
}
