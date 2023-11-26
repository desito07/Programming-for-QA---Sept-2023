﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Articles
{
    internal class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article( string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit( string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor )
        {   
            Author = newAuthor;

        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
    }
}
