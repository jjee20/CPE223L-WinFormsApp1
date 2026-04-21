using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Domain.ViewModels;
using WinFormsApp1.Infastructure.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2MessageDialog1.Show("Loading data...");
            using var context = new AppDbContext();
            dataGridView1.DataSource = context.Blogs.Include(b => b.Posts)
                                                    .Select(b => new BlogVM
                                                    {
                                                        BlogId = b.BlogId,
                                                        Url = b.Url,
                                                        PostTitles = string.Join(", ", b.Posts.Select(p => p.Title))
                                                    })
                                                    .ToList();
        }
    }
}
