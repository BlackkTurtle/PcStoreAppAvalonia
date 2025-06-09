using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int NakladnaId { get; set; }

    public int PaymentTypeId { get; set; }

    public int CountId { get; set; }

    public double Amount { get; set; }

    public string? Description { get; set; }

    public virtual Count Count { get; set; } = null!;

    public virtual Nakladni Nakladna { get; set; } = null!;

    public virtual PaymentType PaymentType { get; set; } = null!;
}
