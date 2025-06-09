using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class ProductCharacteristic
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int CharacteristicId { get; set; }

    public int ProductId { get; set; }

    public int Order { get; set; }

    public virtual Characteristic Characteristic { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
