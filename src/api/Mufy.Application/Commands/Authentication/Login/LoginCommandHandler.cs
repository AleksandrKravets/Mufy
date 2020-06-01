using Mufy.Application.Contracts.Repositories;
using Mufy.Application.Factories.Contracts;
using Mufy.Application.Infrastructure;
using Mufy.Application.Infrastructure.Authentication.Contracts;
using System;
using System.Threading.Tasks;

namespace Mufy.Application.Commands.Authentication.Login
{
    public class LoginCommandHandler : IAsyncCommandHandler<LoginCommand, TokensModel>
    {
        //private readonly IUsersRepository _usersRepository;
        //private readonly IPasswordHasher _passwordHasher;
        //private readonly ITokenFactory _tokenFactory;
        //private readonly IJwtFactory _jwtTokenFactory;
        //private readonly ITokensRepository _tokensRepository;

        //public LoginCommandHandler(IUsersRepository usersRepository, IPasswordHasher passwordHasher,
        //    ITokenFactory tokenFactory, IJwtFactory jwtTokenFactory, ITokensRepository tokensRepository)
        //{
        //    _usersRepository = usersRepository ?? throw new ArgumentNullException(nameof(usersRepository));
        //    _passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
        //    _tokenFactory = tokenFactory ?? throw new ArgumentNullException(nameof(tokenFactory));
        //    _jwtTokenFactory = jwtTokenFactory ?? throw new ArgumentNullException(nameof(jwtTokenFactory));
        //    _tokensRepository = tokensRepository ?? throw new ArgumentNullException(nameof(tokensRepository));
        //}

        public async Task<TokensModel> HandleAsync(LoginCommand command)
        {
            //var user = await _usersRepository.GetByEmailAsync(command.Email);

            //if (user != null)
            //{
            //    bool passwordValid = _passwordHasher.Verify(command.Password, user.HashedPassword);

            //    if (passwordValid)
            //    {
            //        var refreshToken = _tokenFactory.GenerateToken();
            //        await _tokensRepository.CreateAsync(refreshToken, null, DateTime.UtcNow, DateTime.UtcNow, user.Id);
            //        var accessToken = _jwtTokenFactory.GenerateEncodedToken();

            //        var result = new TokensModel { };

            //        return result;
            //    }
            //}
            return null;
        }
    }
}
