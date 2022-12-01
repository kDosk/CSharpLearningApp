using CSharpLearningApp.Classes.Navigation;
using System;
using System.Windows;

namespace CSharpLearningApp.Templates
{
	/// <summary>
	/// Логика взаимодействия для ThemeWindow.xaml
	/// </summary>
	public partial class ThemeWindow : Window
	{
		public ThemeWindow(string currentTitle)
		{
			InitializeComponent();
			TBlockWindowTitle.Text = currentTitle;
			this.Title = currentTitle;
			NavigationManager.MainFrame = ThemeWindowMainFrame;
			NavigationManager.MainFrame.Navigate(new MainPage(currentTitle));
		}

		private void ButtonGoBack_Click(object sender, RoutedEventArgs e)
		{
			if (ButtonGoBack.Content.ToString() == "На главную")
			{
				this.Close();
			}
			else
			{
				NavigationManager.MainFrame.GoBack();
			}
		}

		private void ThemeWindowMainFrame_ContentRendered(object sender, EventArgs e)
		{
			if (ThemeWindowMainFrame.CanGoBack)
			{
				ButtonGoBack.Content = "Назад";
			}
			else
			{
				ButtonGoBack.Content = "На главную";
			}
		}
	}
}
