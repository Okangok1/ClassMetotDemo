using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Mert";
            customer1.CustomerLastName = "yıldız";
            customer1.CustomerPhoneNumber = "111111111111";
            customer1.CustomerCity = "istanbul";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Merve";
            customer2.CustomerLastName = "İrem";
            customer2.CustomerPhoneNumber = "22222222222";
            customer2.CustomerCity = "Amasya";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Okan";
            customer3.CustomerLastName = "Gök";
            customer3.CustomerPhoneNumber = "33333333333";
            customer3.CustomerCity = "Ordu";

            Customer customer4 = new Customer();
            customer4.CustomerId = 3;
            customer4.CustomerName = "Okan";
            customer4.CustomerLastName = "Gök";
            customer4.CustomerPhoneNumber = "33333333333";
            customer4.CustomerCity = "Ordu";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.GetAll(customer1, customer2, customer3);
            customerManager.Delete(customer3);
            

        }
    }
}
