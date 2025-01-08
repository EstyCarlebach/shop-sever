using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Product
{
    public int ProdId { get; set; }

    public string ProdName { get; set; } = null!;

    public int? CatCode { get; set; }

    public int? CompanyCode { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? Image { get; set; }

    public int? StockQty { get; set; }

    public DateOnly? LastUpdated { get; set; }

    public virtual Category? CatCodeNavigation { get; set; }

    public virtual Company? CompanyCodeNavigation { get; set; }

    public virtual ICollection<ShopDetail> ShopDetails { get; set; } = new List<ShopDetail>();
}
