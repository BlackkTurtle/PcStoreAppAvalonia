﻿using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
