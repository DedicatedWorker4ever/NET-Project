using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class Comment
{
    public int CommentId { get; set; }
    public string Text { get; set; }
    [DataType(DataType.Date)]   
    public DateTime TimeStamp { get; set; }

    public int PostId { get; set; }
    public Post Post { get; set; }

    public string UserId { get; set; }
    public IdentityUser? User { get; set; }


}