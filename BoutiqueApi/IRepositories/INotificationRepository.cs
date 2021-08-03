using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;
namespace BoutiqueApi.IRepositories
{
    public interface INotificationRepository
    {

        Task<IList<Notification>> GetAll();
        Task<Notification> Get(int Id);
        Task Insert(Notification notification);
        Task Delete(int id);
        void Update(Notification notification);
    }
}
