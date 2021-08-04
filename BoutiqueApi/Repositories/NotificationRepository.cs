using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly BoutiqueContext _context;

        public NotificationRepository(BoutiqueContext context)
        {
            _context = context;
        }

        public async Task Delete(int id)
        {
            var item = await _context.Notifications.FindAsync(id);
            _context.Notifications.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Notification> Get(int Id)
        {
            IQueryable<Notification> query = _context.Notifications;
            
            return await query.AsNoTracking().FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<IList<Notification>> GetAll()
        {
            IQueryable<Notification> query = _context.Notifications.OrderBy(o => o.RecordDate);
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(Notification notification)
        {

            await _context.Notifications.AddAsync(notification);
            await _context.SaveChangesAsync();
             
        }

        public void Update(Notification notification)
        {
            _context.Notifications.Attach(notification);
            _context.Entry(notification).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
