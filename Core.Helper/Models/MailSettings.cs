namespace Core.Helper.Models;

public record MailSettings(
    string EmailId,
    string Name, 
    string UserName,
    string Password,
    string Host,
    int Port,
    bool UseSsl);