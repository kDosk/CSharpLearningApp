using System.Collections.Generic;

namespace CSharpLearningApp.Models.PageModels
{
	public class Title
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string TitleCreator { get; set; }
		public List<Subtitle> Subtitles { get; set; } = new List<Subtitle>();

		public Practice Practice { get; set; } = null;
	}
}
