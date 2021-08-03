using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class CategoryDTO
    {
        [MapTo(nameof(Category.Id))]
        public int Id { get; set; }

        [MapTo(nameof(Category.Name))]
        [Required(ErrorMessage = "Kategori gereklidir")]
        public string CategoryName { get; set; }
    }
}
