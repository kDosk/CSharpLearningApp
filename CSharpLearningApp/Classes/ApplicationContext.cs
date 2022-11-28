using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSharpLearningApp.Classes
{
	internal class ApplicationContext : DbContext
	{
		public DbSet<Answer> Answers { get; set; } = null!;
		public DbSet<TestQuestion> Tests { get; set; } = null!;
		public DbSet<TestList> TestLists { get; set; } = null!;
		public DbSet<Practice> Practices { get; set; } = null!;
		public DbSet<Theory> Theory { get; set; } = null!;
		public DbSet<Subtitle> Subtitles { get; set; } = null!;
		public DbSet<Title> Titles { get; set; } = null!;
		public DbSet<UserTestList> UserTestLists { get; set; } = null!;
		public DbSet<UserPracticeList> UserPracticeLists { get; set; } = null!;
		public DbSet<User> Users { get; set; } = null!;

		public ApplicationContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=testdb.db");
		}
	}
}
