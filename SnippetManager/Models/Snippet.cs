using System;
using System.Collections.Generic;
using System.Text;

namespace SnippetManager.Models
{
    public class Snippet
    {
        private int snippetId;
        private DateTime createdAt;
        private string content;

        public Snippet(string content)
        {
            this.content = content;
        }

        public int SnippetId { get => snippetId; set => snippetId = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public string Content { get => content; set => content = value; }
    }
}
