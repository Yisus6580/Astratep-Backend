namespace Astratep.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int AffiliateID { get; set; }
        public Affiliate Affiliate { get; set; }
    }
}