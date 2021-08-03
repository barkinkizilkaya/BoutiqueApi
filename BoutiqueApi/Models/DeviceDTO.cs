using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class DeviceDTO
    {
        [MapTo(nameof(Device.Id))]
        public int Id { get; set; }
        [Required(ErrorMessage = "Cihaz Platformu gereklidir")]
        [MapTo(nameof(Device.Platform))]
        public string DevicePlatform { get; set; }
        [Required(ErrorMessage = "Cihaz Numarası gereklidir")]
        [MapTo(nameof(Device.Key))]
        public string DeviceKey { get; set; }
        [Required(ErrorMessage = "Cihaz Kayıt Tarihi gereklidir")]
        [MapTo(nameof(Device.RecordDate))]
        public DateTime DeviceRecordDate { get; set; }
    }
}
