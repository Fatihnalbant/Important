using System;

namespace Classes
{
    class Program       // bir çok işi bir yerden yapmak için kullanırız.
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 123;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer 
            { 
                Id = 234, City = "İstanbul", FirstName="Fatih", LastName = "Nalbant"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }      
}
