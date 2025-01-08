using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Shop
{
    public int ShopId { get; set; }

    public int? CustomerCode { get; set; }

    public DateOnly? ShopDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? ShopNote { get; set; }

    public virtual Customer? CustomerCodeNavigation { get; set; }

    public virtual ICollection<ShopDetail> ShopDetails { get; set; } = new List<ShopDetail>();
}
