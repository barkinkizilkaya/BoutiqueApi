using System;
using AutoMapper;
using BoutiqueApi.Data;
using BoutiqueApi.Models;

namespace BoutiqueApi.Configuration
{
    public class Mapperinitializer : Profile
    {
        public Mapperinitializer()
        {
            CreateMap<Brand, BrandDTO>()
                  .ForMember(s => s.BrandId, x => x.MapFrom(a => a.Id))
                  .ForMember(s => s.BrandName, x => x.MapFrom(a => a.Name))
                  .ReverseMap();
            CreateMap<Category, CategoryDTO>()
                 .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                  .ForMember(s => s.CategoryName, x => x.MapFrom(a => a.Name))
                .ReverseMap();

            CreateMap<Device, DeviceDTO>()
                .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                  .ForMember(s => s.DeviceKey, x => x.MapFrom(a => a.Key))
                   .ForMember(s => s.DevicePlatform, x => x.MapFrom(a => a.Platform))
                    .ForMember(s => s.DeviceRecordDate, x => x.MapFrom(a => a.RecordDate))
                   .ReverseMap();

            CreateMap<Image, ImageDTO>()
                 .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                  .ForMember(s => s.ImageName, x => x.MapFrom(a => a.Name))
                   .ForMember(s => s.ImageUrl, x => x.MapFrom(a => a.Url))
                    .ForMember(s => s.Product, x => x.MapFrom(a => a.Product))
                       .ForMember(s => s.ProductId, x => x.MapFrom(a => a.ProductId))
                .ReverseMap();
            CreateMap<Notification, NotificationDTO>()
                 .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                  .ForMember(s => s.NotificationMessage, x => x.MapFrom(a => a.Message))
                   .ForMember(s => s.NotificationRecordDate, x => x.MapFrom(a => a.RecordDate))
                    .ForMember(s => s.NotificationTitle, x => x.MapFrom(a => a.Title))
                    
                .ReverseMap();
            CreateMap<Order, OrderDTO>()
                 .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                  .ForMember(s => s.OrderAdress, x => x.MapFrom(a => a.Adress))
                   .ForMember(s => s.OrderCity, x => x.MapFrom(a => a.City))
                    .ForMember(s => s.OrderCreatedBy, x => x.MapFrom(a => a.CreatedBy))
                      .ForMember(s => s.OrderEmail, x => x.MapFrom(a => a.Email))
                       .ForMember(s => s.OrderFullName, x => x.MapFrom(a => a.FullName))
                        .ForMember(s => s.OrderOrderDate, x => x.MapFrom(a => a.OrderDate))
                         .ForMember(s => s.OrderOrderStatus, x => x.MapFrom(a => a.OrderStatus))
                          .ForMember(s => s.OrderPaymentDate, x => x.MapFrom(a => a.PaymentDate))
                            .ForMember(s => s.OrderPaymentStatus, x => x.MapFrom(a => a.PaymentStatus))
                              .ForMember(s => s.OrderPhoneNumber, x => x.MapFrom(a => a.PhoneNumber))
                                .ForMember(s => s.OrderShipmentDate, x => x.MapFrom(a => a.ShipmentDate))
                                 .ForMember(s => s.OrderTotalPrice, x => x.MapFrom(a => a.TotalPrice))
                                  .ForMember(s => s.OrderTransactionId, x => x.MapFrom(a => a.TransactionId))
                                   .ForMember(s => s.OrderDetail, x => x.MapFrom(a => a.OrderDetail)).ReverseMap();
               

            CreateMap<OrderDetail, OrderDetailDTO>()
                .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                .ForMember(s => s.DetailOrderId, x => x.MapFrom(a => a.OrderId))
                .ForMember(s => s.DetailProductId, x => x.MapFrom(a => a.ProductId))
                .ForMember(s => s.DetailQuantity, x => x.MapFrom(a => a.Quantity))
                .ForMember(s => s.DetailSize, x => x.MapFrom(a => a.Size))
                .ForMember(s => s.Order, x => x.MapFrom(a => a.Order))
                .ForMember(s => s.Product, x => x.MapFrom(a => a.Product))
                .ReverseMap();

            CreateMap<Product, ProductDTO>()
                .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                 .ForMember(s => s.ProductBrand, x => x.MapFrom(a => a.Brand))
                  .ForMember(s => s.ProductCampaignPrice, x => x.MapFrom(a => a.CampaignPrice))
                   .ForMember(s => s.ProductCampaignStatus, x => x.MapFrom(a => a.CampaignStatus))
                    .ForMember(s => s.ProductCategory, x => x.MapFrom(a => a.Category))
                     .ForMember(s => s.ProductMostSalesProduct, x => x.MapFrom(a => a.MostSalesProduct))
                      .ForMember(s => s.ProductName, x => x.MapFrom(a => a.Name))
                       .ForMember(s => s.ProductPrice, x => x.MapFrom(a => a.Price))
                        .ForMember(s => s.ProductSizes, x => x.MapFrom(a => a.Sizes))
                         .ForMember(s => s.ProdutImages, x => x.MapFrom(a => a.Images)).ReverseMap();
            CreateMap<Size, SizeDTO>()
                .ForMember(s => s.Id, x => x.MapFrom(a => a.Id))
                 .ForMember(s => s.ProductId, x => x.MapFrom(a => a.ProductId))
                 .ForMember(s => s.SizeName, x => x.MapFrom(a => a.Name))
                 .ForMember(s => s.SizeStock, x => x.MapFrom(a => a.Stock))
                 .ForMember(s => s.Product, x => x.MapFrom(a => a.Product)).ReverseMap();



        }
    }
}
