using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Models;

[Table("Post")]
public partial class Post
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Summary { get; set; }

    public int? UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Posts")]
    public virtual User? User { get; set; }
}
