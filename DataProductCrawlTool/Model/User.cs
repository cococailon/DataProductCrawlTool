using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class User
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string AvartarUrl { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string UserDetailJson { get; set; } = null!;

    public string MetadataJson { get; set; } = null!;

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }
}
