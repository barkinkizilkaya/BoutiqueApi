using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;
namespace BoutiqueApi.IRepositories
{
    public interface IOrderDetailRepository
    {

        Task<IList<OrderDetail>> GetAll(int OrderId);
        Task<OrderDetail> Get(int Id);
        Task Insert(OrderDetail orderDetail);
        Task Delete(int id);
        void Update(OrderDetail orderDetail);
    }
}
