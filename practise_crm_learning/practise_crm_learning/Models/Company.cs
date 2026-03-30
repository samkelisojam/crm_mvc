namespace practise_crm_learning.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = "South Africa";
        public Sector Sector { get; set; }
        public string Description { get; set; } = string.Empty;
        public string LogoUrl { get; set; } = string.Empty;
        public string BannerUrl { get; set; } = string.Empty;
        public SubscriptionTier SubscriptionTier { get; set; } = SubscriptionTier.Free;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        public int EmployeeCount { get; set; }
        public decimal AnnualRevenue { get; set; }
        public List<string> ServicesOffered { get; set; } = new();
    }
}
