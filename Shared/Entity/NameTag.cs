using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.Entity
{
    public class NameTag
    {
        #nullable disable

        [Key]
        public int NameTagId { get; set; }
        [Required(ErrorMessage = "Tag name is required")]
        public string Tag {  get; set; }
        public ICollection<ProductNameTag> ProductTags { get; set; }
    }
}
