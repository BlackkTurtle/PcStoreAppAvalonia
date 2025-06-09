using PcStore.DAL.Models.Enums;
using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FatherName { get; set; }

    public int DeliverAddressId { get; set; }

    public int PaymentTypeId { get; set; }

    public int NakladnaId { get; set; }

    public OrderStatus OrderStatus { get; set; }

    public string? PhoneNumber { get; set; }

    public string CreatedDate { get; set; } = null!;

    public string? Description { get; set; }

    public virtual DeliverAddress DeliverAddress { get; set; } = null!;

    public virtual Nakladni Nakladna { get; set; } = null!;

    public virtual PaymentType PaymentType { get; set; } = null!;
}
