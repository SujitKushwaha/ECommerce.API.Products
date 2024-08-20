using System;
using System.Collections.Generic;

namespace ECommerce.API.Products.DataContext;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Address { get; set; }
}
