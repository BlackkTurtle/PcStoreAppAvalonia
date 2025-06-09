using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class NakladniProduct
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int NakladnaId { get; set; }

    public int ProductStorageId { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public double Discount { get; set; }

    public virtual Nakladni Nakladna { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual ProductStorage ProductStorage { get; set; } = null!;
}
