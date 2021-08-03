using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BoutiqueApi.Data;

namespace BoutiqueApi.IRepositories
{
    public interface ICategoryRepository
    {
        Task<IList<Category>> GetAll();
        Task<Category> Get(int Id);
        Task Insert(Category category);
        Task Delete(int id);
        void Update(Category category);
    }
}
