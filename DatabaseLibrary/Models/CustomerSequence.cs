

namespace DatabaseLibrary.Models
{
    /// <summary>
    /// Container for storing and retriving sequence values
    /// for customers
    /// </summary>
    public partial class CustomerSequence
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Customer identifier in the Customers table
        /// </summary>
        public int? CustomerIdentifier { get; set; }
        /// <summary>
        /// Current sequence value for a specific customer
        /// </summary>
        public string CurrentSequenceValue { get; set; }
        /// <summary>
        /// Unique prefix per customer
        /// </summary>
        public string SequencePreFix { get; set; }

        public virtual Customers CustomerIdentifierNavigation { get; set; }
    }
}