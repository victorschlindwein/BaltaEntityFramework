using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

var posts = GetPosts(context, 0, 25);

static async Task<IEnumerable<Post>> GetPosts(BlogDataContext context, int skip = 0, int take = 25)
{
    var posts = context
        .Posts
        .AsNoTracking()
        .Skip(skip)
        .Take(take)
        .ToList();

    return posts;
}