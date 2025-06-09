using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Contragent
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<ContragentDescription> ContragentDescriptions { get; set; } = new List<ContragentDescription>();

    public virtual ICollection<Nakladni> Nakladnis { get; set; } = new List<Nakladni>();
}
