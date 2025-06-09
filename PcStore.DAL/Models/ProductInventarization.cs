using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class ProductInventarization
{
    public int InventarizationId { get; set; }

    public int ProductStorageId { get; set; }

    public double QuantityDiff { get; set; }

    public virtual Inventarization Inventarization { get; set; } = null!;

    public virtual ProductStorage ProductStorage { get; set; } = null!;
}
