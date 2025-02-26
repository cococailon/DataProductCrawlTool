using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class Bill
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CustomerId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? PaymentMethodId { get; set; }

    public Guid? VoucherId { get; set; }

    public string BillCode { get; set; } = null!;

    public string RecipientName { get; set; } = null!;

    public string RecipientEmail { get; set; } = null!;

    public string RecipientPhone { get; set; } = null!;

    public string RecipientAddress { get; set; } = null!;

    public double TotalAmount { get; set; }

    public double DiscountAmount { get; set; }

    public double AmountAfterDiscount { get; set; }

    public double AmountToPay { get; set; }

    public int Status { get; set; }

    public int PaymentStatus { get; set; }

    public string UpdateBy { get; set; } = null!;

    public string? Notes { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();
}
