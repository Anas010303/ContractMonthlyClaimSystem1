namespace ContractMonthlyClaimSystem.Models
{
    public class Lecturer
    {
        public int LecturerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public ICollection<Claim> Claims { get; set; }
    }
}


