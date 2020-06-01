namespace Mufy.Application.Infrastructure.Authentication.Contracts
{
    public interface IPasswordValidator
    {
        bool ValidatePassword(string password);
    }
}
