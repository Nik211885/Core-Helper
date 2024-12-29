using System.Security.Claims;
using Core.Helper.Models;

namespace Core.Helper.Interface;

public interface IJwtTokenManager
{
    JwtResult GeneratorJwtToken(string userName, Claim[] claims);
    Claim [] DecodeJwtToken(string accessToken);
}