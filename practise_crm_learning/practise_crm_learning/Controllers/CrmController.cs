using Microsoft.AspNetCore.Mvc;
using practise_crm_learning.Models;

namespace practise_crm_learning.Controllers
{
    public class CrmController : Controller
    {
        public IActionResult Dashboard()
        {
            var data = DashboardViewModel.GetSampleData();
            return View(data);
        }

        public IActionResult Contacts()
        {
            var contacts = new List<Contact>
            {
                new() { Id=1, FirstName="Sipho", LastName="Nkosi", Email="sipho@sataxis.co.za", Phone="+27 11 234 5678", Mobile="+27 82 111 2222", Company="SA Taxi Association", Title="Fleet Manager", Type=ContactType.Customer, City="Johannesburg", Province="Gauteng", CreatedAt=DateTime.Now.AddDays(-30) },
                new() { Id=2, FirstName="Ayanda", LastName="Dlamini", Email="ayanda@execprestige.co.za", Phone="+27 21 987 6543", Mobile="+27 83 222 3333", Company="Executive Prestige Cars", Title="Director", Type=ContactType.Customer, City="Cape Town", Province="Western Cape", CreatedAt=DateTime.Now.AddDays(-25) },
                new() { Id=3, FirstName="Zanele", LastName="Mokoena", Email="zanele@capetown.gov.za", Phone="+27 21 555 1234", Mobile="+27 84 333 4444", Company="City of Cape Town Fleet", Title="Procurement Officer", Type=ContactType.Prospect, City="Cape Town", Province="Western Cape", CreatedAt=DateTime.Now.AddDays(-20) },
                new() { Id=4, FirstName="Pieter", LastName="van der Merwe", Email="pieter@capecoastal.co.za", Phone="+27 82 111 2233", Mobile="+27 72 444 5555", Company="Cape Coastal Properties", Title="Principal Agent", Type=ContactType.Partner, City="Stellenbosch", Province="Western Cape", CreatedAt=DateTime.Now.AddDays(-18) },
                new() { Id=5, FirstName="Fatima", LastName="Patel", Email="fatima@dpworld.co.za", Phone="+27 31 888 9999", Mobile="+27 73 555 6666", Company="Durban Port Authority", Title="Operations Manager", Type=ContactType.Prospect, City="Durban", Province="KwaZulu-Natal", CreatedAt=DateTime.Now.AddDays(-15) },
                new() { Id=6, FirstName="Thulani", LastName="Khumalo", Email="thulani@miningco.co.za", Phone="+27 18 777 8888", Mobile="+27 71 666 7777", Company="Platinum Ridge Mining", Title="CFO", Type=ContactType.Prospect, City="Rustenburg", Province="North West", CreatedAt=DateTime.Now.AddDays(-12) },
                new() { Id=7, FirstName="Nadine", LastName="Fouché", Email="nadine@agri.co.za", Phone="+27 53 444 5555", Mobile="+27 82 777 8888", Company="Karoo Fresh Farms", Title="Managing Director", Type=ContactType.Customer, City="Graaff-Reinet", Province="Eastern Cape", CreatedAt=DateTime.Now.AddDays(-10) },
                new() { Id=8, FirstName="Busi", LastName="Zulu", Email="busi@toursa.co.za", Phone="+27 35 111 2222", Mobile="+27 84 888 9999", Company="Zulu Cultural Tours", Title="CEO", Type=ContactType.Customer, City="Richards Bay", Province="KwaZulu-Natal", CreatedAt=DateTime.Now.AddDays(-8) },
                new() { Id=9, FirstName="André", LastName="Pretorius", Email="andre@constructpro.co.za", Phone="+27 12 777 6666", Mobile="+27 73 999 0000", Company="ConstructPro SA", Title="Project Director", Type=ContactType.Supplier, City="Pretoria", Province="Gauteng", CreatedAt=DateTime.Now.AddDays(-5) },
                new() { Id=10, FirstName="Lindiwe", LastName="Ntuli", Email="lindiwe@teachsa.co.za", Phone="+27 11 333 4444", Mobile="+27 71 000 1111", Company="TeachSA Academy", Title="Principal", Type=ContactType.Customer, City="Soweto", Province="Gauteng", CreatedAt=DateTime.Now.AddDays(-3) },
            };
            return View(contacts);
        }

