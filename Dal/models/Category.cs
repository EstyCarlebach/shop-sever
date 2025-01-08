using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Category
{
    public int CatId { get; set; }

    public string CatName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
