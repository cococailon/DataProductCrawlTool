using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class Cart
{
    public Guid Id { get; set; }

    public Guid IdUser { get; set; }

    public Guid IdContact { get; set; }

    public int Status { get; set; }

    public string Description { get; set; } = null!;

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }
}
