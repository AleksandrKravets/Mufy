using Mufy.Application.Infrastructure;

namespace Mufy.Application.Commands.Authentication.Login
{
    public class LoginCommand : ICommand<TokensModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
