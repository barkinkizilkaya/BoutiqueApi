using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;
namespace BoutiqueApi.IRepositories
{
    public interface IImageRepository
    {

        Task<IList<Image>> GetAll(int ProductId);
        Task<Image> Get(int Id);
        Task Insert(Image image);
        Task Delete(int id);
        void Update(Image image);
    }
}
