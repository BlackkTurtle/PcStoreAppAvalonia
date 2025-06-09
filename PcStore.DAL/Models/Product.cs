using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int CategoryId { get; set; }

    public int BrandId { get; set; }

    public double Price { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<NakladniProduct> NakladniProducts { get; set; } = new List<NakladniProduct>();

    public virtual ICollection<Photo> Photos { get; set; } = new List<Photo>();

    public virtual ICollection<ProductCharacteristic> ProductCharacteristics { get; set; } = new List<ProductCharacteristic>();

    public virtual ICollection<ProductStorage> ProductStorages { get; set; } = new List<ProductStorage>();
}
