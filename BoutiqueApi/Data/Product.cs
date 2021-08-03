using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoutiqueApi.Data
{
    public class Product
    {
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id { get; set; }
       public string Name { get; set; }
       public string Brand { get; set; }
       public string Category { get; set; }
       public decimal Price { get; set; }
       public bool CampaignStatus { get; set; }
       public decimal CampaignPrice { get; set; }
       public bool MostSalesProduct { get; set; }

        public virtual IList<Image> Images { get; set; }
        public virtual IList<Size> Sizes { get; set; }
    }
}
