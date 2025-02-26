using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class Product
{
    public Guid Id { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Status { get; set; }

    public string? ImageUrl { get; set; }

    public string? SortOrder { get; set; }

    public string? Description { get; set; }

    public Guid? MainCategoryId { get; set; }

    public string? RelatedIds { get; set; }

    public string? WorkFlowStates { get; set; }

    public DateTime? PublicOnDate { get; set; }

    public string MetadataJson { get; set; } = null!;

    public string CompleteName { get; set; } = null!;

    public string CompletePath { get; set; } = null!;

    public string CompleteCode { get; set; } = null!;

    public string LabelsJson { get; set; } = null!;

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual ICollection<ProductCategoriesRelation> ProductCategoriesRelations { get; set; } = new List<ProductCategoriesRelation>();
}