        public IActionResult Leads()
        {
            var leads = new List<Lead>
            {
                new() { Id=1, Title="Commercial Fleet Wash - Taxi Association", ContactName="Sipho Nkosi", Company="SA Taxi Association", Sector=Sector.CarWash, Status=LeadStatus.Qualified, EstimatedValue=850000, Priority=Priority.Critical, Source="Website", AssignedTo="Thabo M.", CreatedAt=DateTime.Now.AddDays(-14) },
                new() { Id=2, Title="Luxury Car Detailing Package", ContactName="Ayanda Dlamini", Company="Executive Prestige Cars", Sector=Sector.CarWash, Status=LeadStatus.Proposal, EstimatedValue=180000, Priority=Priority.High, Source="Referral", AssignedTo="Lerato K.", CreatedAt=DateTime.Now.AddDays(-10) },
                new() { Id=3, Title="Government Fleet Monthly Subscription", ContactName="Zanele Mokoena", Company="City of Cape Town Fleet", Sector=Sector.CarWash, Status=LeadStatus.New, EstimatedValue=1200000, Priority=Priority.Critical, Source="Cold Call", AssignedTo="Bongani S.", CreatedAt=DateTime.Now.AddDays(-7) },
                new() { Id=4, Title="Residential Estate Car Wash Partnership", ContactName="Pieter van der Merwe", Company="Cape Coastal Properties", Sector=Sector.RealEstate, Status=LeadStatus.Contacted, EstimatedValue=340000, Priority=Priority.High, Source="LinkedIn", AssignedTo="Nomsa P.", CreatedAt=DateTime.Now.AddDays(-6) },
                new() { Id=5, Title="Industrial Equipment Cleaning", ContactName="Fatima Patel", Company="Durban Port Authority", Sector=Sector.CarWash, Status=LeadStatus.Negotiation, EstimatedValue=2500000, Priority=Priority.Critical, Source="Tender Bulletin", AssignedTo="Thabo M.", CreatedAt=DateTime.Now.AddDays(-5) },
                new() { Id=6, Title="Mining Vehicle Fleet Contract", ContactName="Thulani Khumalo", Company="Platinum Ridge Mining", Sector=Sector.Mining, Status=LeadStatus.Qualified, EstimatedValue=980000, Priority=Priority.High, Source="Trade Show", AssignedTo="Lerato K.", CreatedAt=DateTime.Now.AddDays(-4) },
                new() { Id=7, Title="Farm Equipment Detailing", ContactName="Nadine Fouché", Company="Karoo Fresh Farms", Sector=Sector.Agriculture, Status=LeadStatus.New, EstimatedValue=45000, Priority=Priority.Low, Source="Website", AssignedTo="Bongani S.", CreatedAt=DateTime.Now.AddDays(-3) },
                new() { Id=8, Title="Tourism Bus Fleet Wash", ContactName="Busi Zulu", Company="Zulu Cultural Tours", Sector=Sector.Tourism, Status=LeadStatus.Contacted, EstimatedValue=280000, Priority=Priority.Medium, Source="Referral", AssignedTo="Nomsa P.", CreatedAt=DateTime.Now.AddDays(-2) },
                new() { Id=9, Title="Construction Equipment Rinse", ContactName="André Pretorius", Company="ConstructPro SA", Sector=Sector.Construction, Status=LeadStatus.Won, EstimatedValue=560000, Priority=Priority.High, Source="Cold Call", AssignedTo="Thabo M.", CreatedAt=DateTime.Now.AddDays(-15) },
                new() { Id=10, Title="School Bus Fleet Maintenance Wash", ContactName="Lindiwe Ntuli", Company="TeachSA Academy", Sector=Sector.Education, Status=LeadStatus.Lost, EstimatedValue=89000, Priority=Priority.Low, Source="Website", AssignedTo="Lerato K.", CreatedAt=DateTime.Now.AddDays(-20) },
            };
            return View(leads);
        }

