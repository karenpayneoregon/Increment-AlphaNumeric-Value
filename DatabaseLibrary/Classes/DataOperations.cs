using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseLibrary.Context;
using DatabaseLibrary.Models;
using Microsoft.EntityFrameworkCore;
using UtilityLibrary;

namespace DatabaseLibrary.Classes
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// No unnecessary var usage here, they are preferred
    /// yet easier for newcomers to understand seeing variable
    /// types.
    /// </remarks>
    public class DataOperations
    {
        /// <summary>
        /// Get all customer names and id for loading into in this case a ListBox
        /// </summary>
        /// <returns></returns>
        public static async Task<List<CustomerItem>> GetCustomers()
        {
            List<CustomerItem> result = new List<CustomerItem>();

            using (var context = new AccountContext())
            {
                await Task.Run(async () =>
                {
                    result = await context.Customers.AsNoTracking().Select(customer => new CustomerItem
                    {
                        Id = customer.CustomerIdentifier,
                        Name = customer.CompanyName
                    }).ToListAsync();
                });
            }

            return result;
        }
        /// <summary>
        /// Add a new order for customer
        /// </summary>
        /// <param name="customerIdentifier">Existing customer</param>
        /// <remarks>
        /// For a real application return the order or simply the order key
        /// </remarks>
        public static Order NewOrder(int customerIdentifier)
        {
            using (var context = new AccountContext())
            {
                var order = new Order()
                {
                    CustomerIdentifier = customerIdentifier,
                    InvoiceNumber = GetCustomerNextSequenceValue(customerIdentifier),
                    OrderDate = DateTime.Now
                };

                context.Orders.Add(order);
                context.SaveChanges();

                return order;
            }
        }

        /// <summary>
        /// Increment customer sequence value
        /// </summary>
        /// <param name="customerIdentifier"></param>
        /// <returns>next sequence value by customer identifier</returns>
        /// <remarks>
        /// What is not covered, resetting back to null when the sequence number reaches
        /// 999. To reset, in the else check if IncrementAlphaNumericValue returns "999" if
        /// so then set sequenceValue as done in the if e.g.
        /// sequenceValue = $"{customerSequence?.SequencePreFix}0001";
        /// That's it.
        /// </remarks>
        public static string GetCustomerNextSequenceValue(int customerIdentifier)
        {
            using (var context = new AccountContext())
            {
                Customers result = context.Customers
                    .Include(customer => customer.CustomerSequence)
                    .FirstOrDefault(customer => customer.CustomerIdentifier == customerIdentifier);

                CustomerSequence customerSequence = result?.CustomerSequence.FirstOrDefault();
                var sequenceValue = "";

                if (string.IsNullOrWhiteSpace(customerSequence?.CurrentSequenceValue))
                {
                    sequenceValue = $"{customerSequence?.SequencePreFix}0001";
                }
                else
                {
                    sequenceValue = StringHelpers.IncrementAlphaNumericValue($"{customerSequence.CurrentSequenceValue}");
                }

                customerSequence.CurrentSequenceValue = sequenceValue;
                context.SaveChanges();
                return sequenceValue;
            }

        }
        /// <summary>
        /// Get current sequence number used for things like a
        /// new order or an account number.
        /// </summary>
        /// <param name="customerIdentifier">Existing customer identifier</param>
        /// <returns>current sequence or (none)</returns>
        public static string GetCustomerCurrentSequenceValue(int customerIdentifier)
        {
            using (var context = new AccountContext())
            {
                CustomerSequence result = context.Customers
                    .Include(customer => customer.CustomerSequence)
                    .FirstOrDefault(customer => customer.CustomerIdentifier == customerIdentifier)?.CustomerSequence
                    .FirstOrDefault();

                return string.IsNullOrWhiteSpace(result?.CurrentSequenceValue) ? "(none)" : result.CurrentSequenceValue;
            }

        }
        /// <summary>
        /// Display table where OrderNumber column is computed
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Orders>> GetOrders()
        {
            var results = new List<Orders>();
            using (var context = new UserContext())
            {

                await Task.Run(async () =>
                {
                    results = await context.Orders.AsNoTracking().ToListAsync();
                });

            }

            return results;
        }
    }
}
