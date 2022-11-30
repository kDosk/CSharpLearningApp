using CSharpLearningApp.Classes.AuthorizationService;
using CSharpLearningApp.Models;
using CSharpLearningApp.Models.PageModels.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.Calculation
{
	internal static class TestCalculate
	{
		/// <summary>
		/// Метод калькуляции правильных ответов теста с использованием элемента управления RadioButton
		/// </summary>
		/// <param name="listViewItems">Элементы ListView</param>
		/// <param name="testModels">Тестовый бланк</param>
		public static string Calculate(TestList testList)
		{
			var userTestList = testList.TestQuestions.ToList();
			int correctAnswersCount = 0;

			for (int i = 0; i < userTestList.Count; i++)
			{
				var currentAnswers = userTestList[i].Answers;
				for (int j = 0; j < currentAnswers.Count; j++)
				{
					if (currentAnswers[j].IsCorrect == true && currentAnswers[j].Value == userTestList[i].CorrectAnswer)
					{
						correctAnswersCount++;
						currentAnswers[j].IsCorrect = false;
						break;
					}
				}
			}
			int score = Score(correctAnswersCount, userTestList.Count);

			string result = $"Тест завершен. Реузльтат: {correctAnswersCount} из {userTestList.Count}.\nОценка: {score}";

			ApplicationContext.GetContext().TestScoreLogs.Add(new Models.PageModels.TestScoreLog
			{
				User = AuthorizationManager.CurrentUser,
				TestList = testList,
				Score = score

			});
			return result;
		}

		private static int Score(int correctAnswersCount, int answersCount)
		{
			double correctAnswersPercent = 100f / answersCount * correctAnswersCount;

			if (correctAnswersPercent >= 80)
			{
				return 5;
			}	
			else if (correctAnswersPercent >= 70)
			{
				return 4;
			}
			else if (correctAnswersPercent >= 50)
			{
				return 3;
			}
			else
			{
				return 2;
			}
		}
	}
}