        public IActionResult Deals()
        {
            var deals = new List<Deal>
            {
                new() { Id=1, Title="Annual Fleet Contract - Gauteng Taxis", ContactName="Sipho Nkosi", Company="SA Taxi Association", Stage=DealStage.Negotiation, Value=850000, Probability=75, ExpectedCloseDate=DateTime.Now.AddDays(14), AssignedTo="Thabo M.", Sector=Sector.CarWash },
                new() { Id=2, Title="VIP Detailing Monthly Retainer", ContactName="Precious Sithole", Company="BankCity Financial", Stage=DealStage.Proposal, Value=360000, Probability=60, ExpectedCloseDate=DateTime.Now.AddDays(21), AssignedTo="Lerato K.", Sector=Sector.FinancialServices },
                new() { Id=3, Title="Government Fleet Wash - Western Cape", ContactName="Gerhard Botha", Company="Western Cape Government", Stage=DealStage.Qualification, Value=1880000, Probability=40, ExpectedCloseDate=DateTime.Now.AddDays(45), AssignedTo="Bongani S.", Sector=Sector.CarWash },
                new() { Id=4, Title="Luxury Estate Resident Services", ContactName="Kgomotso Radebe", Company="Joburg Homes Estate", Stage=DealStage.ClosedWon, Value=220000, Probability=100, ExpectedCloseDate=DateTime.Now.AddDays(-5), AssignedTo="Nomsa P.", Sector=Sector.RealEstate },
                new() { Id=5, Title="Industrial Port Cleaning Contract", ContactName="Fatima Patel", Company="Durban Port Authority", Stage=DealStage.Negotiation, Value=2500000, Probability=70, ExpectedCloseDate=DateTime.Now.AddDays(30), AssignedTo="Thabo M.", Sector=Sector.CarWash },
                new() { Id=6, Title="Mining Fleet Annual Agreement", ContactName="Thulani Khumalo", Company="Platinum Ridge Mining", Stage=DealStage.Proposal, Value=980000, Probability=55, ExpectedCloseDate=DateTime.Now.AddDays(35), AssignedTo="Lerato K.", Sector=Sector.Mining },
                new() { Id=7, Title="Tourism Bus Quarterly Contract", ContactName="Busi Zulu", Company="Zulu Cultural Tours", Stage=DealStage.Prospecting, Value=280000, Probability=25, ExpectedCloseDate=DateTime.Now.AddDays(60), AssignedTo="Nomsa P.", Sector=Sector.Tourism },
                new() { Id=8, Title="Construction Fleet Deal", ContactName="André Pretorius", Company="ConstructPro SA", Stage=DealStage.ClosedLost, Value=560000, Probability=0, ExpectedCloseDate=DateTime.Now.AddDays(-10), AssignedTo="Thabo M.", Sector=Sector.Construction },
            };
            return View(deals);
        }

        public IActionResult Activities()
        {
            var activities = new List<Activity>
            {
                new() { Id=1, Title="Follow-up call with Sipho", Type="Call", Description="Discuss final pricing for taxi fleet contract", DueDate=DateTime.Now.AddHours(2), Priority=Priority.Critical, RelatedTo="SA Taxi Association", AssignedTo="Thabo M.", IsCompleted=false },
                new() { Id=2, Title="Send proposal to Cape Town Fleet", Type="Email", Description="Professional proposal document with pricing tiers", DueDate=DateTime.Now.AddHours(4), Priority=Priority.Critical, RelatedTo="City of Cape Town Fleet", AssignedTo="Bongani S.", IsCompleted=false },
                new() { Id=3, Title="Site visit - Durban Port", Type="Meeting", Description="On-site assessment for industrial cleaning scope", DueDate=DateTime.Now.AddDays(1), Priority=Priority.High, RelatedTo="Durban Port Authority", AssignedTo="Thabo M.", IsCompleted=false },
                new() { Id=4, Title="Contract review meeting", Type="Meeting", Description="Legal review of VIP retainer agreement", DueDate=DateTime.Now.AddDays(2), Priority=Priority.Medium, RelatedTo="BankCity Financial", AssignedTo="Lerato K.", IsCompleted=false },
                new() { Id=5, Title="Send welcome pack to new client", Type="Email", Description="Onboarding materials for Joburg Homes Estate", DueDate=DateTime.Now.AddDays(-1), Priority=Priority.Low, RelatedTo="Joburg Homes Estate", AssignedTo="Nomsa P.", IsCompleted=true },
                new() { Id=6, Title="Demo call - Mining client", Type="Call", Description="System demo and pricing discussion", DueDate=DateTime.Now.AddDays(3), Priority=Priority.High, RelatedTo="Platinum Ridge Mining", AssignedTo="Lerato K.", IsCompleted=false },
            };
            return View(activities);
        }
    }
}
