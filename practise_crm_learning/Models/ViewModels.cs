namespace practise_crm_learning.Models
{
    public class DashboardViewModel
    {
        public int TotalContacts { get; set; }
        public int TotalLeads { get; set; }
        public int TotalDeals { get; set; }
        public decimal TotalPipelineValue { get; set; }
        public int OpenActivities { get; set; }
        public int WonDealsThisMonth { get; set; }
        public decimal RevenueThisMonth { get; set; }
        public decimal RevenueGrowth { get; set; }
        public int NewLeadsThisWeek { get; set; }
        public List<Lead> RecentLeads { get; set; } = new();
        public List<Deal> ActiveDeals { get; set; } = new();
        public List<Activity> UpcomingActivities { get; set; } = new();
        public List<Contact> RecentContacts { get; set; } = new();
        public Dictionary<string, int> LeadsByStatus { get; set; } = new();
        public Dictionary<string, decimal> DealsByStage { get; set; } = new();
        public Dictionary<string, int> ContactsByProvince { get; set; } = new();
        public string CompanyName { get; set; } = string.Empty;
        public Sector CompanySector { get; set; }

        public static DashboardViewModel GetSampleData(string companyName = "Ubuntu Motors Car Wash", Sector sector = Sector.CarWash)
        {
            return new DashboardViewModel
            {
                CompanyName = companyName,
                CompanySector = sector,
                TotalContacts = 1247,
                TotalLeads = 389,
                TotalDeals = 127,
                TotalPipelineValue = 4_850_000,
                OpenActivities = 56,
                WonDealsThisMonth = 23,
                RevenueThisMonth = 1_230_000,
                RevenueGrowth = 18.5m,
                NewLeadsThisWeek = 47,
                RecentLeads = new()
                {
                    new Lead { Id=1, Title="Commercial Fleet Wash Contract", ContactName="Sipho Nkosi", Company="SA Taxi Association", Sector=Sector.CarWash, Status=LeadStatus.Qualified, EstimatedValue=85000, Priority=Priority.High, Source="Website", AssignedTo="Thabo M." },
                    new Lead { Id=2, Title="Luxury Car Detailing Package", ContactName="Ayanda Dlamini", Company="Executive Prestige Cars", Sector=Sector.CarWash, Status=LeadStatus.Proposal, EstimatedValue=45000, Priority=Priority.Medium, Source="Referral", AssignedTo="Lerato K." },
                    new Lead { Id=3, Title="Monthly Subscription - 10 Vehicles", ContactName="Zanele Mokoena", Company="City of Cape Town Fleet", Sector=Sector.CarWash, Status=LeadStatus.New, EstimatedValue=120000, Priority=Priority.Critical, Source="Cold Call", AssignedTo="Bongani S." },
                    new Lead { Id=4, Title="Property Listing Campaign", ContactName="Pieter van der Merwe", Company="Cape Coastal Properties", Sector=Sector.RealEstate, Status=LeadStatus.Contacted, EstimatedValue=250000, Priority=Priority.High, Source="LinkedIn", AssignedTo="Nomsa P." },
                    new Lead { Id=5, Title="Industrial Cleaning Contract", ContactName="Fatima Patel", Company="Durban Port Authority", Sector=Sector.CarWash, Status=LeadStatus.Negotiation, EstimatedValue=380000, Priority=Priority.Critical, Source="Tender Bulletin", AssignedTo="Thabo M." },
                },
                ActiveDeals = new()
                {
                    new Deal { Id=1, Title="Annual Fleet Contract - Gauteng", ContactName="Sipho Nkosi", Company="SA Taxi Association", Stage=DealStage.Negotiation, Value=850000, Probability=75, ExpectedCloseDate=DateTime.Now.AddDays(14), AssignedTo="Thabo M." },
                    new Deal { Id=2, Title="VIP Detailing Monthly Retainer", ContactName="Precious Sithole", Company="BankCity Financial", Stage=DealStage.Proposal, Value=180000, Probability=60, ExpectedCloseDate=DateTime.Now.AddDays(21), AssignedTo="Lerato K." },
                    new Deal { Id=3, Title="Government Fleet Wash - Western Cape", ContactName="Gerhard Botha", Company="Western Cape Government", Stage=DealStage.Qualification, Value=940000, Probability=40, ExpectedCloseDate=DateTime.Now.AddDays(45), AssignedTo="Bongani S." },
                    new Deal { Id=4, Title="Real Estate Photo Package", ContactName="Kgomotso Radebe", Company="Joburg Homes", Stage=DealStage.ClosedWon, Value=55000, Probability=100, ExpectedCloseDate=DateTime.Now.AddDays(-5), AssignedTo="Nomsa P." },
                },
                UpcomingActivities = new()
                {
                    new Activity { Id=1, Title="Follow-up call with Sipho Nkosi", Type="Call", DueDate=DateTime.Now.AddHours(2), Priority=Priority.High, RelatedTo="SA Taxi Association", AssignedTo="Thabo M." },
                    new Activity { Id=2, Title="Send proposal to Cape Town Fleet", Type="Email", DueDate=DateTime.Now.AddHours(4), Priority=Priority.Critical, RelatedTo="City of Cape Town Fleet", AssignedTo="Bongani S." },
                    new Activity { Id=3, Title="Site visit - Durban Port", Type="Meeting", DueDate=DateTime.Now.AddDays(1), Priority=Priority.High, RelatedTo="Durban Port Authority", AssignedTo="Thabo M." },
                    new Activity { Id=4, Title="Contract review meeting", Type="Meeting", DueDate=DateTime.Now.AddDays(2), Priority=Priority.Medium, RelatedTo="BankCity Financial", AssignedTo="Lerato K." },
                },
                RecentContacts = new()
                {
                    new Contact { Id=1, FirstName="Sipho", LastName="Nkosi", Email="sipho@sataxis.co.za", Phone="+27 11 234 5678", Company="SA Taxi Association", Title="Fleet Manager", Type=ContactType.Customer, City="Johannesburg", Province="Gauteng" },
                    new Contact { Id=2, FirstName="Ayanda", LastName="Dlamini", Email="ayanda@execprestige.co.za", Phone="+27 21 987 6543", Company="Executive Prestige Cars", Title="Director", Type=ContactType.Customer, City="Cape Town", Province="Western Cape" },
                    new Contact { Id=3, FirstName="Zanele", LastName="Mokoena", Email="zanele@capetown.gov.za", Phone="+27 21 555 1234", Company="City of Cape Town", Title="Procurement Officer", Type=ContactType.Prospect, City="Cape Town", Province="Western Cape" },
                    new Contact { Id=4, FirstName="Pieter", LastName="van der Merwe", Email="pieter@capecoastal.co.za", Phone="+27 82 111 2233", Company="Cape Coastal Properties", Title="Principal Agent", Type=ContactType.Partner, City="Stellenbosch", Province="Western Cape" },
                },
                LeadsByStatus = new()
                {
                    {"New", 89}, {"Contacted", 74}, {"Qualified", 112},
                    {"Proposal", 67}, {"Negotiation", 31}, {"Won", 23}, {"Lost", 8}
                },
                DealsByStage = new()
                {
                    {"Prospecting", 450000}, {"Qualification", 1200000},
                    {"Proposal", 1850000}, {"Negotiation", 980000}, {"Closed Won", 1230000}
                },
                ContactsByProvince = new()
                {
                    {"Gauteng", 387}, {"Western Cape", 298}, {"KwaZulu-Natal", 219},
                    {"Eastern Cape", 112}, {"Limpopo", 89}, {"Mpumalanga", 67},
                    {"North West", 34}, {"Free State", 28}, {"Northern Cape", 13}
                }
            };
        }
    }

    public class ContactPageModel
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public bool MessageSent { get; set; }
    }

    public class CompanyRegisterViewModel
    {
        public string CompanyName { get; set; } = string.Empty;
        public string RegistrationNumber { get; set; } = string.Empty;
        public string ContactPerson { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public Sector Sector { get; set; }
        public SubscriptionTier SubscriptionTier { get; set; } = SubscriptionTier.Free;
        public bool AgreeToTerms { get; set; }
        public bool AgreeToPrivacy { get; set; }

        public static List<string> SAProvinces => new()
        {
            "Eastern Cape", "Free State", "Gauteng", "KwaZulu-Natal",
            "Limpopo", "Mpumalanga", "North West", "Northern Cape", "Western Cape"
        };
    }
}
