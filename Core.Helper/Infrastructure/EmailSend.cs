using Core.Helper.Interface;

namespace Core.Helper.Infrastructure;

public class EmailSend : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        throw new NotImplementedException();
    }
}