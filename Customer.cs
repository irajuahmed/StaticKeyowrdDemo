using System;

namespace StaticKeyowrdDemo
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }        
        public void Insert()
        {
            if (CommonTask.IsEmpty(CustomerCode) && CommonTask.IsEmpty(CustomerName))
            {
                Console.WriteLine("Customer Code & Customer Name is not empty, so data is saved.");
            }
            else
            {
                if (!CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
                {
                    Console.WriteLine("Customer Code & Customer Name both are empty, so data is not saved.");
                }
                else if (CommonTask.IsEmpty(CustomerCode) && !CommonTask.IsEmpty(CustomerName))
                {
                    Console.WriteLine("Customer Name is  empty, so data is not saved.");
                }
                else
                {
                    Console.WriteLine("Customer Code is  empty, so data is not saved.");
                }

            }
        }
    }
}