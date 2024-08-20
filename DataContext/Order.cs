using System;
using System.Collections.Generic;

namespace ECommerce.API.Products.DataContext;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    public string? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? Total { get; set; }
}
