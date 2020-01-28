using api.Models;

namespace api.Interfaces
{
    public interface IAuthenticateService
    {
        bool IsAutenticated(TokenRequest request, out string token);
    }
}