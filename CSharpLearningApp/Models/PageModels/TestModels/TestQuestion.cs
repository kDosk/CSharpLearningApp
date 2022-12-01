using System.Collections.Generic;

namespace CSharpLearningApp.Models.PageModels.TestModels
{
	public class TestQuestion
	{
		public int ID { get; set; }
		public string Question { get; set; }
		public List<Answer> Answers { get; set; } = new List<Answer>();
		public string CorrectAnswer { get; set; }
		public int TestListID { get; set; }

		public TestList TestList { get; set; }

	}
}
