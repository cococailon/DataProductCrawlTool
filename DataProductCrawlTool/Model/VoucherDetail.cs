using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class VoucherDetail
{
    public Guid Id { get; set; }

    public Guid VoucherId { get; set; }

    public Guid BillId { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }
}
