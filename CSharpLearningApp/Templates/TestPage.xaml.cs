using CSharpLearningApp.Classes.MessageService;
using CSharpLearningApp.Models.PageModels.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

		private void ButtonSkipAnswer_Click(object sender, RoutedEventArgs e)
		{
			if ((ButtonNextAnswer.Content as TextBlock).Text == "Завершить тестирование")
			{
				MessageService.ShowMessage("Тестирование завершено!");
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
				if ((ButtonNextAnswer.Content as TextBlock).Text != "Завершить тестирование")
				{
					GoNextAnswer();
				}
				else
				{
					MessageService.ShowMessage("Тестирование завершено!");
				}
			}
			else
			{
				MessageService.ShowError("Выберите правильный ответ.");
			}
		}
		private void UpdateProgressBar()
		{
			TestProgress.Value = _currentTestQuestionNumber + 1;
			TestProgressText.Text = $"{_currentTestQuestionNumber + 1} из {_testQuestionsList.Count}";
		}
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
	}
}
