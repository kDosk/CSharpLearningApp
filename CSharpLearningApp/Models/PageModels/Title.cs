﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels
{
	public class Title
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<Subtitle> Subtitles { get; set; } = new List<Subtitle>();

		public virtual Practice Practice { get; set; }
	}
}
