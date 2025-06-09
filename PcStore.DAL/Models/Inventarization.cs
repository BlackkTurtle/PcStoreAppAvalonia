using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Inventarization
{
    public int Id { get; set; }

    public string CreationDate { get; set; } = null!;

    public virtual ICollection<ProductInventarization> ProductInventarizations { get; set; } = new List<ProductInventarization>();
}
