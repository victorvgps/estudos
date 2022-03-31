using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_String_Builder.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
            
        }

        public Comment(string text)
        {
            Text = text;    
        }
    }
}
