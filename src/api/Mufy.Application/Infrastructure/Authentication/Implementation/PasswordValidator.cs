using Mufy.Application.Infrastructure.Authentication.Contracts;

namespace Mufy.Application.Infrastructure.Authentication.Implementation
{
    public class PasswordValidator : IPasswordValidator
    {
        // get password settings here
        public PasswordValidator()
        {
        }

        public bool ValidatePassword(string password)
        {
            return true;
        }
    }
}
