﻿using BlissPollAPI.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlissPollAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmailController : ControllerBase
	{
		private readonly IEmailService _emailService;
		public EmailController(IEmailService emailService)
		{
			_emailService = emailService;
		}

		[HttpPost]
		public IActionResult SendEmail(EmailDto request)
		{
			_emailService.SendEmail(request);
			return Ok();
		}
	}
}
