using Mufy.Application.Infrastructure;

namespace Mufy.Application.Commands.Authentication.RefreshTokens
{
    public class RefreshTokensCommand : ICommand<TokensModel>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
