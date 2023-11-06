using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using var context = new BlogDataContext();

var posts = context.PostWithTagsCounts.ToList();
