namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int UserID { get; set; }
        public DateTime DateSubmitted { get; set; }
        public int StatusID { get; set; }
        public ClaimStatus Status { get; set; }
    }
}
