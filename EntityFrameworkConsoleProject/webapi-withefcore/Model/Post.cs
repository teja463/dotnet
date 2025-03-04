﻿using System.ComponentModel.DataAnnotations.Schema;

namespace webapi_withefcore.Model;

[Table("Post")]
public class Post
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;
    public string? Summary { get; set; }

    public int UserId { get; set; }

    public User User { get; set; } = null!;

}