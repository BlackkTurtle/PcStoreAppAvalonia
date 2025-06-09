using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class DeliverAddress
{
    public int Id { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? FullAddress { get; set; }

    public int DeliverOptionId { get; set; }

    public virtual DeliverOption DeliverOption { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
