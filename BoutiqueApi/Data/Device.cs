using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoutiqueApi.Data
{
    public class Device
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       public string Platform { get; set; }
       public string Key { get; set; }
       public DateTime RecordDate { get; set; }

    }
}
