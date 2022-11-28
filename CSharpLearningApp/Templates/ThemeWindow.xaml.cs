﻿using CSharpLearningApp.Classes;
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
            ThemeWindowMainFrame.Content = new MainPage(currentTitle);
        }
    }
}
