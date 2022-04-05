using System;

namespace BankApp.Entities.Contracts
{
    /// <summary>
    /// an Interface for customer entity class
    /// </summary>
    public interface ICustomer
    {
        Guid CustomerId { get; set; }
        long CustomerCode { get; set; }
        string CustomerName { get; set; }
        string CustomerPhone { get; set; }
        DateTime DateCreated { get; set; }


    }
}