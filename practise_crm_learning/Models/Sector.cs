namespace practise_crm_learning.Models
{
    public enum Sector
    {
        CarWash,
        RealEstate,
        Healthcare,
        Retail,
        Construction,
        Mining,
        Tourism,
        FinancialServices,
        Education,
        Agriculture,
        Transport,
        Technology,
        Manufacturing,
        FoodAndBeverage,
        Other
    }

    public static class SectorHelper
    {
        public static string GetDisplayName(Sector sector) => sector switch
        {
            Sector.CarWash => "Car Wash & Detailing",
            Sector.RealEstate => "Real Estate & Property",
            Sector.Healthcare => "Healthcare & Medical",
            Sector.Retail => "Retail & Commerce",
            Sector.Construction => "Construction & Civil",
            Sector.Mining => "Mining & Resources",
            Sector.Tourism => "Tourism & Hospitality",
            Sector.FinancialServices => "Financial Services",
            Sector.Education => "Education & Training",
            Sector.Agriculture => "Agriculture & Farming",
            Sector.Transport => "Transport & Logistics",
            Sector.Technology => "IT & Technology",
            Sector.Manufacturing => "Manufacturing & Industry",
            Sector.FoodAndBeverage => "Food & Beverage",
            _ => "Other"
        };

        public static string GetIcon(Sector sector) => sector switch
        {
            Sector.CarWash => "fa-car-wash",
            Sector.RealEstate => "fa-building",
            Sector.Healthcare => "fa-hospital",
            Sector.Retail => "fa-store",
            Sector.Construction => "fa-hard-hat",
            Sector.Mining => "fa-gem",
            Sector.Tourism => "fa-umbrella-beach",
            Sector.FinancialServices => "fa-chart-line",
            Sector.Education => "fa-graduation-cap",
            Sector.Agriculture => "fa-seedling",
            Sector.Transport => "fa-truck",
            Sector.Technology => "fa-laptop-code",
            Sector.Manufacturing => "fa-industry",
            Sector.FoodAndBeverage => "fa-utensils",
            _ => "fa-briefcase"
        };

        public static List<Sector> AllSectors() =>
            Enum.GetValues<Sector>().ToList();
    }
}
