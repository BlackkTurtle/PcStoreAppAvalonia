using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class ProductStorage
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int StorageId { get; set; }

    public double Quantity { get; set; }

    public virtual ICollection<NakladniProduct> NakladniProducts { get; set; } = new List<NakladniProduct>();

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<ProductInventarization> ProductInventarizations { get; set; } = new List<ProductInventarization>();

    public virtual ICollection<ProductRestorage> ProductRestorages { get; set; } = new List<ProductRestorage>();

    public virtual Storage Storage { get; set; } = null!;
}
