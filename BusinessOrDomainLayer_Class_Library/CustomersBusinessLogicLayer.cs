using System;
using System.Collections.Generic;
using System.Reflection;
using Bank.Entities;
using Bank.Entities.Contracts;
using Exceptions;

using p01_ServiceLayer_Class_Library.DALContracts;
using p02_BusinessLayer_Class_Library.BALContracts;
using p03_DataAccessLayer_Class_Library;

namespace p02_BusinessLayer_Class_Library.BALContracts
{
    public class CustomersBusinessLogicLayer: ICustomersBusinessLogicLayer
    {
        #region PRIVATE FIELDS
        private ICustomersDataAccessLayer _customersDataAccessLayer;
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Constructor that initializes CustomersDataAccessLayer
        /// </summary>
        public CustomersBusinessLogicLayer()
        {
            _customersDataAccessLayer = new CustomersDataAccessLayer();
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Private property that represents reference of CustomeersDataAccessLayer
        /// </summary>
        private ICustomersDataAccessLayer CustomersDataAccessLayer
        {
            set => _customersDataAccessLayer = value;
            get => _customersDataAccessLayer;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>List of customers</returns>
        public List<Customer> GetCustomers()
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.GetCustomers();
            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// Returns a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lamdba expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.GetCustomersByCondition(predicate);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Adds a new customer to the exisiting customers list
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Returns true, that indicates the customer is added successfully</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //get all customers
                List<Customer> allCustomers = CustomersDataAccessLayer.GetCustomers();
                //long maxCustNo = 0;
                long maxCustCode = 0;
                foreach (var item in allCustomers)
                {
                    if (item.CustomerCode > maxCustCode)
                    {
                        maxCustCode = item.CustomerCode;
                    }
                }

                //generate new customer no
                if (allCustomers.Count >= 1)
                {
                    customer.CustomerCode = maxCustCode + 1;
                }
                else
                {
                    customer.CustomerCode = Configuration.Settings.BaseCustomerNo + 1;
                }
                    //generate new customer no
                    customer.CustomerCode = Configuration.Settings.BaseCustomerNo + 1;
                //invoke DAL
                return CustomersDataAccessLayer.AddCustomer(customer);

            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.UpdateCustomer(customer);

            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Returns true, that indicates the customer is deleted successfully</returns>
        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.DeleteCustomer(customerID);

            }
            catch (CustomerException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        #endregion
    }
}
