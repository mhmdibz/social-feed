using Blog.Infrastructure.Persistence;
using Blog.Infrastructure.Seed_Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Blog Database Seeding");
Console.WriteLine("=====================\n");

try
{
    using var context = new BlogDbContext();
    
    Console.WriteLine("Seeding started...");
    await Seed_Data.SeedUsersAsync(context);
    Console.WriteLine("Seeding completed successfully!\n");
    
    // Display statistics
    var userCount = await context.Users.CountAsync();
    var postCount = await context.Posts.CountAsync();
    var commentCount = await context.Comments.CountAsync();
    var reactionCount = await context.Reactions.CountAsync();
    
    Console.WriteLine($"Database Statistics:");
    Console.WriteLine($"- Users: {userCount}");
    Console.WriteLine($"- Posts: {postCount}");
    Console.WriteLine($"- Comments: {commentCount}");
    Console.WriteLine($"- Reactions: {reactionCount}");
}
catch (Exception ex)
{
    Console.WriteLine($"\nSeeding failed: {ex.Message}");
    Console.WriteLine($"\nStack Trace:\n{ex.StackTrace}");
    throw;
}
