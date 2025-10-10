﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities;
using Exceptions;
using Bank.Entities.Contracts;
using p02_BusinessLayer_Class_Library;
using p02_BusinessLayer_Class_Library.BALContracts;

namespace Bank.Presentation
{
    public static class CustomersPresentation
    {
        internal static void AddCustomer()
        {

            try
            {
                //create an object of Customer
                Customer customer = new Customer();

                //read all detail from the user
                Console.WriteLine("\n*********ADD CUSTOMER**************");
                Console.Write("Customer Name: ");
                customer.CustomerName = Console.ReadLine();
                Console.Write("Address:");
                customer.Address = Console.ReadLine();
                Console.Write("LandMark: ");
                customer.Landmark = Console.ReadLine();
                Console.Write("City: ");
                customer.City = Console.ReadLine();
                Console.Write("Country: ");
                customer.Country = Console.ReadLine();
                Console.Write("Mobile: ");
                customer.Mobile = Console.ReadLine();

                ICustomersBusinessLogicLayer customerBusinessLogicLayer = new CustomersBusinessLogicLayer();
                Guid newGuid = customerBusinessLogicLayer.AddCustomer(customer);

                List<Customer> matchingCustomers = 
                    customerBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == newGuid);

                if (matchingCustomers.Count >= 1)
                {
                    Console.WriteLine("New Customer Code: " + matchingCustomers[0].CustomerCode);
                    Console.WriteLine("Customer Added.\n");
                }
                else
                {
                    Console.WriteLine("Customer Not added");
                }
                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());

                throw;
            }
            

        }

        internal static void ViewCustomers()
        {
            try
            {
                //Create BL object
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

                List<Customer> allCustomers = customersBusinessLogicLayer.GetCustomers();
                Console.WriteLine("\n******ALL CUSTOMERS**********");

                //read all customers
                foreach (var item in allCustomers)
                {
                    Console.WriteLine("Customer Code: " + item.CustomerCode);
                    Console.WriteLine("Customer Name: " + item.CustomerName);
                    Console.WriteLine("Address: " + item.Address);
                    Console.WriteLine("Landmark: " + item.Landmark);
                    Console.WriteLine("City: " + item.City);
                    Console.WriteLine("Country: " + item.Country);
                    Console.WriteLine("Mobile: " + item.Mobile);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
