using System.ComponentModel.DataAnnotations;

namespace Shared.Entity
{
    public class ProductNameTag
    {
        #nullable disable

        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int NameTagId { get; set; }
        public NameTag NameTag { get; set; }
    }
}
