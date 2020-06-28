using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseLibrary.Models
{
    /// <summary>
    /// Table mapping as we have two different databases
    /// with a order table.
    /// </summary>
    [Table("Orders")]
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? CustomerIdentifier { get; set; }
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// No default value as this allows back dating
        /// </summary>
        public DateTime? OrderDate { get; set; }

        public virtual Customers CustomerIdentifierNavigation { get; set; }
    }
}