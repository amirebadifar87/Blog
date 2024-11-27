using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity.Tbl;

public class Post
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Discription { get; set; }
    public string Contect { get; set; }
    public string Tags { get; set; }
    public string Visit { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    public List<Comment> Comments { get; set; }
    
}