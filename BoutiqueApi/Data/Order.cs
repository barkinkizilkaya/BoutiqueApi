using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoutiqueApi.Data
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipmentDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public int TransactionId { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string FullName{ get; set; }
        public string Email { get; set; }

        public virtual IList<OrderDetail> OrderDetail { get; set; }

    }
}
