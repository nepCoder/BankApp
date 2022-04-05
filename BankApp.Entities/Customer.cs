using System;
using BankApp.Entities.Contracts;

namespace BankApp.Entities
{
    /// <summary>
    /// Customer Class for creating new Customer using the Interface ICustomer
    /// </summary>
    public class Customer : ICustomer
    {
        //fields
        #region private fields
        private Guid _customerId;
        private long _customerCode;
        private string _customerName;
        private string _customerPhone;
        private DateTime _dateCreated;
        private DateTime _dateUpdated;
        #endregion


        //Properties
        #region public properties
        /// <summary>
        /// generates customer unique id
        /// </summary>
        public Guid CustomerId { get => _customerId; set => _customerId = value; }

        /// <summary>
        /// generates user readable code for CustomerCode
        /// </summary>
        public long CustomerCode { get => _customerCode; set => _customerCode = value; }

        /// <summary>
        /// give customer name
        /// </summary>
        public string CustomerName { get => _customerName; set => _customerName = value; }
        
        /// <summary>
        /// give customer's Phone Number
        /// </summary>
        public string CustomerPhone { get => _customerPhone; set => _customerPhone = value; }
        
        /// <summary>
        /// gives date of customer creation
        /// </summary>
        public DateTime DateCreated { get => _dateCreated; set => _dateCreated = value; }
        
        /// <summary>
        /// gives date of customer update
        /// </summary>
        public DateTime DateUpdated { get => _dateUpdated; set => _dateUpdated = value; }
        #endregion

    }
}
