using System.Threading.Tasks;
using Kenan.AdvertisementApp.DataAccess.Interfaces;
using Kenan.AdvertisementApp.Entities;

namespace Kenan.AdvertisementApp.DataAccess.UnitOfWork
{
    public interface IUoW
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
    }
}
