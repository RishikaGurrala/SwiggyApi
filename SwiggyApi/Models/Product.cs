﻿using System;
using System.Collections.Generic;

namespace SwiggyApi.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? Category { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public bool? IsActive { get; set; }
    }
}
