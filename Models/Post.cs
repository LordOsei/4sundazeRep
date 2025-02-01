using System;

public class Post
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
    public string Content { get; set; }
    public string PhotoPath { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
