using Mufy.Application.Commands.Authentication.Login;
using Mufy.Application.Commands.Authentication.RefreshTokens;
using Mufy.Common.Helpers;

namespace Mufy.Application.Commands.Authentication
{
    public class AuthModule
    {
        public LoginCommandHandler Login { get; }
        public RefreshTokensCommandHandler RefreshTokens { get; }

        public AuthModule(LoginCommandHandler loginHandler, RefreshTokensCommandHandler refreshTokensHandler)
        {
            ParametersHelper.ThrowIfAnyNull(loginHandler, refreshTokensHandler);
            Login = loginHandler;
            RefreshTokens = refreshTokensHandler;
        }
    }
}
