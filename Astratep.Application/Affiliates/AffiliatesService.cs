using Astratep.Domain.Entities;
using Astratep.Domain.Repositories;

namespace Astratep.Application.Affiliates
{
    internal class AffiliatesService(IAffiliatesRepository affiliatesRepository)
    {
        public Task<IEnumerable<Affiliate>> GetAllAffiliate()
        {

        }
    }
}
