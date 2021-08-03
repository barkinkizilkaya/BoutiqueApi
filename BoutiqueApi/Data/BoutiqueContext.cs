using System;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Data
{
    public class BoutiqueContext : DbContext
    {
        public BoutiqueContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Device> Devices { get; set; }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    Name = "TestBrand1"
                },
                new Brand
                {
                    Id = 2,
                    Name = "TestBrand2"
                },
                new Brand
                {
                    Id = 3,
                    Name = "TestBrand3"
                },
                new Brand
                {
                    Id = 4,
                    Name = "TestBrand4"
                }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "TestCategory1"
                },
                new Category
                {
                    Id = 2,
                    Name = "TestCategory2"
                },
                new Category
                {
                    Id = 3,
                    Name = "TestCategory3"
                },
                new Category
                {
                    Id = 4,
                    Name = "TestCategory4"
                }
                );

            modelBuilder.Entity<Device>().HasData(

                new Device
                {
                    Id = 1,
                    Key = "TestKey1",
                    Platform = "TestPlatform",
                    RecordDate = DateTime.Now
                },
                new Device
                {
                    Id = 2,
                    Key = "TestKey2",
                    Platform = "TestPlatform",
                    RecordDate = DateTime.Now
                }


                );

            modelBuilder.Entity<Notification>().HasData(

              new Notification
              {
                  Id = 1,
                  Message = "Test Message",
                  RecordDate = DateTime.Now,
                  Title = "Test Title"
              },
              new Notification
              {
                  Id = 2,
                  Message = "Test Message2",
                  RecordDate = DateTime.Now,
                  Title = "Test Title"
              }


              );


            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Brand = "TestBrand1",
                    Category = "TestCategory1",
                    Price = 20,
                    Name = "TestProduct1",
                    MostSalesProduct = true,
                    CampaignStatus = false,

                },
                 new Product
                 {
                     Id = 2,
                     Brand = "TestBrand2",
                     Category = "TestCategory1",
                     Price = 20,
                     Name = "TestProduct2",
                     MostSalesProduct = true,
                     CampaignStatus = false,

                 },
                   new Product
                   {
                       Id = 3,
                       Brand = "TestBrand",
                       Category = "TestCategory2",
                       Price = 20,
                       Name = "TestProduct3",
                       MostSalesProduct = true,
                       CampaignStatus = false,

                   },
                     new Product
                     {
                         Id = 4,
                         Brand = "TestBrand3",
                         Category = "TestCategory3",
                         Price = 20,
                         Name = "TestProduct4",
                         MostSalesProduct = true,
                         CampaignStatus = false,

                     }
                     ,
                       new Product
                       {
                           Id = 5,
                           Brand = "TestBrand2",
                           Category = "TestCategory3",
                           Price = 20,
                           Name = "TestProduct5",
                           MostSalesProduct = true,
                           CampaignStatus = false,

                       },
                         new Product
                         {
                             Id = 6,
                             Brand = "TestBrand3",
                             Category = "TestCategory3",
                             Price = 20,
                             Name = "TestProduct6",
                             MostSalesProduct = true,
                             CampaignStatus = true,
                             CampaignPrice = 10

                         },
                           new Product
                           {
                               Id = 7,
                               Brand = "TestBrand",
                               Category = "TestCategory2",
                               Price = 20,
                               Name = "TestProduct7",
                               MostSalesProduct = true,
                               CampaignStatus = true,
                               CampaignPrice = 10

                           },
                             new Product
                             {
                                 Id = 8,
                                 Brand = "TestBrand4",
                                 Category = "TestCategory4",
                                 Price = 20,
                                 Name = "TestProduct8",
                                 MostSalesProduct = true,
                                 CampaignStatus = true,
                                 CampaignPrice = 10

                             },
                               new Product
                               {
                                   Id = 9,
                                   Brand = "TestBrand3",
                                   Category = "TestCategory2",
                                   Price = 20,
                                   Name = "TestProduct9",
                                   MostSalesProduct = true,
                                   CampaignStatus = true,
                                   CampaignPrice = 10

                               },
                                new Product
                                {
                                    Id = 10,
                                    Brand = "TestBrand3",
                                    Category = "TestCategory2",
                                    Price = 20,
                                    Name = "TestProduct10",
                                    MostSalesProduct = true,
                                    CampaignStatus = true,
                                    CampaignPrice = 10

                                },
                                 new Product
                                 {
                                     Id = 11,
                                     Brand = "TestBrand4",
                                     Category = "TestCategory4",
                                     Price = 20,
                                     Name = "TestProduct11",
                                     MostSalesProduct = true,
                                     CampaignStatus = true,
                                     CampaignPrice = 10

                                 },
                                   new Product
                                   {
                                       Id = 12,
                                       Brand = "TestBrand2",
                                       Category = "TestCategory1",
                                       Price = 20,
                                       Name = "TestProduct12",
                                       MostSalesProduct = true,
                                       CampaignStatus = true,
                                       CampaignPrice = 10

                                   },
                                 new Product
                                 {
                                     Id = 13,
                                     Brand = "TestBrand1",
                                     Category = "TestCategory1",
                                     Price = 20,
                                     Name = "TestProduct13",
                                     MostSalesProduct = true,
                                     CampaignStatus = true,
                                     CampaignPrice = 10

                                 }

                );

            modelBuilder.Entity<Image>().HasData(


                new Image
                {
                    Id = 2,
                    Name = "TestImage2",
                    ProductId = 1,
                    Url = "TestLink"
                },
                 new Image
                 {
                     Id = 3,
                     Name = "TestImage3",
                     ProductId = 2,
                     Url = "TestLink"
                 },
                  new Image
                  {
                      Id = 4,
                      Name = "TestImage2",
                      ProductId = 3,
                      Url = "TestLink"
                  },
                 new Image
                 {
                     Id = 5,
                     Name = "TestImage3",
                     ProductId = 4,
                     Url = "TestLink"
                 },
                  new Image
                  {
                      Id = 6,
                      Name = "TestImage2",
                      ProductId = 4,
                      Url = "TestLink"
                  },
                 new Image
                 {
                     Id = 7,
                     Name = "TestImage3",
                     ProductId = 5,
                     Url = "TestLink"
                 }
                 ,
                 new Image
                 {
                     Id = 8,
                     Name = "TestImage3",
                     ProductId = 6,
                     Url = "TestLink"
                 },
                  new Image
                  {
                      Id = 9,
                      Name = "TestImage2",
                      ProductId = 7,
                      Url = "TestLink"
                  },
                 new Image
                 {
                     Id = 10,
                     Name = "TestImage3",
                     ProductId = 8,
                     Url = "TestLink"
                 },
                  new Image
                  {
                      Id = 11,
                      Name = "TestImage2",
                      ProductId = 9,
                      Url = "TestLink"
                  },
                 new Image
                 {
                     Id = 12,
                     Name = "TestImage3",
                     ProductId = 10,
                     Url = "TestLink"
                 }
                 ,
                  new Image
                  {
                      Id = 13,
                      Name = "TestImage2",
                      ProductId = 11,
                      Url = "TestLink"
                  },
                 new Image
                 {
                     Id = 14,
                     Name = "TestImage3",
                     ProductId = 12,
                     Url = "TestLink"
                 }

            );

            modelBuilder.Entity<Size>().HasData(

          new Size
          {
              Id = 1,
              Name = "S",
              Stock = 5,
              ProductId = 1
          },
           new Size
           {
               Id = 13,
               Name = "M",
               Stock = 5,
               ProductId = 1
           },
            new Size
            {
                Id = 14,
                Name = "Xl",
                Stock = 5,
                ProductId = 1
            },
             new Size
             {
                 Id = 15,
                 Name = "XS",
                 Stock = 5,
                 ProductId = 1
             },
           new Size
           {
               Id = 2,
               Name = "S",
               Stock = 5,
               ProductId = 2
           },
             new Size
             {
                 Id = 3,
                 Name = "S",
                 Stock = 5,
                 ProductId = 3
             },
               new Size
               {
                   Id = 4,
                   Name = "S",
                   Stock = 5,
                   ProductId = 4
               },
                 new Size
                 {
                     Id = 5,
                     Name = "S",
                     Stock = 5,
                     ProductId = 5
                 },
                   new Size
                   {
                       Id = 6,
                       Name = "S",
                       Stock = 5,
                       ProductId = 6
                   },
                     new Size
                     {
                         Id = 7,
                         Name = "S",
                         Stock = 5,
                         ProductId = 7
                     },
                       new Size
                       {
                           Id = 8,
                           Name = "S",
                           Stock = 5,
                           ProductId = 8
                       },
                         new Size
                         {
                             Id = 9,
                             Name = "S",
                             Stock = 5,
                             ProductId = 9
                         },
                           new Size
                           {
                               Id = 10,
                               Name = "S",
                               Stock = 5,
                               ProductId = 10
                           },
                             new Size
                             {
                                 Id = 11,
                                 Name = "S",
                                 Stock = 5,
                                 ProductId = 11
                             },
                               new Size
                               {
                                   Id = 12,
                                   Name = "S",
                                   Stock = 5,
                                   ProductId = 12
                               }


          );

            modelBuilder.Entity<Order>().HasData(

               new Order
               {
                   Id = 1,
                   Adress="TestAdress",
                    City = "TestCity",
                     CreatedBy ="test@testmail.com",
                      Email = "test@testmail.com",
                       FullName = "Test Name Test Surname",
                        OrderDate = DateTime.Now,
                         OrderStatus = "TestStatus",
                          PaymentDate = DateTime.Now,
                           PaymentStatus = "TestStatus",
                            PhoneNumber = "12345678",
                             ShipmentDate = DateTime.Now,
                              TotalPrice = 20,
                               TransactionId=1,                             
                      
               },
                new Order
                {
                    Id = 2,
                    Adress = "TestAdress",
                    City = "TestCity",
                    CreatedBy = "test@testmail.com",
                    Email = "test@testmail.com",
                    FullName = "Test Name Test Surname",
                    OrderDate = DateTime.Now,
                    OrderStatus = "TestStatus",
                    PaymentDate = DateTime.Now,
                    PaymentStatus = "TestStatus",
                    PhoneNumber = "12345678",
                    ShipmentDate = DateTime.Now,
                    TotalPrice = 20,
                    TransactionId = 1,

                }

               );

            modelBuilder.Entity<OrderDetail>().HasData(

              new OrderDetail
              {
                  Id = 1,
                   OrderId = 1,
                     ProductId = 2,
                      Quantity= 5,
                      Size = "M"
              },
               new OrderDetail
               {
                   Id = 2,
                   OrderId = 1,
                   ProductId = 2,
                   Quantity = 5,
                   Size = "XS"
               }

              );

        }
    }
}
