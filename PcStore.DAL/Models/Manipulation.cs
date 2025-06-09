using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Manipulation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Operation { get; set; }

    public virtual ICollection<CountManipulation> CountManipulations { get; set; } = new List<CountManipulation>();
}
