
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;

namespace BoutiqueApi.IRepositories
{
    public interface IBrandRepository
    {
        Task<IList<Brand>> GetAll();
        Task<Brand> Get(int Id);
        Task Insert(Brand brand);
        Task Delete(int id);
        void Update(Brand brand);
    }
}
