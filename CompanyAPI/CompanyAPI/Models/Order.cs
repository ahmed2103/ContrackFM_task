#nullable disable
using System;
using System.Collections.Generic;

namespace CompanyAPI.Models;

public partial class Order
{
    public string Id { get; set; }

    public string CustomerId { get; set; }

    public int ProductId { get; set; }

    public int Amount { get; set; }

    public virtual Customer Customer { get; set; }

    public virtual Product Product { get; set; }
}