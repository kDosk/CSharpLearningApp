using CSharpLearningApp.Classes;
using CSharpLearningApp.Classes.AuthorizationService;
using CSharpLearningApp.Classes.MessageService;
using CSharpLearningApp.Templates;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CSharpLearningApp
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			TBoxinfo.Text = "Нет данных";
		}
		private void NavigateButton_Click(object sender, RoutedEventArgs e)
		{
			var currentThemeTitle = ((sender as Button).Content as TextBlock).Text;
			//Переход к окну по названию нажатой кнопки
			if (AuthorizationManager.CurrentUser != null)
			{
				switch (currentThemeTitle)
				{
					case "Переменные и константы":
						new PageData.Page_1.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Типы данных":
						new PageData.Page_2.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Арифметические вычисления":
						new PageData.Page_3.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Операции присваивания":
						new PageData.Page_4.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Преобразование типов данных":
						MessageService.ShowMessage("Данный элемент в разработке.");
						break;
					case "Условные выражения":
						new PageData.Page_6.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Циклы":
						new PageData.Page_7.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Массивы":
						MessageService.ShowMessage("Данный элемент в разработке.");
						break;
					case "Методы":
						new PageData.Page_9.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Оператор return":
						new PageData.Page_10.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					case "Перечисления enum":
						new PageData.Page_11.PageTitleData().AddData(currentThemeTitle);
						ShowWindow(currentThemeTitle);
						break;
					default:
						MessageBox.Show("Ошибка выполнения.");
						break;
				}
				TBoxinfo.Text = InfoStorage.Information;
			}
			else
			{
				MessageService.ShowError("Выполните авторизацию.");
			}
		}

		private void ShowWindow(string currentTitle)
		{
			ThemeWindow window = new ThemeWindow(currentTitle);
			window.ShowDialog();
		}

		private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
		{
			switch ((AuthorizationButton.Content as TextBlock).Text)
			{
				case "Вход":
					if (AuthorizationManager.SignIn(TBoxSignInLogin.Text, TBoxSignInPass.Password))
					{
						HideModal();
						TBlockUserInfo.Text = $"Текущий пользователь:\n{AuthorizationManager.CurrentUser.Surname} {AuthorizationManager.CurrentUser.Name}";
					}
					break;
				case "Регистрация":
					if (AuthorizationManager.SignUp(TBoxSignUpName.Text, TBoxSignUpSurname.Text, TBoxSignUpLogin.Text, TBoxSignUpPass.Password, TBoxSignUpPassConfirm.Password))
					{
						HideModal();
						TBlockUserInfo.Text = $"Текущий пользователь:\n{AuthorizationManager.CurrentUser.Surname} {AuthorizationManager.CurrentUser.Name}";
					}
					break;
				default:
					break;
			}
		}
		private void UserExit_Click(object sender, RoutedEventArgs e)
		{
			if (MessageBox.Show("Выйти из аккаунта?", "Вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
			{
				AuthorizationManager.CurrentUser = null;
				TBlockUserInfo.Text = string.Empty;
				HideModal();
			}
		}

		#region ChangeButtonText
		private void gridSignUp_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (gridSignUp.Visibility == Visibility.Visible)
			{
				(AuthorizationButton.Content as TextBlock).Text = "Регистрация";
			}
		}

		private void gridSignIn_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
		{
			if (gridSignIn.Visibility == Visibility.Visible)
			{
				(AuthorizationButton.Content as TextBlock).Text = "Вход";
			}
		}
		#endregion

		#region Show/Hide modal window
		private void ShowModal_Click(object sender, RoutedEventArgs e)
		{
			ShowModal();
			Clear();
		}

		private void HideModal_Click(object sender, RoutedEventArgs e)
		{
			HideModal();
			Clear();
		}

		private void ShowModal()
		{
			if (AuthorizationManager.CurrentUser == null)
			{
				AuthModalWindow.IsOpen = true;
			}
			else
			{
				UserInfoModalWindow.IsOpen = true;
			}
		}
		private void HideModal()
		{
			AuthModalWindow.IsOpen = false;
			UserInfoModalWindow.IsOpen = false;
		}
		#endregion

		private void Clear()
		{
			TBoxSignInLogin.Text = String.Empty;
			TBoxSignInPass.Password = String.Empty;

			TBoxSignUpLogin.Text = String.Empty;
			TBoxSignUpName.Text = String.Empty;
			TBoxSignUpSurname.Text = String.Empty;
			TBoxSignUpPass.Password = String.Empty;
			TBoxSignUpPassConfirm.Password = String.Empty;
		}
	}
}
