using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class PaymentMethod
{
    public Guid Id { get; set; }

    public string PaymentMethodCode { get; set; } = null!;

    public string PaymentMethodName { get; set; } = null!;

    public int Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string UpdatedBy { get; set; } = null!;

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }
}
