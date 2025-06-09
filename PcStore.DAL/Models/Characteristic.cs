using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Characteristic
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ProductCharacteristic> ProductCharacteristics { get; set; } = new List<ProductCharacteristic>();

    public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
}
