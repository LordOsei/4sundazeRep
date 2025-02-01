using System;
using System.Collections.Generic;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public ICollection<Post> Posts { get; set; }
}
