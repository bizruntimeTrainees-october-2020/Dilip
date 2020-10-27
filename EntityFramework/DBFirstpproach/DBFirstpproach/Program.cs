using System;


namespace DBFirstpproach
{
        public class Post
        {
            public int ID { get; set; }
            public DateTime DatePublished { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }

    public class BlogDbContext : DbContext
    {
        public DbSet<Post> posts { get; set; 
        }
    }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
