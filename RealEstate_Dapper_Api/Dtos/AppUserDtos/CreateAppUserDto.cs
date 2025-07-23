namespace RealEstate_Dapper_Api.Dtos.AppUserDtos
{
    public class CreateAppUserDto
    {
      
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int UserRole { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImageUrl { get; set; }
    }
}
