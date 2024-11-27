using System.ComponentModel.DataAnnotations;

namespace Data.Entity.Tbl;

public class Comment
{
    [Key] 
    public int Id { get; set; }

    public string FullName { get; set; }
    public string Email { get; set; }
    public string CommentText { get; set; }
    public DateTime CreateDate { get; set; }
}