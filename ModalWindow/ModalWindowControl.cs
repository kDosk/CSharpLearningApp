using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ModalWindow
{
	/// <summary>
	/// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
	///
	/// Step 1a) Using this custom control in a XAML file that exists in the current project.
	/// Add this XmlNamespace attribute to the root element of the markup file where it is 
	/// to be used:
	///
	///     xmlns:MyNamespace="clr-namespace:ModalWindow"
	///
	///
	/// Step 1b) Using this custom control in a XAML file that exists in a different project.
	/// Add this XmlNamespace attribute to the root element of the markup file where it is 
	/// to be used:
	///
	///     xmlns:MyNamespace="clr-namespace:ModalWindow;assembly=ModalWindow"
	///
	/// You will also need to add a project reference from the project where the XAML file lives
	/// to this project and Rebuild to avoid compilation errors:
	///
	///     Right click on the target project in the Solution Explorer and
	///     "Add Reference"->"Projects"->[Select this project]
	///
	///
	/// Step 2)
	/// Go ahead and use your control in the XAML file.
	///
	///     <MyNamespace:CustomControl1/>
	///
	/// </summary>
	public class ModalWindowControl : ContentControl
	{
		static ModalWindowControl()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(ModalWindowControl), new FrameworkPropertyMetadata(typeof(ModalWindowControl)));
			BackgroundProperty.OverrideMetadata(typeof(ModalWindowControl), new FrameworkPropertyMetadata(CreateDefaultBackground()));
		}

		public bool IsOpen
		{
			get { return (bool)GetValue(IsOpenProperty); }
			set { SetValue(IsOpenProperty, value); }
		}

		// Using a DependencyProperty as the backing store for IsOpen.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty IsOpenProperty =
			DependencyProperty.Register("IsOpen", typeof(bool), typeof(ModalWindowControl), new PropertyMetadata(false));

		private static object CreateDefaultBackground()
		{
			return new SolidColorBrush(Colors.Black)
			{
				Opacity = 0.3
			};
		}
	}
}
