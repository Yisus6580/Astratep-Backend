using Astratep.Domain.Entities;
using Astratep.Domain.Repositories;
using Astratep.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Astratep.Infrastructure.Repositories
{
    internal class AffiliatesRepository(ApplicationDbContext dbContext) : IAffiliatesRepository
    {
        public async Task<IEnumerable<Affiliate>> GetAllAsync()
        {
            var affiliates = await dbContext.Affiliates.ToListAsync();

            return affiliates;
        }
    }
}
