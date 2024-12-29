namespace Core.Helper.Models;

public record JwtResult(string AccessToken, RefreshTokenResult RefreshToken);
public record RefreshTokenResult(string RefreshToken, DateTime RefreshTokenExpiry, string UserName);