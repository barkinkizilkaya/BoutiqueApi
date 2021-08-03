using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoutiqueApi.Data
{
    public class Notification
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       public string Title { get; set; }
       public string Message { get; set; }
       public DateTime RecordDate { get; set; }
    }
}
