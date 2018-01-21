using System.Threading.Tasks;

namespace AJT.AuthServer.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
