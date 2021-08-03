using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;
namespace BoutiqueApi.IRepositories
{
    public interface IOrderRepository
    {
        Task<IList<Order>> GetAll(string CreatedBy);
        Task<Order> Get(int Id);
        Task Insert(Order order);
        Task Delete(int id);
        void Update(Order order);
    }
}
