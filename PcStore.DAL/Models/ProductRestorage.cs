using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class ProductRestorage
{
    public int Id { get; set; }

    public int RestorageId { get; set; }

    public int ProductStorageId { get; set; }

    public int FromStorageId { get; set; }

    public int ToStorageId { get; set; }

    public double Quantity { get; set; }

    public virtual Storage FromStorage { get; set; } = null!;

    public virtual ProductStorage ProductStorage { get; set; } = null!;

    public virtual Restorage Restorage { get; set; } = null!;

    public virtual Storage ToStorage { get; set; } = null!;
}
