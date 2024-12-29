namespace Core.Helper.Interface;

public interface IEmailSender
{
    /// <summary>
    ///     Send email 
    /// </summary>
    /// <param name="to">email address will send</param>
    /// <param name="body"></param>
    /// <param name="subject"></param>
    /// <param name="nameTo">name use will send</param>
    /// <param name="isLink">email is contains link</param>/ <returns>
                                                               ///     throw exception if send failure
                                                               /// </returns>
    //
    Task SendEmailAsync(string to, string body, string subject, string? nameTo = null, bool isLink = false);
}