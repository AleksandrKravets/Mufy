namespace Mufy.Application.Factories.Contracts
{
    public interface ITokenFactory
    {
        string GenerateToken(int size = 32);
    }
}
