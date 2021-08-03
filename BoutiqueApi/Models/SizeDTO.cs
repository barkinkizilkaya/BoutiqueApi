using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class SizeDTO
    {
        [MapTo(nameof(Size.Id))]
        public int Id { get; set; }
        [Required(ErrorMessage ="Beden Adı Gereklidir")]
        public string SizeName { get; set; }
        [Required(ErrorMessage ="Stok Sayısı Gereklidir")]
        public int SizeStock { get; set; }
        [Required(ErrorMessage = "Ürün Numarası Gereklidir")]
        public int ProductId { get; set; }      
        public ProductDTO Product { get; set; }
    }
}
