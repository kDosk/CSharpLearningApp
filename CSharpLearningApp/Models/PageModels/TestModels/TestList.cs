using System.Collections.Generic;

namespace CSharpLearningApp.Models.PageModels.TestModels
{
	public class TestList
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public int SubtitleID { get; set; }

		public Subtitle Subtitle { get; set; }
		public List<TestQuestion> TestQuestions { get; set; } = new List<TestQuestion>();

	}
}
