// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;

using (var ctx = new BlogDataContext())
{
  var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
  ctx.Tags.Add(tag);
  ctx.SaveChanges();
}
