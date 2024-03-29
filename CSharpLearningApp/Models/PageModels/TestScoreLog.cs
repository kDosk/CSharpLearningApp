﻿using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.UserModels;

namespace CSharpLearningApp.Models.PageModels
{
	public class TestScoreLog
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public int TestListID { get; set; }
		public int Score { get; set; }

		public User User { get; set; }
		public TestList TestList { get; set; }
	}
}
