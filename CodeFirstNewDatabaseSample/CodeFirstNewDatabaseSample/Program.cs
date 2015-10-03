using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog 
                Console.Write("请输入新博客名称: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("所有博客数据：:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("请输入任意键...");
                Console.ReadKey();
            }
        }

        public class Blog
        {
            public int BlogId { get; set; }
            public string Name { get; set; }
            public string Url { get; set; } 

            public virtual List<Post> Posts { get; set; }
        }

        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int BlogId { get; set; }
            public virtual Blog Blog { get; set; }
        }

        public class User {
            [Key]
            public string UserName { get; set; }
            public string DisplayName { get; set; }
        }

        public class BloggingContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<User> Users { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().Property(u => u.DisplayName).HasColumnName("display_name");
            }
        }
    }
} 