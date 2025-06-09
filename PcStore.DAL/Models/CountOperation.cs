using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class CountOperation
{
    public int Id { get; set; }

    public string CreationDate { get; set; } = null!;

    public int FromCountId { get; set; }

    public int ToCountId { get; set; }

    public double Quantity { get; set; }

    public string? Description { get; set; }

    public virtual Count FromCount { get; set; } = null!;

    public virtual Count ToCount { get; set; } = null!;
}
