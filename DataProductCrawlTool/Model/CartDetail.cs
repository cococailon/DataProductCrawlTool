using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class CartDetail
{
    public Guid Id { get; set; }

    public Guid IdCart { get; set; }

    public Guid IdProduct { get; set; }

    public int? Quantity { get; set; }

    public bool? IsOnSale { get; set; }

    public string? Code { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }
}
