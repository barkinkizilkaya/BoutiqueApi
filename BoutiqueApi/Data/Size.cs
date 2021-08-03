using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoutiqueApi.Data
{
    public class Size
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
         public string Name { get; set; }
        public int Stock { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
