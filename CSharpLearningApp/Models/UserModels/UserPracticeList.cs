using CSharpLearningApp.Models.PageModels;

namespace CSharpLearningApp.Models.UserModels
{
	public class UserPracticeList
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public bool IsPassed { get; set; } = false;
		public int PracticeID { get; set; }


		public User User { get; set; }
		public Practice Practice { get; set; }
	}
}
