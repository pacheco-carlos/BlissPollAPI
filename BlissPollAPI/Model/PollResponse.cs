namespace BlissPollAPI.Model
{
	public class PollResponse
	{
		public List<Poll> Polls { get; set; } = new List<Poll>();
		public int Pages { get; set; }
		public int CurrentPage { get; set; }
	}
}
