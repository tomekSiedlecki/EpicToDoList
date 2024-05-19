using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDoList.models
{
    public class Assignment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssignmentId { get; set; }
        public string Content { get; set; }
        public bool IsChecked { get; set; }

        public Assignment(string Content, bool IsChecked) 
        {
            this.Content = Content;
            this.IsChecked = IsChecked;
        }

    }
}
