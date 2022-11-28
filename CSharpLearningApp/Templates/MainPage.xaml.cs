﻿using CSharpLearningApp.Classes;
using CSharpLearningApp.Models;
using CSharpLearningApp.PageData.PageByKamilya;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
	/// Логика взаимодействия для MainPage.xaml
	/// </summary>
	public partial class MainPage : UserControl
	{
		private readonly ApplicationContext _db;
		public MainPage(ApplicationContext db, string currentTitle)
		{
			InitializeComponent();
			_db = db;
			db.Subtitles.Where(p => p.Title.Name == currentTitle).Load();
			var list = db.Subtitles.ToList();
			LViewTitles.ItemsSource = list;
			
		}
	}
}
