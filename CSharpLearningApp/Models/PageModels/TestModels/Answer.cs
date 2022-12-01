namespace CSharpLearningApp.Models.PageModels.TestModels
{
	public class Answer
	{
		public int ID { get; set; }
		public string Value { get; set; }
		public bool IsCorrect { get; set; } = false;
		public int TestQuestionID { get; set; }

		public TestQuestion TestQuestion { get; set; }
	}
}
