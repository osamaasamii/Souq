using System;
using System.Collections.Generic;

namespace souq.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? Image { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? Date { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<ProductImages> ProductImages { get; set; } = new List<ProductImages>();
}
