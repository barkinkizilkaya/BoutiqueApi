using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BoutiqueContext _context;

        public CategoryRepository(BoutiqueContext context)
        {
            _context = context;
        }

       
        public async Task Delete(int id)
        {
            var item = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Category> Get(int Id)
        {
            IQueryable<Category> query = _context.Categories;

            return await query.AsNoTracking().FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<IList<Category>> GetAll()
        {
            IQueryable<Category> query = _context.Categories.OrderBy(o => o.Name);

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public void Update(Category category)
        {
            _context.Categories.Attach(category);
            _context.Entry(category).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
