using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;

namespace BoutiqueApi.IRepositories
{
    public interface IDeviceRepository
    {
        Task<IList<Device>> GetAll();
        Task<Device> Get(int Id);
        Task Insert(Device category);
        Task Delete(int id);
        void Update(Device category);
    }
}
