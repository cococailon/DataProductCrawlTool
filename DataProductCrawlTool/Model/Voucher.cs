using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class Voucher
{
    public Guid Id { get; set; }

    public string VoucherName { get; set; } = null!;

    public int VoucherType { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Status { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }
}
