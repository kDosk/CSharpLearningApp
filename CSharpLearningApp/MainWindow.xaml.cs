using CSharpLearningApp.Classes;
using CSharpLearningApp.Classes.AuthorizationService;
using CSharpLearningApp.Classes.MessageService;
using CSharpLearningApp.Models;
using CSharpLearningApp.Models.UserModels;
using CSharpLearningApp.PageData;
using CSharpLearningApp.Templates;
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
        }
        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            var currentThemeTitle = ((sender as Button).Content as TextBlock).Text;
			//Переход к окну по названию нажатой кнопки
			switch (currentThemeTitle)
			{
				case "Переменные и константы":
					new PageData.PageByKamilya.PageTitleData().AddData(currentThemeTitle);
                    ShowWindow(currentThemeTitle);
                    break;
				//case "Типы данных":
				//	ShowWindow(new Window());
				//	break;
				//case "Арифметические вычисления":
				//	ShowWindow(new Window());
				//	break;
				//case "Операции присваивания":
				//	ShowWindow(new Window());
				//	break;
				//case "Преобразование базовых типов данных":
				//	ShowWindow(new Window());
				//	break;
				//case "Условные выражения":
				//	ShowWindow(new Window());
				//	break;
				//case "Циклы":
				//	ShowWindow(new Window());
				//	break;
				//case "Массивы":
				//	ShowWindow(new Window());
				//	break;
				//case "Методы":
				//	ShowWindow(new Window());
				//	break;
				//case "Оператор return":
				//	ShowWindow(new Window());
				//	break;
				//case "Перечисления enum":
				//	ShowWindow(new Window());
				//	break;
				default:
					MessageBox.Show("Ошибка выполнения.");
					break;
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
					AuthorizationManager.SignIn(TBoxSignInLogin.Text, TBoxSignInPass.Password);
					break;
				case "Регистрация":
					AuthorizationManager.SignUp(TBoxSignUpName.Text, TBoxSignUpSurname.Text, TBoxSignUpLogin.Text, TBoxSignUpPass.Password, TBoxSignUpPassConfirm.Password);
					break;
				default:
					break;
			}
		}

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



		#region Show/Hide modal window
		private void ShowModal_Click(object sender, RoutedEventArgs e)
        {
            ShowModal();
        }

        private void HideModal_Click(object sender, RoutedEventArgs e)
        {
            HideModal();
        }

        private void ShowModal()
        {
            AuthModalWindow.IsOpen = true;
        }
        private void HideModal()
        {
            AuthModalWindow.IsOpen = false;
        }
		#endregion

		
	}
}
