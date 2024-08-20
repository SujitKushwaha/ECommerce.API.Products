using System;
using System.Collections.Generic;

namespace ECommerce.API.Products.DataContext;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public int? Inventory { get; set; }
}
