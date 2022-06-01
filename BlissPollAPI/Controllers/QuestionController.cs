using BlissPollAPI.Interfaces;
using BlissPollAPI.Model;
using Microsoft.AspNetCore.Http;
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

		[HttpGet("listall/{page}")]
		public async Task<ActionResult<List<Poll>>> GetPolls(int page)
		{
			var allPolls = await _pollRepository.GetPolls();

			if (allPolls.Count() == 0)
				return NotFound();

			var pageResults = 10f;
			var pageCount = Math.Ceiling(allPolls.Count() / pageResults);

			var pollsResponse = allPolls.
				Skip((page - 1) * (int)pageResults)
				.Take((int)pageResults)
				.ToList();

			var response = new PollResponse
			{
				Polls = pollsResponse,
				CurrentPage = page,
				Pages = (int)pageCount
			};

			return Ok(response);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Poll>> Get(int id)
		{
			var poll = await _pollRepository.Get(id);
			poll.Choices = await _choicesRepository.GetAllByPoll(poll.Id);

			if (poll == null)
				return BadRequest("Poll not found.");

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
