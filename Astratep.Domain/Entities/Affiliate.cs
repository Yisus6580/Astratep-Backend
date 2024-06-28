namespace Astratep.Domain.Entities
{
    public class Affiliate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CI { get; set; }
        public string? Address { get; set; }
        public string? NumberPhone { get; set; }
        public string? ImageUrl { get; set; }
        public bool State { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<Company> Companies { get; set; } = [];
        public List<Payment> Payments { get; set; } = [];
    }
}