using CSharpLearningApp.Classes.MessageService;
using CSharpLearningApp.Models;
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
			//Переход к окну по названию нажатой кнопки
			switch ((sender as Button).Content)
			{
				case "Переменные и константы":
					ShowWindow(new Window());
					break;
				case "Типы данных":
					ShowWindow(new Window());
					break;
				case "Арифметические вычисления":
					ShowWindow(new Window());
					break;
				case "Операции присваивания":
					ShowWindow(new Window());
					break;
				case "Преобразование базовых типов данных":
					ShowWindow(new Window());
					break;
				case "Условные выражения":
					ShowWindow(new Window());
					break;
				case "Циклы":
					ShowWindow(new Window());
					break;
				case "Массивы":
					ShowWindow(new Window());
					break;
				case "Методы":
					ShowWindow(new Window());
					break;
				case "Оператор return":
					ShowWindow(new Window());
					break;
				case "Перечисления enum":
					ShowWindow(new Window());
					break;
				default:
					MessageBox.Show("Ошибка выполнения.");
					break;
			}
		}

        /// <summary>
        /// Метод открытия окна
        /// </summary>
        /// <param name="currentWindow">Название окна</param>
        private void ShowWindow(Window currentWindow)
        {
            currentWindow.ShowDialog();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignInButton_Checked(object sender, RoutedEventArgs e)
        {
            gridSignIn.Visibility = Visibility.Visible;
            gridSignUp.Visibility = Visibility.Hidden;
        }

        private void SignUpButton_Checked(object sender, RoutedEventArgs e)
        {
            gridSignUp.Visibility = Visibility.Visible;
            gridSignIn.Visibility = Visibility.Hidden;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {

        }

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
    }
}
