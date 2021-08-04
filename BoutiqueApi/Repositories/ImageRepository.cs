using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly BoutiqueContext _context;

        public ImageRepository(BoutiqueContext context)
        {
            _context = context;
        }
        

        public async Task Delete(int id)
        {
            var item = await _context.Images.FindAsync(id);
            _context.Images.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Image> Get(int Id)
        {
            IQueryable<Image> query = _context.Images;

            return await query.AsNoTracking().FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<IList<Image>> GetAll(int ProductId)
        {
            IQueryable<Image> query = _context.Images.Where(i => i.ProductId == ProductId).OrderBy(o => o.Name);
            return await query.AsNoTracking().ToListAsync();

        }

        public async Task Insert(Image image)
        {
          await  _context.Images.AddAsync(image);
          await  _context.SaveChangesAsync();
        }


        public void Update(Image image)
        {
            _context.Images.Attach(image);
            _context.Entry(image).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
