using CSharpLearningApp.Classes;
using CSharpLearningApp.Classes.Navigation;
using CSharpLearningApp.Models;
using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.PageData.PageByKamilya;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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
using CSharpLearningApp.Classes.AuthorizationService;
using CSharpLearningApp.Classes.MessageService;

namespace CSharpLearningApp.Templates
{
	/// <summary>
	/// Логика взаимодействия для MainPage.xaml
	/// </summary>
	public partial class MainPage : Page
	{
		private readonly Title _currentTitle;
		public MainPage(string currentTitle)
		{
			InitializeComponent();
			if (currentTitle != null)
			{
				_currentTitle = ApplicationContext.GetContext().Titles.Where(p => p.Name == currentTitle).Include(p => p.Subtitles)
																									 .ThenInclude(p => p.Theory)
																									 .Include(p => p.Subtitles)
																									 .ThenInclude(p => p.TestList)
																									 .ThenInclude(p => p.TestQuestions)
																									 .ThenInclude(p => p.Answers)
																									 .Include(p => p.Practice).FirstOrDefault();
				DataContext = _currentTitle;
			}
			
		}

		private void TheoryButton_Click(object sender, RoutedEventArgs e)
		{
			var currentTheoryData = ((sender as Button).DataContext as Subtitle).Theory;
			NavigationManager.MainFrame.Navigate(new TheoryPage(currentTheoryData));
		}

		private void TestButton_Click(object sender, RoutedEventArgs e)
		{
			var currentTestListData = ((sender as Button).DataContext as Subtitle).TestList;
			if (!AuthorizationManager.CurrentUser.UserTestList.Exists(p => p.TestList == currentTestListData))
			{
				AuthorizationManager.CurrentUser.UserTestList.Add(new Models.UserModels.UserTestList
				{
					User = AuthorizationManager.CurrentUser,
					TestList = currentTestListData
				});
				ApplicationContext.GetContext().SaveChanges();
			}
			if (!AuthorizationManager.CurrentUser.UserTestList.Where(p => p.TestList == currentTestListData).FirstOrDefault().IsPassed)
			{
				NavigationManager.MainFrame.Navigate(new TestPage(currentTestListData));
			}
			else
			{
				MessageService.ShowError("Данный тест пройден.");
			}
		}

		private void PracticeButton_Click(object sender, RoutedEventArgs e)
		{
			var currentPractice = _currentTitle.Practice;
			if (!AuthorizationManager.CurrentUser.UserPracticeList.Exists(p => p.Practice == currentPractice))
			{
				AuthorizationManager.CurrentUser.UserPracticeList.Add(new Models.UserModels.UserPracticeList
				{
					User = AuthorizationManager.CurrentUser,
					Practice = currentPractice
				});
				ApplicationContext.GetContext().SaveChanges();
			}
			NavigationManager.MainFrame.Navigate(new PracticePage());
		}
	}
}
