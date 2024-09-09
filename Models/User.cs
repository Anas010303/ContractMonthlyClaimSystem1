namespace ContractMonthlyClaimSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
    }
}
