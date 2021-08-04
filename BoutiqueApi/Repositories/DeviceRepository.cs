using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoutiqueApi.Data;
using BoutiqueApi.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueApi.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly BoutiqueContext _context;

        public DeviceRepository(BoutiqueContext context)
        {
            _context = context;
        }

       

        public async Task Delete(int id)
        {
            var item = await _context.Devices.FindAsync(id);
            _context.Devices.Remove(item);
          await  _context.SaveChangesAsync();
        }

        public async Task<Device> Get(int Id)
        {
            IQueryable<Device> query = _context.Devices;

            return await query.AsNoTracking().FirstOrDefaultAsync(i => i.Id == Id);
        }

        public async Task<IList<Device>> GetAll()
        {
            IQueryable<Device> query = _context.Devices.OrderBy(o => o.RecordDate);

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(Device device)
        {
           await _context.Devices.AddAsync(device);
           await _context.SaveChangesAsync();
        }

        public void Update(Device device)
        {
            _context.Devices.Attach(device);
            _context.Entry(device).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
