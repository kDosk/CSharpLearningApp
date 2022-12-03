using CSharpLearningApp.Classes;
using CSharpLearningApp.Templates;
using System.Windows;

namespace CSharpLearningApp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			MainWindow window = new MainWindow();
			UserInstructionWindow instuction = new UserInstructionWindow();
			if (instuction.ShowDialog() == true)
			{
				ApplicationContext.GetContext();
				window.Show();
			}
			else
			{
				Current.Shutdown();
			}
		}
	}
}
