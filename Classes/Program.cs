using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Emre Can",
                LastName = "UĞURLU",
                City = "Hatay",
            };

            Console.WriteLine(customer.FirstName);
        }
    }
}
