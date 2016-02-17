namespace WebApplication41.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication41.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication41.Models.WebApplication41Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApplication41.Models.WebApplication41Context context)
        {
            context.Categories.AddOrUpdate(x => x.Id,
        new Category() { Id = 1, Name = "Syfy" },
        new Category() { Id = 2, Name = "Drama" },
        new Category() { Id = 3, Name = "Detective" }
        );
            context.Books.AddOrUpdate(x => x.Id,
                    new Book()
                    {
                        Id = 1,
                        Title = "Pride and Prejudice",
                        ISBN = 123,
                        CategoryId = 2,
                        Author = "Jane Austen"
                    },
                    new Book()
                    {
                        Id = 2,
                        Title = "Sherkock Holmes",
                        ISBN = 456,
                        CategoryId = 3,
                        Author = "Conan Doyle"
                    },
                    new Book()
                    {
                        Id = 3,
                        Title = "Northanger Abbey",
                        ISBN = 741,
                        CategoryId = 1,
                        Author = "Jane Austen"
                    },
                    new Book()
                    {
                        Id = 4,
                        Title = "Don Quixote",
                        ISBN = 789,
                        CategoryId = 1,
                        Author = "Miguel de Cervantes"
                    }
                    );
        }
    }
}
