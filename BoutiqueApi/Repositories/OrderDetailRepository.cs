using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly BoutiqueContext _context;

        public OrderDetailRepository(BoutiqueContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var item = await _context.OrderDetails.FindAsync(id);
                _context.OrderDetails.Remove(item);
            await _context.SaveChangesAsync();

        }

        public async Task<OrderDetail> Get(int Id)
        {
            IQueryable<OrderDetail> query = _context.OrderDetails.Where(i => i.Id == Id).OrderBy(o => o.ProductId).Include(i => i.Product);
            return await query.AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<IList<OrderDetail>> GetAll(int OrderId)
        {
            IQueryable<OrderDetail> query = _context.OrderDetails.Where(i => i.OrderId == OrderId).OrderBy(o => o.ProductId).Include(i => i.Product);
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(OrderDetail orderDetail)
        {
            await _context.OrderDetails.AddAsync(orderDetail);
            await _context.SaveChangesAsync();
        }

        public void Update(OrderDetail orderDetail)
        {
             _context.OrderDetails.Attach(orderDetail);
            _context.Entry(orderDetail).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
