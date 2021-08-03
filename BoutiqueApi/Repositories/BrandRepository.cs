using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly BoutiqueContext _context;

        public BrandRepository(BoutiqueContext context)
        {
            _context = context;
        }

        
        public async Task Delete(int id)
        {
            var item = await _context.Brands.FindAsync(id);
            _context.Brands.Remove(item);
            await _context.SaveChangesAsync();
        }

        public Task<Brand> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Brand>> GetAll()
        {
            IQueryable<Brand> query = _context.Brands.OrderBy(o=>o.Name);

            return await query.AsNoTracking().ToListAsync();

        }

        public async Task Insert(Brand brand)
        {
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
        }

        public void Update(Brand brand)
        {
            _context.Brands.Attach(brand);
            _context.Entry(brand).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
