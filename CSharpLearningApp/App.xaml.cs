using CSharpLearningApp.Classes;
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
			ApplicationContext.GetContext();
			MainWindow window = new MainWindow();
			window.Show();
		}
	}
}
