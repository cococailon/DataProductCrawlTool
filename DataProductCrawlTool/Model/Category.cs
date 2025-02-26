using System;
using System.Collections.Generic;

namespace DataProductCrawlTool.Model;

public partial class Category
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public Guid ParentId { get; set; }

    public int SortOrder { get; set; }

    public string Type { get; set; } = null!;

    public string ParentPath { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string CompleteCode { get; set; } = null!;

    public string CompleteName { get; set; } = null!;

    public string CompletePath { get; set; } = null!;

    public string MetadataJson { get; set; } = null!;

    public Guid? CreatedByUserId { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public bool? Isdeleted { get; set; }

    public virtual ICollection<ProductCategoriesRelation> ProductCategoriesRelations { get; set; } = new List<ProductCategoriesRelation>();
}
