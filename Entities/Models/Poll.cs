namespace BlissPollAPI.Entities.Models
{
	public class Poll
	{
		public int Id { get; set; }
		public string Image_URL { get; set; } = string.Empty;
		public string Thumb_URL { get; set; } = string.Empty;
		public string Question { get; set; } = string.Empty;
		public DateTime Published_At { get; set; }
		public List<Choices> Choices { get; set; } = new List<Choices>();

	}
}
