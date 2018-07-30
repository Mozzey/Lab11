using System;

namespace Movies.Library
{
    public class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public string GetTitle()
        {
            return Title;
        }


        public string GetCategory()
        {
            return Category;
        }

        
    }
}
