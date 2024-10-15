namespace HRISWebAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string MiddleInitial { get; set; } = string.Empty;
        public string SocialSecurityNumber { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string SecondaryPhoneNumber { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string MaritalStatus { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public string Department { get; set; } = string.Empty;
        public decimal? PayRate { get; set; }
        public string Store { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string EmployeeStatus { get; set; } = string.Empty;
        public string PayType { get; set; } = string.Empty;
        public string PayFrequency { get; set; } = string.Empty;
        public string WOTCResult { get; set; } = string.Empty;
    }
}
