using System.ComponentModel.DataAnnotations;

namespace Data.Entity.Tbl;

public class Category
{
    [Key]
    public int Id { get; set; }

    public String Title { get; set; }

    public List<Post> Posts { get; set; }
}