using Bank.Entities;
using Exceptions;
using p01_ServiceLayer_Class_Library.DALContracts;

namespace p03_DataAccessLayer_Class_Library
{
    /// <summary>
    /// Represents DAL for bank customers
    /// </summary>
    public class CustomersDataAccessLayer: ICustomersDataAccessLayer
    {
        #region FIELDS
        private static List<Customer> _customers;
        #endregion

        #region CONSTRUCTORS    
        static CustomersDataAccessLayer()
        {
            _customers = new List<Customer>();
        }
        #endregion

        #region PROPERTIES
        private static List<Customer> Customers
        {
            set => _customers = value;
            get => _customers;
        }
        #endregion

        #region METHODS
        public List<Customer> GetCustomers()
        {

            try
            {
                //create a new customer list
                List<Customer> customersList = new List<Customer>();
                Customers.ForEach(item => customersList.Add(item.Clone() as Customer));
                return customersList;
            }
            catch (CustomerException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Returns list of customers that are matching with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with condition</param>
        /// <returns>List of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {


            try
            {
                //create a new customers list
                List<Customer> customersList = new List<Customer>();

                //filter the collection
                List<Customer> filteredCustomers = Customers.FindAll(predicate);

                //copy all customers from the source collection into the newCustomers list
                Customers.ForEach(item => customersList.Add(item.Clone() as Customer));
                return customersList;
            }
            catch (CustomerException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Adds a new customer to the existing list
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <returns>Returns Guid of newly created customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            //generate new Guid
            customer.CustomerID = Guid.NewGuid();

            //add customer
            Customers.Add(customer);

            return customer.CustomerID;


        }

        /// <summary>
        /// Updates an existing customer's details
        /// </summary>
        /// <param name="customer">Customer object with updated details</param>
        /// <returns>Determines whether the customer is updated or not</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //find existing customer by CustomerID
                Customer existingCustomer = Customers.Find(item => item.CustomerID == customer.CustomerID);

                //update all details of customer
                if (existingCustomer != null)
                {
                    existingCustomer.CustomerCode = customer.CustomerCode;
                    existingCustomer.CustomerName = customer.CustomerName;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.Landmark = customer.Landmark;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.Mobile = customer.Mobile;

                    return true;
                }

                return false; //indicates no object is updated
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Deletes an existing customer based on CustomerID
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>Indicates whether the customer is deleted or not</returns>
        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                if (Customers.RemoveAll(item => item.CustomerID == customerID) > 0)
                {
                    return true; // indicates one or more customers are deleted
                }
                else
                {
                    return false;
                }

            }
            catch (CustomerException ex)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
            //delete customer by CustomerID
            
        
        }


        #endregion
    }
}
