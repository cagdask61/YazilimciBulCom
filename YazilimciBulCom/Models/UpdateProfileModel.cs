namespace YazilimciBulCom.Models
{
    public class UpdateProfileModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int SalaryExpectation { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public short Age { get; set; }
    }
}
