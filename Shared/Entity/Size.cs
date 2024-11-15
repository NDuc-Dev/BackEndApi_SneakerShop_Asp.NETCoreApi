using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Entity
{
    public class Size
    {
        #nullable disable

        [Key]
        public int SizeId { get; set; }
        [Required(ErrorMessage = "Size value is required")]
        public int SizeValue { get; set; }
        public ICollection<ProductColorSize> ProductColorSize { get; set; }
    }
}
