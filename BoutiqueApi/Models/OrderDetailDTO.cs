using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class OrderDetailDTO
    {

        
        public int Id { get; set; }
        [Required(ErrorMessage = "Sipariş Numarası Gereklidir")]

       
        public int DetailOrderId { get; set; }

        
        public OrderDTO Order { get; set; }
        [Required(ErrorMessage = "Ürün Numarası Gereklidir")]

       
        public int DetailProductId { get; set; }

       
        public ProductDTO Product { get; set; }
        [Required(ErrorMessage = "Beden Numarası Gereklidir")]

       
        public string DetailSize { get; set; }
        [Required(ErrorMessage = "Ürün Sayısı Gereklidir")]

       
        public int DetailQuantity { get; set; }
    }
}
