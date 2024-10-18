namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string DocumentPath { get; set; }
        public DateTime SubmittedOn { get; set; } = DateTime.Now;
       
    }
}
