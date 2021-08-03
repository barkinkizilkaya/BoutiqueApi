using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class OrderRepository: IOrderRepository
    {
        private readonly BoutiqueContext _context;

        public OrderRepository(BoutiqueContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
           var item = await _context.Orders.FindAsync(id);
                       _context.Orders.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async  Task<Order> Get(int Id)
        {
            IQueryable<Order> query = _context.Orders;
            query.Include("OrderDetail");
            return await query.AsNoTracking().FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<IList<Order>> GetAll(string CreatedBBy)
        {
            IQueryable<Order> query = _context.Orders.Where(i => i.CreatedBy == CreatedBBy).OrderBy(o => o.OrderDate).Include(i=>i.OrderDetail);
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }

        public void Update(Order order)
        {
             _context.Orders.Attach(order);
            _context.Entry(order).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
