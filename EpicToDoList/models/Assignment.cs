using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDoList.models
{
    public class Assignment
    {
        public string Content { get; set; }
        public bool IsChecked { get; set; }

        public Assignment(string Content, bool IsChecked) 
        {
            this.Content = Content;
            this.IsChecked = IsChecked;
        }

    }
}
