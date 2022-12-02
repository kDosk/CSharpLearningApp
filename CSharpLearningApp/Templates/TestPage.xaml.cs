using CSharpLearningApp.Classes;
using CSharpLearningApp.Classes.AuthorizationService;
using CSharpLearningApp.Classes.Calculation;
using CSharpLearningApp.Classes.MessageService;
using CSharpLearningApp.Classes.Navigation;
using CSharpLearningApp.Models.PageModels.TestModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CSharpLearningApp.Templates
{
	/// <summary>
	/// Логика взаимодействия для TestPage.xaml
	/// </summary>
	public partial class TestPage : Page
	{
		private readonly TestList _testList;
		private readonly List<TestQuestion> _testQuestionsList;

		private TestQuestion _currentTestQuestion;
		private int _currentTestQuestionNumber = 0;

		public TestPage(TestList currentTestList)
		{
			InitializeComponent();
			_testList = currentTestList;
			_testQuestionsList = _testList.TestQuestions.ToList();

			_currentTestQuestion = _testQuestionsList[_currentTestQuestionNumber];

			TestProgress.Maximum = _testQuestionsList.Count;
			UpdateProgressBar();

			DataContext = _currentTestQuestion;
		}

		#region Test buttons eventArgs
		private void ButtonSkipAnswer_Click(object sender, RoutedEventArgs e)
		{
			if ((ButtonNextAnswer.Content as TextBlock).Text == "Завершить тестирование")
			{
				TestListResult();
			}
			else
			{
				GoNextAnswer();
			}
		}

		private void ButtonNextAnswer_Click(object sender, RoutedEventArgs e)
		{
			if (IsCheckedNotNull())
			{
				if ((ButtonNextAnswer.Content as TextBlock).Text == "Завершить тестирование")
				{
					TestListResult();
				}
				else
				{
					GoNextAnswer();
				}
			}
			else
			{
				MessageService.ShowError("Выберите правильный ответ.");
			}
		}
		#endregion

		#region Test show result method
		private void TestListResult()
		{
			MessageService.ShowMessage(TestCalculate.Calculate(_testList));
			AuthorizationManager.CurrentUser.UserTestList.Single(p => p.TestList == _testList).IsPassed = true;
			ApplicationContext.GetContext().SaveChanges();

			InfoStorage.Information += $"{AuthorizationManager.CurrentUser.Surname} {AuthorizationManager.CurrentUser.Name} прошёл тестирование по {_testList.Subtitle.Title.Name}: {_testList.Subtitle.Name}. Оценка: \"{InfoStorage.Score}\"\n\n";

			NavigationManager.MainFrame.GoBack();
		}
		#endregion

		#region Test progressbar
		private void UpdateProgressBar()
		{
			TestProgress.Value = _currentTestQuestionNumber + 1;
			TestProgressText.Text = $"{_currentTestQuestionNumber + 1} из {_testQuestionsList.Count}";
		}
		#endregion

		#region Answer navigation method
		private void GoNextAnswer()
		{
			_currentTestQuestionNumber++;
			_currentTestQuestion = _testQuestionsList[_currentTestQuestionNumber];

			if (_currentTestQuestionNumber < _testQuestionsList.Count)
			{
				DataContext = _currentTestQuestion;
				UpdateProgressBar();

				if (_currentTestQuestionNumber >= _testQuestionsList.Count - 1)
				{
					(ButtonNextAnswer.Content as TextBlock).Text = "Завершить тестирование";
				}
			}
		}
		#endregion

		#region Is checked not null validation method
		private bool IsCheckedNotNull()
		{
			bool isCheckedNotNullValue = false;
			foreach (var item in _currentTestQuestion.Answers)
			{
				if (item.IsCorrect)
				{
					isCheckedNotNullValue = true;
					break;
				}
			}
			return isCheckedNotNullValue;
		}
		#endregion
	}
}
