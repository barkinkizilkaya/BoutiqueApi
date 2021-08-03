using System;
using System.ComponentModel.DataAnnotations;
using AutoMapper.Configuration.Conventions;
using BoutiqueApi.Data;

namespace BoutiqueApi.Models
{
    public class NotificationDTO
    {
        [MapTo(nameof(Notification.Id))]
        public int Id { get; set; }
        [Required(ErrorMessage = "Mesaj Başlığı Gereklidir")]
        [MapTo(nameof(Notification.Title))]
        public string NotificationTitle { get; set; }
        [Required(ErrorMessage = "Mesaj Gereklidir")]
        [MapTo(nameof(Notification.Message))]
        public string NotificationMessage { get; set; }
        [Required(ErrorMessage = "Mesaj Tarihi Gereklidir")]
        [MapTo(nameof(Notification.RecordDate))]
        public DateTime NotificationRecordDate { get; set; }
    }
}
