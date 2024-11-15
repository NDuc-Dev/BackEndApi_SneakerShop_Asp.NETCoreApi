using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Entity
{
    public class Color
    {
        #nullable disable

        [Key]
        public int ColorId { get; set; }
        [Required(ErrorMessage = "Color name is required")]
        public string ColorName { get; set; }
        public ICollection<ProductColor> ProductColor { get; set; }

    }
}
