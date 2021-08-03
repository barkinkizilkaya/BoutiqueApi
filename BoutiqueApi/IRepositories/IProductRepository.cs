using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;
namespace BoutiqueApi.IRepositories
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetAll();
        Task<Product> Get(int Id);
        Task Insert(Product product);
        Task Delete(int id);
        void Update(Product product);
    }
}
