﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Entity
{
    public class ProductColorSize
    {
        #nullable disable

        [Key]
        public int ProductColorSizeId { get; set; }
        public int ProductColorId { get; set; }
        public ProductColor ProductColor { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public int Quantity { get; set; }
        public ICollection<OrderDetails> Details { get; set; }

    }
}
