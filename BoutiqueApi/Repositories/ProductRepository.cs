using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BoutiqueContext _context;

        public ProductRepository(BoutiqueContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var item = await _context.Products.FindAsync(id);
            _context.Products.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> Get(int Id)
        {
            IQueryable<Product> query = _context.Products.Where(i=>i.Id == Id).Include(i=>i.Images).Include(i=>i.Sizes);

            return await query.AsNoTracking().FirstOrDefaultAsync();  
        }

        public async Task<IList<Product>> GetAll()
        {
            //changed
            IQueryable<Product> query = _context.Products.OrderBy(o => o.Id).Include(i => i.Images).Include(i=>i.Sizes);
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public void Update(Product product)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
