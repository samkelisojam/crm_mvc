namespace practise_crm_learning.Models
{
    public enum SubscriptionTier { Free, Starter, Professional, Enterprise }

    public class SubscriptionPlan
    {
        public SubscriptionTier Tier { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal MonthlyPrice { get; set; }
        public decimal AnnualPrice { get; set; }
        public string Currency { get; set; } = "ZAR";
        public List<string> Features { get; set; } = new();
        public List<string> Limitations { get; set; } = new();
        public int MaxUsers { get; set; }
        public int MaxContacts { get; set; }
        public bool IsPopular { get; set; }
        public string BadgeColor { get; set; } = string.Empty;

        public static List<SubscriptionPlan> GetAllPlans() => new()
        {
            new SubscriptionPlan
            {
                Tier = SubscriptionTier.Free,
                Name = "Free",
                Description = "Perfect for solo entrepreneurs getting started",
                MonthlyPrice = 0,
                AnnualPrice = 0,
                MaxUsers = 1,
                MaxContacts = 100,
                BadgeColor = "secondary",
                Features = new()
                {
                    "1 User", "100 Contacts", "Basic Lead Tracking",
                    "Contact Management", "Email Integration",
                    "Mobile App Access", "Community Support"
                },
                Limitations = new() { "No pipeline management", "No reports", "No API access" }
            },
            new SubscriptionPlan
            {
                Tier = SubscriptionTier.Starter,
                Name = "Starter",
                Description = "Ideal for small businesses in South Africa",
                MonthlyPrice = 299,
                AnnualPrice = 2990,
                MaxUsers = 5,
                MaxContacts = 1000,
                BadgeColor = "info",
                Features = new()
                {
                    "5 Users", "1,000 Contacts", "Full Lead Management",
                    "Deal Pipeline", "Basic Reports & Analytics",
                    "Email & SMS Integration", "Document Storage (5GB)",
                    "Priority Email Support", "SA Province Mapping",
                    "Sector Customisation"
                },
                Limitations = new() { "No advanced automation", "No custom fields" }
            },
            new SubscriptionPlan
            {
                Tier = SubscriptionTier.Professional,
                Name = "Professional",
                Description = "The most popular choice for growing SA businesses",
                MonthlyPrice = 799,
                AnnualPrice = 7990,
                MaxUsers = 25,
                MaxContacts = 10000,
                IsPopular = true,
                BadgeColor = "warning",
                Features = new()
                {
                    "25 Users", "10,000 Contacts", "Advanced Pipeline Management",
                    "Custom Deal Stages", "Advanced Analytics & Reports",
                    "Workflow Automation", "API Access", "Document Storage (50GB)",
                    "Multi-Branch Support", "Role-Based Access Control",
                    "Custom Fields & Modules", "Email Campaigns",
                    "WhatsApp Integration (SA)", "Priority Phone Support",
                    "SA Tax & VAT Tracking", "Multi-Currency (ZAR/USD/EUR)"
                }
            },
            new SubscriptionPlan
            {
                Tier = SubscriptionTier.Enterprise,
                Name = "Enterprise",
                Description = "Unlimited power for large South African corporations",
                MonthlyPrice = 2499,
                AnnualPrice = 24990,
                MaxUsers = -1, // Unlimited
                MaxContacts = -1, // Unlimited
                BadgeColor = "success",
                Features = new()
                {
                    "Unlimited Users", "Unlimited Contacts", "All Professional Features",
                    "Dedicated Account Manager", "Custom Integrations",
                    "White-Label Option", "Unlimited Storage", "SLA Guarantee (99.9% uptime)",
                    "Advanced Security & Compliance", "Custom AI Insights",
                    "Multi-Company Management", "On-site Training (SA only)",
                    "Custom Development Support", "POPIA Compliance Tools",
                    "B-BBEE Reporting Module", "CIPC Integration (SA)",
                    "24/7 Dedicated Support"
                }
            }
        };
    }
}
