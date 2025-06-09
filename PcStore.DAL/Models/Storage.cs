using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Storage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ProductRestorage> ProductRestorageFromStorages { get; set; } = new List<ProductRestorage>();

    public virtual ICollection<ProductRestorage> ProductRestorageToStorages { get; set; } = new List<ProductRestorage>();

    public virtual ICollection<ProductStorage> ProductStorages { get; set; } = new List<ProductStorage>();
}
