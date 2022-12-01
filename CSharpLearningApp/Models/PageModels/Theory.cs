namespace CSharpLearningApp.Models.PageModels
{
	public class Theory
	{
		public int ID { get; set; }
		public string TheoryContent { get; set; }
		public int SubtitleID { get; set; }

		public Subtitle Subtitle { get; set; }
	}
}
