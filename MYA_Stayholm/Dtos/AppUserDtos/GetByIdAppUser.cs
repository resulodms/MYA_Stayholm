namespace MYA_Stayholm.Dtos.AppUserDtos
{
    public class GetByIdAppUser
    {
        public string AppUserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
