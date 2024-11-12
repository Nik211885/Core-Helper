namespace Core.Helper.Interface;

public interface IEmailSender
{
    Task SendEmailAsync(string email, string subject, string message);
}