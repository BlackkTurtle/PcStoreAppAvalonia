using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Advertisement
{
    public int Id { get; set; }

    public string? PhotoLink { get; set; }

    public int Order { get; set; }
}
