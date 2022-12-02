using CSharpLearningApp.Classes.AuthorizationService;
using CSharpLearningApp.Classes.Navigation;
using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.Models.PageModels.TestModels;
using System.Linq;
using System.Windows;

namespace CSharpLearningApp.Classes.Calculation
{
	internal static class PracticeCalculate
	{
		public static void Calculate(string answer, Practice practice)
		{
			if (answer == practice.CorrectAnswer)
			{
				MessageService.MessageService.ShowMessage("Практическое задание завершено. \nОценка: 5");

				ApplicationContext.GetContext().PracticeScoreLogs.Add(new PracticeScoreLog
				{
					User = AuthorizationManager.CurrentUser,
					Practice = practice,
					Score = 5
				});

				AuthorizationManager.CurrentUser.UserPracticeList.Single(p => p.Practice == practice).IsPassed = true;
				ApplicationContext.GetContext().SaveChanges();

				InfoStorage.Information += $"{AuthorizationManager.CurrentUser.Surname} {AuthorizationManager.CurrentUser.Name} выполнил практическое задание по теме {practice.Title.Name}. Оценка: \"5\"\n\n";

				NavigationManager.MainFrame.GoBack();
			}
			else
			{
				if (MessageBox.Show("Практическое задание завершено. \nОценка: 2\nПовторить практическое задание?", "Результат", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
				{
					ApplicationContext.GetContext().PracticeScoreLogs.Add(new PracticeScoreLog
					{
						User = AuthorizationManager.CurrentUser,
						Practice = practice,
						Score = 2
					});

					AuthorizationManager.CurrentUser.UserPracticeList.Single(p => p.Practice == practice).IsPassed = true;

					ApplicationContext.GetContext().SaveChanges();

					InfoStorage.Information += $"{AuthorizationManager.CurrentUser.Surname} {AuthorizationManager.CurrentUser.Name} выполнил практическое задание по теме {practice.Title.Name}. Оценка: \"2\"\n\n";

					NavigationManager.MainFrame.GoBack();
				}
			}
		}
	}
}
