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

        public virtual string GetTitle()
        {
            return Title;
        }


        public virtual string GetCategory()
        {
            return Category;
        }
    }
}
