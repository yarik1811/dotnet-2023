﻿namespace StoreApp.Domain;

/// <summary>
/// Customer - Class describing the buyer
/// </summary>
public class Customer
{
    /// <summary>
    /// Full name of customer
    /// </summary>
    public string CustomerName { get; set; } = string.Empty;

    /// <summary>
    /// Customer card number
    /// </summary>
    public int CustomerCardNumber { get; set; } = -1;

    /// <summary>
    /// Customer purchase ID collection
    /// </summary>
    public List<int> SalesId { get; set; }

    public Customer(string customerName, int customerCardNumber)
    {
        CustomerName = customerName;
        CustomerCardNumber = customerCardNumber;
        SalesId = new List<int>();
    }

    /// <summary>
    /// Method for adding sales id to the collection
    /// </summary>
    /// <param name="idsale">
    /// ID sale
    /// </param>
    public void AddToSalesList(int idSale)
    {
        SalesId.Add(idSale);
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Customer param)
            return false;

        return CustomerName == param.CustomerName &&
               CustomerCardNumber == param.CustomerCardNumber;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(CustomerName, CustomerCardNumber);
    }
}

