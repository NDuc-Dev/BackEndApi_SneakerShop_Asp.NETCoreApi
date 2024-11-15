﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shared.Entity
{
    public class Brand
    {
        #nullable disable
        [Key]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Brand name is required")]
        public string BrandName { get; set; }
        public string ImagePath { get; set; }
        [Required(ErrorMessage = "Descriotions is required")]
        public string Descriptions { get; set; }
        public string CreateByUserId { get; set; }
        [JsonIgnore]
        public User CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<Product> Products { get; set; }
    }
}