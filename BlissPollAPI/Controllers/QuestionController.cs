using BlissPollAPI.Entities.Models;
using BlissPollAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlissPollAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class QuestionController : ControllerBase
	{
		private IPollRepository _pollRepository;
		private IChoicesRepository _choicesRepository;

		public QuestionController(IPollRepository pollRepository, IChoicesRepository choicesRepository)
		{
			_pollRepository = pollRepository;
			_choicesRepository = choicesRepository;
		}

		[HttpGet]
		public async Task<ActionResult<List<Poll>>> GetPolls([FromQuery] QuestionParameters questionParameters)
		{
			var polls = await _pollRepository.GetPolls(questionParameters);

			return Ok(polls);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Poll>> GetById(int id)
		{
			var poll = await _pollRepository.Get(id);
			
			if (poll == null)
				return BadRequest("Poll not found.");

			poll.Choices = await _choicesRepository.GetAllByPoll(poll.Id);

			return Ok(poll);
		}

		[HttpPost]
		public async Task<ActionResult<List<Poll>>> AddQuestion(Poll poll)
		{
			await _pollRepository.Create(poll);

			return Ok(await _pollRepository.GetAll());
		}

		[HttpPut]
		public async Task<ActionResult<List<Poll>>> UpdateQuestion(Poll request)
		{
			var dbPoll = await _pollRepository.Get(request.Id);

			if (dbPoll == null)
				return BadRequest("Poll not found.");

			dbPoll.Image_URL = request.Image_URL;
			dbPoll.Thumb_URL = request.Thumb_URL;
			dbPoll.Question = request.Question;
			dbPoll.Published_At = request.Published_At;
			dbPoll.Choices = request.Choices;

			await _pollRepository.Update(dbPoll);

			return Ok(await _pollRepository.GetAll());

		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<List<Poll>>> Delete(int id)
		{
			var dbPoll = await _pollRepository.Get(id);

			if (dbPoll == null)
				return BadRequest("Poll not found.");

			await _pollRepository.Delete(dbPoll);

			return Ok(await _pollRepository.GetAll());
		}
	}
}
