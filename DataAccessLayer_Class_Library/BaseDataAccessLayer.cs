using Bank.Entities;
using DomainClasses.Base;
using Exceptions;
using p01_ServiceLayer_Class_Library.DALContracts;

namespace p03_DataAccessLayer_Class_Library
{
    /// <summary>
    /// Represents DAL for bank Items
    /// </summary>
    public class BaseDataAccessLayer: IBaseDataAccessLayer
    {
        #region FIELDS
        private static List<Item> _items;
        #endregion

        #region CONSTRUCTORS    
        static BaseDataAccessLayer()
        {
            _items = new List<Item>();
        }
        #endregion

        #region PROPERTIES
        private static List<Item> Items
        {
            set => _items = value;
            get => _items;
        }
        #endregion

        #region METHODS
        public List<Item> Get()
        {

            try
            {

                return Enumerable.Range(1, 5).Select(index => new Item
                {
                    Name = "Something"
                }).ToList();

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
        /// Returns list of Items that are matching with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with condition</param>
        /// <returns>List of matching Items</returns>
        public List<Item> GetByCondition(Predicate<Item> predicate)
        {


            try
            {
                //create a new Items list
                List<Item> ItemsList = new List<Item>();

                //filter the collection
                List<Item> filteredItems = Items.FindAll(predicate);

                //copy all Items from the source collection into the newItems list
                Items.ForEach(item => ItemsList.Add(item as Item));
                return ItemsList;
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
        public Guid AddItem(Item item)
        {
            //generate new Guid
            item.Id = Guid.NewGuid();

            //add customer
            Items.Add(item);

            return item.Id;


        }

        /// <summary>
        /// Updates an existing customer's details
        /// </summary>
        /// <param name="customer">Customer object with updated details</param>
        /// <returns>Determines whether the customer is updated or not</returns>
        public bool UpdateItem(Item item)
        {
            try
            {
                //find existing customer by CustomerID
                Item existingItem = _items.Find(item => item.Id == item.Id);

                //update all details of customer
                if (existingItem != null)
                {
                    existingItem.Name = item.Name;

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
        public bool DeleteItem(Guid customerID)
        {
            try
            {
                if (Items.RemoveAll(item => item.Id == customerID) > 0)
                {
                    return true; // indicates one or more Items are deleted
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
