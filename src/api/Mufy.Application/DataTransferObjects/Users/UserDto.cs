namespace Mufy.Application.DataTransferObjects.Users
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
    }
}
