using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class ContragentDescription
{
    public int Id { get; set; }

    public int ContragentId { get; set; }

    public string? Description { get; set; }

    public virtual Contragent Contragent { get; set; } = null!;
}
