using System;
using System.Collections.Generic;
using Bank.Entities;
using DomainClasses.Base;

namespace p01_ServiceLayer_Class_Library.DALContracts
{
    /// <summary>
    /// Interface that represents customers data access layer
    /// </summary>
    public interface IBaseDataAccessLayer
    {
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns></returns>
        List<Item> Get();

        /// <summary>
        /// Returns a set of customers that matches with specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        List<Item> GetByCondition(Predicate<Item> predicate);


        /// <summary>
        /// Adds a new customer to the exisiting customers list
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Returns true, that indicates the customer is added successfully</returns>
        Guid AddItem(Item item);

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update</param>
        /// <returns>Returns true, that indicates the customer is updated successfully</returns>
        bool UpdateItem(Item item);

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Returns true, that indicates the customer is deleted successfully</returns>
        bool DeleteItem(Guid itemID);
    }
}
