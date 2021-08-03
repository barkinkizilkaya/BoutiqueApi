using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class ProductDTO
    {
        [MapTo(nameof(Product.Id))]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün Adı Gereklidir")]
        [MapTo(nameof(Product.Name))]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ürün Markası Gereklidir")]
        [MapTo(nameof(Product.Brand))]
        public string ProductBrand { get; set; }
        [Required(ErrorMessage = "Ürün Kategorisi Gereklidir")]
        [MapTo(nameof(Product.Category))]
        public string ProductCategory { get; set; }
        [Required(ErrorMessage = "Ürün Fiyatı Gereklidir")]
        [MapTo(nameof(Product.Price))]
        public decimal ProductPrice { get; set; }
        [MapTo(nameof(Product.CampaignStatus))]
        public bool ProductCampaignStatus { get; set; }
        [MapTo(nameof(Product.CampaignPrice))]
        public decimal ProductCampaignPrice { get; set; }
        [MapTo(nameof(Product.MostSalesProduct))]
        public bool ProductMostSalesProduct { get; set; }

        [MapTo(nameof(Product.Images))]
        public  IList<ImageDTO> ProdutImages { get; set; }
        [MapTo(nameof(Product.Sizes))]
        public  IList<SizeDTO> ProductSizes { get; set; }
    }
}
