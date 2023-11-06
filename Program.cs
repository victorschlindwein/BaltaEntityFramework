using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

context.Users.Add(new User
{
    Bio = "Vitao",
    Email = "eu@victorschlindwein.com",
    Image = "vitao.jpeg",
    Name = "Vitao",
    PasswordHash = "vitao123",
    GitHub = "github.com/victorschlindwein",
    Slug = "vitao",
}
);
context.SaveChanges();

var user = context.Users.FirstOrDefault(x => x.Name.Equals("Vitao"));
var category = context.Categories.FirstOrDefault(x => x.Name.Equals("backend"));

var post = new Post
{
    Author = user,
    Body = "Corpo do artigo",
    Category = category,
    CreateDate = System.DateTime.Now,
    // LastUpdateDate =
    Slug = "artigo-do-vitao",
    Summary = "Neste artigo vamos falar...",
    //Tags = null,
    Title = "Titulo do artigo"
};

context.Add(post);
context.SaveChanges();