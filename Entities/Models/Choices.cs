namespace BlissPollAPI.Entities.Models
{
	public class Choices
	{
		public int Id { get; set; }
		public string Choice { get; set; } = string.Empty;
		public int Votes { get; set; }
		public Poll Poll { get; set; } = new Poll();
		public int PollId { get; set; }
	}
}
