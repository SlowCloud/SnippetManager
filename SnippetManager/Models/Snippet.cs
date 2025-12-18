using System;
using System.Collections.Generic;
using System.Text;

namespace SnippetManager.Models
{
    public class Snippet
    {
        private string title;
        private string content;

        public Snippet(string title, string content)
        {
            this.title = title;
            this.content = content;
        }

        public override string ToString()
        {
            return String.Format("Title: {0}, Content: {1}", title, content);
        }

        public string Content { get => content; set => content = value; }
        public string Title { get => title; set => title = value; }

    }
}
