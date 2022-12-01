using CSharpLearningApp.Models.PageModels;
using System.Windows.Controls;

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
	}
}
