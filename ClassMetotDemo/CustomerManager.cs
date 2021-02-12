using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager : Program
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müsteri Id: " + customer.CustomerId);
            Console.WriteLine("Müsteri ismi : " + customer.CustomerName);
            Console.WriteLine("Müsteri Soy isim" + customer.CustomerLastName);
            Console.WriteLine("Müsteri Numarası : " + customer.CustomerPhoneNumber);
            Console.WriteLine("Müsteri Sehri : " + customer.CustomerCity);
            Console.WriteLine("bilgiler kaydediliyor.");

        }

        public void Delete(Customer customer)
        {
            customer.CustomerId = customer.CustomerId;
            customer.CustomerName = null;
            customer.CustomerLastName = null;
            customer.CustomerPhoneNumber = null;
            customer.CustomerCity = null;

            Console.WriteLine("Müsteri Id: " + customer.CustomerId + " numaralı müsteri silindi");
            Console.WriteLine("Müsteri ismi : " + customer.CustomerName + " silindi");
            Console.WriteLine("Müsteri Soy isim" + customer.CustomerLastName + " silindi");
            Console.WriteLine("Müsteri Numarası : " + customer.CustomerPhoneNumber + " silindi");
            Console.WriteLine("Müsteri Sehri : " + customer.CustomerCity + " silindi");
        }
        public void GetAll(Customer customer, Customer customer1, Customer customer2)
        {
            Customer[] customers1 = new Customer[] { customer, customer1, customer2 };


            foreach (Customer custo in customers1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Müsteri Id: " + custo.CustomerId);
                Console.WriteLine("Müsteri ismi : " + custo.CustomerName);
                Console.WriteLine("Müsteri Soy isim" + custo.CustomerLastName);
                Console.WriteLine("Müsteri Numarası : " + custo.CustomerPhoneNumber);
                Console.WriteLine("Müsteri Sehri : " + custo.CustomerCity);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
