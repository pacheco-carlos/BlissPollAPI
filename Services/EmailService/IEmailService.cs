using BlissPollAPI.Entities.Models;

namespace BlissPollAPI.Services.EmailService
{
	public interface IEmailService
	{
		void SendEmail(EmailDto request);
	}
}
