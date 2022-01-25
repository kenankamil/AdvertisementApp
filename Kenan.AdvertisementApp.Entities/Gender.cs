using System.Collections.Generic;

namespace Kenan.AdvertisementApp.Entities
{
    public class Gender : BaseEntity
    {
        public string Definition { get; set; }
        public List<AppUser> appUsers { get; set; }
    }
}
