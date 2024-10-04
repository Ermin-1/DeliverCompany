using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

public class DummyEmailSender : IEmailSender
{
    private readonly ILogger<DummyEmailSender> _logger;

    public DummyEmailSender(ILogger<DummyEmailSender> logger)
    {
        _logger = logger;
    }

    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        _logger.LogInformation($"Simulated email to: {email}, subject: {subject}, message: {htmlMessage}");
        return Task.CompletedTask;
    }
}
