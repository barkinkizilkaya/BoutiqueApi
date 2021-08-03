using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class OrderDTO
    {
       
        public int Id { get; set; }
      
        [Required(ErrorMessage = "Kullanıcı Adı Gereklidir")]
        public string OrderCreatedBy { get; set; }

        [Required(ErrorMessage = "Sipariş Tarihi Gereklidir")]
       
        public DateTime OrderOrderDate { get; set; }

      
        public DateTime OrderShipmentDate { get; set; }

        [Required(ErrorMessage = "Sipariş Fiyatı Gereklidir")]
     
        public decimal OrderTotalPrice { get; set; }

      
        [Required(ErrorMessage = "Sipariş Durumu Gereklidir")] 
       public string OrderOrderStatus { get; set; }

      
        [Required(ErrorMessage = "Ödeme Durumu Gereklidir")]
        public string OrderPaymentStatus { get; set; }

        [MapTo(nameof(Order.PaymentDate))]
        public DateTime OrderPaymentDate { get; set; }

      
        public int OrderTransactionId { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Gereklidir")]

     
        public string OrderPhoneNumber { get; set; }
        [Required(ErrorMessage = "Adres Gereklidir")]

      
        public string OrderAdress { get; set; }

        [Required(ErrorMessage = "Şehir Gereklidir")]
      
        public string OrderCity { get; set; }
        [Required(ErrorMessage = "İsim Gereklidir")]

      
        public string OrderFullName { get; set; }

        [Required(ErrorMessage = "Email Gereklidir")]
      
        public string OrderEmail { get; set; }

        public IList<OrderDetailDTO> OrderDetail { get; set; }
    }
}
