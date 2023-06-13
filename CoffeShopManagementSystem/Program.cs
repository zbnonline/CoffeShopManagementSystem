using CoffeShopManagementSystem.Abstract;
using CoffeShopManagementSystem.Concrete;
using System;

namespace CoffeShopManagementSystem.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customer = new StarbuckCustomerManager(new CustomerCheckManager());
            customer.Save(new Customer { DateOfBirth = new DateTime(2000, 8, 30), FirstName = "Ömer", 
                LastName = "Zabunoğlu", NationalityId = "61616161611" });

            Console.ReadLine();
        }
    }
}
