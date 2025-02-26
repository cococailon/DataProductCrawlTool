using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class BillDetail
{
    public Guid Id { get; set; }

    public string BillDetailCode { get; set; } = null!;

    public Guid? BillId { get; set; }

    public Guid? ProductId { get; set; }

    public int Status { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }

    public string? Notes { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Bill? Bill { get; set; }

    public virtual Product? Product { get; set; }
}
