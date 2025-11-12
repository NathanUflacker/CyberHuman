using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberHuman.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Level { get; set; }
        public string Category { get; set; }
        public string Icon { get; set; }
        public string ColorStart { get; set; }
        public string ColorEnd { get; set; }

        public Course(string id, string title, string description, string duration,
                     string level, string category, string icon, string colorStart, string colorEnd)
        {
            Id = id;
            Title = title;
            Description = description;
            Duration = duration;
            Level = level;
            Category = category;
            Icon = icon;
            ColorStart = colorStart;
            ColorEnd = colorEnd;
        }
    }
}
