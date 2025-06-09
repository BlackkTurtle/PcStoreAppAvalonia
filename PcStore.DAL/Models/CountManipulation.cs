using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class CountManipulation
{
    public int Id { get; set; }

    public int CountId { get; set; }

    public int ManipulationId { get; set; }

    public double Quantity { get; set; }

    public virtual Count Count { get; set; } = null!;

    public virtual Manipulation Manipulation { get; set; } = null!;
}
