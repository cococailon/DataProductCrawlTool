using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class Customer
{
    public Guid Id { get; set; }

    public string? Code { get; set; }

    public Guid? Ttthidmain { get; set; }

    public string? TtlhrelateIdsJson { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }

    public string? UserName { get; set; }

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }
}
