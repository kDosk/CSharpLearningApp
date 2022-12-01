using CSharpLearningApp.Classes;
using CSharpLearningApp.Classes.Calculation;
using CSharpLearningApp.Models.PageModels;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CSharpLearningApp.Templates
{
	/// <summary>
	/// Логика взаимодействия для PracticePage.xaml
	/// </summary>
	public partial class PracticePage : Page
	{
		private Classes.CSharpCompiler.Script _script;
		private Practice _practice;

		public PracticePage(Practice practice)
		{
			InitializeComponent();

			CompileCommand = new RelayCommand(o => Compile());
			Initialize();

			_practice = practice;
			TBlockTask.Text = practice.Task;
			DataContext = this;
		}

		private void ButtonConfirm_Click(object sender, RoutedEventArgs e)
		{
			PracticeCalculate.Calculate(TBoxOutput.Text, _practice);
		}

		#region Compiler
		private static Assembly[] references = new[]
		{
			typeof(object).Assembly,
			typeof(Uri).Assembly,
			typeof(Enumerable).Assembly,
			typeof(MessageBox).Assembly
		};

		private static string[] usings = new[]
		{
			"System",
			"System.IO",
			"System.Text",
			"System.Windows"
		};

		public ICommand CompileCommand { get; }

		async void Initialize()
		{
			_script = await Classes.CSharpCompiler.Script.Create(references, usings);
		}

		async void Compile()
		{
			var command = TBoxInput.Text;
			try
			{
				var result = await _script.ExecuteNext(command);
				TBoxOutput.Text = result?.ToString();
			}
			catch (CompilationErrorException ex)
			{
				TBoxOutput.Text = ex.Message;
			}
			catch (Exception ex)
			{
				TBoxOutput.Text = ex.Message;
			}
		}
		#endregion
	}
}
