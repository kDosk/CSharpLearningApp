using CSharpLearningApp.Models.UserModels;

namespace CSharpLearningApp.Models.PageModels
{
	public class PracticeScoreLog
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public int PracticeID { get; set; }
		public int Score { get; set; }

		public User User { get; set; }
		public Practice Practice { get; set; }
	}
}
