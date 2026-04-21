using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Domain.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; } = []; //1 to many relationship with Blog
    }
}
