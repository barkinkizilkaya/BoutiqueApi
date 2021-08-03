using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class BrandDTO
    {
        [MapTo(nameof(Brand.Id))]
        public int BrandId { get; set; }

        [MapTo(nameof(Brand.Name))]
        [Required(ErrorMessage ="Marka gereklidir")]
        public string BrandName { get; set; }
    }
}
