using PcStore.DAL.Models.Enums;
using System;
using System.Collections.Generic;

namespace PcStore.DAL.Models;

public partial class Comment
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? FullName { get; set; }

    public int ProductId { get; set; }

    public int? ParentId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? DateModified { get; set; }

    public int? Rating { get; set; }

    public string? Content { get; set; }

    public bool IsReview { get; set; }

    public CommentStatusEnum CommentStatus { get; set; }

    public virtual ICollection<Comment> InverseParent { get; set; } = new List<Comment>();

    public virtual Comment? Parent { get; set; }

    public virtual Product Product { get; set; } = null!;
}
