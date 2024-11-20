using System;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int ClaimId { get; set; } // Primary key, rename Id in views to ClaimId
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalPayment { get; set; }
        public DateTime SubmissionDate { get; set; } // Rename SubmittedOn in views to SubmissionDate
        public string Status { get; set; }
        public string DocumentPath { get; set; }
        public string Notes { get; set; } // Add Notes to align with views
        public string LecturerName { get; set; } // Foreign key

        // Navigation property for related Lecturer entity
        public Lecturer Lecturer { get; set; }
    }
}
