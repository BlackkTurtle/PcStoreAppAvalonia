using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class DeliverOption
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<DeliverAddress> DeliverAddresses { get; set; } = new List<DeliverAddress>();
}
