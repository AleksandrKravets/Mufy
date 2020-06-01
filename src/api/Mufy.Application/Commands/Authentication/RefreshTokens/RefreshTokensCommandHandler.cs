using Mufy.Application.Infrastructure;
using System.Threading.Tasks;

namespace Mufy.Application.Commands.Authentication.RefreshTokens
{
    public class RefreshTokensCommandHandler : IAsyncCommandHandler<RefreshTokensCommand, TokensModel>
    {
        public Task<TokensModel> HandleAsync(RefreshTokensCommand command)
        {
            //var cp = _jwtTokenValidator.GetPrincipalFromToken(message.AccessToken, message.SigningKey);

            //// invalid token/signing key was passed and we can't extract user claims
            //if (cp != null)
            //{
            //    var id = cp.Claims.First(c => c.Type == "id");
            //    var user = await _userRepository.GetSingleBySpec(new UserSpecification(id.Value));

            //    if (user.HasValidRefreshToken(message.RefreshToken))
            //    {
            //        var jwtToken = await _jwtFactory.GenerateEncodedToken(user.IdentityId, user.UserName);
            //        var refreshToken = _tokenFactory.GenerateToken();
            //        user.RemoveRefreshToken(message.RefreshToken); // delete the token we've exchanged
            //        user.AddRefreshToken(refreshToken, user.Id, ""); // add the new one
            //        await _userRepository.Update(user);
            //        outputPort.Handle(new ExchangeRefreshTokenResponse(jwtToken, refreshToken, true));
            //        return true;
            //    }
            //}
            //outputPort.Handle(new ExchangeRefreshTokenResponse(false, "Invalid token."));
            //return false;
            return null;
        }
    }
}
