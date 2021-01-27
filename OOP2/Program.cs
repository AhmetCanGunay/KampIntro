using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Ahmet";
            customer1.Surname = "GÜNAY";
            customer1.TcNo = "15488779";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "1235556";
            customer2.TaxNumber = "112233";
            customer2.CompanyName = "Desightzer";

            //Important!
            //Base Sınıf Referans Tutucudur!
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer4);
        }
    }
}
