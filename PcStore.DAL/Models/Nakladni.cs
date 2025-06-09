using PcStore.DAL.Models.Enums;
using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Nakladni
{
    public int Id { get; set; }

    public string CreationDate { get; set; } = null!;

    public int ContragentId { get; set; }

    public double Discount { get; set; }

    public NakladnaType NakladnaType { get; set; }

    public virtual Contragent Contragent { get; set; } = null!;

    public virtual ICollection<NakladniProduct> NakladniProducts { get; set; } = new List<NakladniProduct>();

    public virtual Order? Order { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
