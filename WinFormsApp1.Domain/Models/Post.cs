using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WinFormsApp1.Domain.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [ForeignKey(nameof(BlogId))]
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; } //1 to 1 relationship with Post
    }
}
