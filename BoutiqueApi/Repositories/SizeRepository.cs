using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class SizeRepository : ISizeRepository
    {
        private readonly BoutiqueContext _context;

        public SizeRepository(BoutiqueContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var item = await _context.Sizes.FindAsync(id);
            _context.Sizes.Remove(item);
             await _context.SaveChangesAsync();

        }

        public async Task<Size> Get(int Id)
        {
            IQueryable<Size> query = _context.Sizes;
            query.Include("Product");
            return await query.AsNoTracking().FirstOrDefaultAsync(i=>i.Id == Id);

        }

        public async Task<IList<Size>> GetAll(int ProductId)
        {
            IQueryable<Size> query = _context.Sizes.Where(i=>i.ProductId == ProductId).OrderBy(o=>o.Name).Include(i=>i.Product);         
            return await query.AsNoTracking().ToListAsync();

        }

        public async Task Insert(Size size)
        {
            await _context.Sizes.AddAsync(size);
            await _context.SaveChangesAsync();
        }

        public  void Update(Size size)
        {
            _context.Sizes.Attach(size);
            _context.Entry(size).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
