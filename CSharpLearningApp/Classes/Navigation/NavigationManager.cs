using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CSharpLearningApp.Classes.Navigation
{
	internal class NavigationManager : INotifyPropertyChanged
	{
		private UserControl _currentPage;
		private UserControl _previousPage;
		public UserControl CurrentPage
		{
			get { return _currentPage; }
			set
			{
				PreviousPage = _currentPage;
				_currentPage = value;
				OnPropertyChanged("CurrentPage");
			}
		}
		public UserControl PreviousPage
		{
			get { return _previousPage; }
			set
			{
				_previousPage = value;
				OnPropertyChanged("PreviousPage");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName]string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
