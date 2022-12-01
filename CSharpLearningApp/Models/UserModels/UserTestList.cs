using CSharpLearningApp.Models.PageModels.TestModels;

namespace CSharpLearningApp.Models.UserModels
{
	public class UserTestList
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public bool IsPassed { get; set; } = false;
		public int TestListID { get; set; }


		public User User { get; set; }
		public TestList TestList { get; set; }
	}
}
