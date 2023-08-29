namespace P4TableRelations.Models;

public class Comment
{
    public int CommentId { get; set; }
    public string? UserName { get; set;}
    public string? Date { get; set; }
    public string? Text { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
}