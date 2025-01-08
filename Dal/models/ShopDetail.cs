using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class ShopDetail
{
    public int ShopDetailsId { get; set; }

    public int? ShopCode { get; set; }

    public int? ProductCode { get; set; }

    public int? Quantity { get; set; }

    public virtual Product? ProductCodeNavigation { get; set; }

    public virtual Shop? ShopCodeNavigation { get; set; }
}
