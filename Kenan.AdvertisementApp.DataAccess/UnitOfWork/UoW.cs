using System.Threading.Tasks;
using Kenan.AdvertisementApp.DataAccess.Contexts;
using Kenan.AdvertisementApp.DataAccess.Interfaces;
using Kenan.AdvertisementApp.DataAccess.Repositories;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.DataAccess.UnitOfWork
{
    public class UoW : IUoW
    {
        private readonly AdvertisementContext _context;

        public UoW(AdvertisementContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
