using CSharpLearningApp.Classes.Navigation;
using CSharpLearningApp.Models.PageModels;
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
	/// Логика взаимодействия для TheoryPage.xaml
	/// </summary>
	public partial class TheoryPage : Page
	{
		public TheoryPage(Theory theory)
		{
			InitializeComponent();
			if (theory != null)
			{
				TBlockTheoryText.Text = theory.TheoryContent;
			}
		}

		private void ButtonGoBack_Click(object sender, RoutedEventArgs e)
		{
			NavigationManager.MainFrame.GoBack();
		}
	}
}
