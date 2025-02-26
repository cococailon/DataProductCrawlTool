using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class ProductCategoriesRelation
{
    public Guid Id { get; set; }

    public Guid IdProduct { get; set; }

    public Guid CategoriesId { get; set; }

    public string ProductName { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string RelationType { get; set; } = null!;

    public int? Order { get; set; }

    public bool? IsPublish { get; set; }

    public DateTime? PublishStartDate { get; set; }

    public DateTime? PublishEndDate { get; set; }

    public DateTime? PublishOnDate { get; set; }

    public string? Status { get; set; }

    public string Description { get; set; } = null!;

    public string RelatedObjJson { get; set; } = null!;

    public string RelatedObj2Json { get; set; } = null!;

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual Category Categories { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
