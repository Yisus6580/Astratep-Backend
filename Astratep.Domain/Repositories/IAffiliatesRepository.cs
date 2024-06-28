using Astratep.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astratep.Domain.Repositories
{
    public interface IAffiliatesRepository
    {
        Task<IEnumerable<Affiliate>> GetAllAsync();
    }
}
