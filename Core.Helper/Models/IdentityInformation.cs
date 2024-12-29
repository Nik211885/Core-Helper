namespace Core.Helper.Models;

public record IdentityInformation(
    string Secret, 
    string Issuer, 
    string Audience,
    double AccessTokenExpiration, 
    double RefreshTokenExpiration,
    int BytesRefreshToken);