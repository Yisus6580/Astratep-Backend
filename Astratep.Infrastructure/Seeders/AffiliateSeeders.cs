using Astratep.Domain.Entities;
using Astratep.Infrastructure.Persistence;

namespace Astratep.Infrastructure.Seeders
{
    internal class AffiliateSeeders(ApplicationDbContext dbContext) : IAffiliateSeeders
    {
        public async Task Seed()
        {
            if (await dbContext.Database.CanConnectAsync())
            {
                if (!dbContext.Affiliates.Any())
                {
                    var affiliates = GetAffiliates();
                    dbContext.Affiliates.AddRange(affiliates);
                    await dbContext.SaveChangesAsync();
                }
            }
        }

        private IEnumerable<Affiliate> GetAffiliates()
        {
            List<Affiliate> affiliates = [
                new()
                {
                    Name = "Marco",
                    LastName = "Lopez Torrez",
                    CI = "7216841",
                    Address = "Barrio San Bernardo",
                    NumberPhone = "65806580",
                    ImageUrl = "https://i.sstatic.net/l60Hf.png",
                    State = true,
                    CreatedDate = DateTime.Today,
                    UpdatedDate = null,
                    Companies = [
                        new()
                        {
                            Name = "ATB",
                            Description = "ATB medio de comunicaión de televisión",
                            ImageUrl = "https://i.sstatic.net/l60Hf.png",
                            State = true,
                            CreatedDate = DateTime.Today,
                            UpdatedDate = null,
                        }
                    ],
                    Payments = [
                        new()
                        {
                            Description = "Pago de mensualidad",
                            Amount = 50.00,
                            PaymentDate = DateTime.Today,
                            CreatedDate = DateTime.Today,
                            UpdatedDate = null,
                        }
                    ],
                },
                new()
                {
                    Name = "Ana",
                    LastName = "Tolaba",
                    CI = "67845633",
                    Address = "Barrio Juan 23",
                    NumberPhone = "77650932",
                    ImageUrl = "https://i.sstatic.net/l60Hf.png",
                    State = true,
                    CreatedDate = DateTime.Today,
                    UpdatedDate = null,
                    Companies = [
                        new()
                        {
                            Name = "Unitel",
                            Description = "Unitel medio de comunicaión de televisión",
                            ImageUrl = "https://i.sstatic.net/l60Hf.png",
                            State = true,
                            CreatedDate = DateTime.Today,
                            UpdatedDate = null,
                        }
                    ],
                    Payments = [
                        new()
                        {
                            Description = "Pago de mensualidad",
                            Amount = 10.00,
                            PaymentDate = DateTime.Today,
                            CreatedDate = DateTime.Today,
                            UpdatedDate = null,
                        }
                    ],
                },
            ];

            return affiliates;
        }
    }
}
