using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Photo
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string? PhotoLink { get; set; }

    public virtual Product Product { get; set; } = null!;
}
