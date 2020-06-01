namespace Mufy.Application.Infrastructure.Authentication.Contracts
{
    public interface IPasswordHasher
    {
        string Hash(string password, int iterations);
        string Hash(string password);
        bool IsHashSupported(string hashString);
        bool Verify(string password, string hashedPassword);
    }
}
