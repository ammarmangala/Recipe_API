namespace Recipe_API.Dto.Authentication
{
    public class RegisterUserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
