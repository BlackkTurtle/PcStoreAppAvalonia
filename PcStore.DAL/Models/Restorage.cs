using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Restorage
{
    public int Id { get; set; }

    public string RestorageDate { get; set; } = null!;

    public virtual ICollection<ProductRestorage> ProductRestorages { get; set; } = new List<ProductRestorage>();
}
