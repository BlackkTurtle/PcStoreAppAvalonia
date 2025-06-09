using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? PhotoLink { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Characteristic> Characteristics { get; set; } = new List<Characteristic>();
}
