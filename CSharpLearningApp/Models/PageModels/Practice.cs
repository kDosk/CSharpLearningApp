namespace CSharpLearningApp.Models.PageModels
{
	public class Practice
	{
		public int ID { get; set; }
		public string Task { get; set; }
		public string CorrectAnswer { get; set; }
		public int TitleID { get; set; }

		public Title Title { get; set; }
	}
}
