namespace practise_crm_learning.Models
{
    public enum LeadStatus { New, Contacted, Qualified, Proposal, Negotiation, Won, Lost }
    public enum ContactType { Customer, Prospect, Partner, Supplier, Other }
    public enum DealStage { Prospecting, Qualification, Proposal, Negotiation, ClosedWon, ClosedLost }
    public enum Priority { Low, Medium, High, Critical }

    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public ContactType Type { get; set; } = ContactType.Prospect;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastContactedAt { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
    }

    public class Lead
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public Sector Sector { get; set; }
        public LeadStatus Status { get; set; } = LeadStatus.New;
        public Priority Priority { get; set; } = Priority.Medium;
        public decimal EstimatedValue { get; set; }
        public string Source { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string AssignedTo { get; set; } = string.Empty;
    }

    public class Deal
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public DealStage Stage { get; set; } = DealStage.Prospecting;
        public decimal Value { get; set; }
        public decimal Probability { get; set; }
        public DateTime ExpectedCloseDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string AssignedTo { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public Sector Sector { get; set; }
    }

    public class Activity
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // Call, Email, Meeting, Task
        public string Description { get; set; } = string.Empty;
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string RelatedTo { get; set; } = string.Empty;
        public string AssignedTo { get; set; } = string.Empty;
        public Priority Priority { get; set; } = Priority.Medium;
    }
}
