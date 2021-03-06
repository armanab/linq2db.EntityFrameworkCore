﻿using System.Collections.Generic;

namespace LinqToDB.EntityFrameworkCore.BaseTests.Models.Northwind
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
