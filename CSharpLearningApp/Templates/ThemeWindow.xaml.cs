using CSharpLearningApp.Classes;
using CSharpLearningApp.Classes.Navigation;
using CSharpLearningApp.PageData;
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
using System.Windows.Shapes;

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
