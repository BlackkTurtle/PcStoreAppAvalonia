using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Count
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public double Quantity { get; set; }

    public virtual ICollection<CountManipulation> CountManipulations { get; set; } = new List<CountManipulation>();

    public virtual ICollection<CountOperation> CountOperationFromCounts { get; set; } = new List<CountOperation>();

    public virtual ICollection<CountOperation> CountOperationToCounts { get; set; } = new List<CountOperation>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
