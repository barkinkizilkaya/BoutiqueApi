using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;
namespace BoutiqueApi.IRepositories
{
    public interface ISizeRepository
    {
        Task<IList<Size>> GetAll(int ProductId);
        Task<Size> Get(int Id);
        Task Insert(Size size);
        Task Delete(int id);
        void Update(Size size);
    }
}
