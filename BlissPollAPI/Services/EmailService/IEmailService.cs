using BlissPollAPI.Model;

namespace BlissPollAPI.Services.EmailService
{
	public interface IEmailService
	{
		void SendEmail(EmailDto request);
	}
}
