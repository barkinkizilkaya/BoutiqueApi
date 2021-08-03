using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class ImageDTO
    {
        [MapTo(nameof(Image.Id))]
        public int Id { get; set; }
        [Required(ErrorMessage = "Resim Adı Gereklidir")]
        [MapTo(nameof(Image.Name))]
        public string ImageName { get; set; }
        [Required(ErrorMessage = "Resim Linki Gereklidir")]
        [MapTo(nameof(Image.Url))]
        public string ImageUrl { get; set; }
        [MapTo(nameof(Image.ProductId))]
        [Required(ErrorMessage = "Resim Ürün Numarası Gereklidir")]
        public int ProductId { get; set; }
        [MapTo(nameof(Image.Product))]
        public ProductDTO Product { get; set; }
    }
}
