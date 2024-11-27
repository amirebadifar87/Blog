using System.ComponentModel.DataAnnotations;

namespace Data.Entity;

public class Comment
{
    [Key] 
    public int Id { get; set; }

    public string FullName { get; set; }
    public string Email { get; set; }
    public string CommentText { get; set; }
    public DateTime CreateDate { get; set; }

    public int PostId { get; set; }

    public int? QuestionId { get; set; }
}