namespace P4TableRelations.Models;

public class Post
{
    public int Id { get; set;}
    public string? UserName { get; set;}
    public string? Published { get; set; }
    public string? PhotoUser { get; set; }
    public string? ImagePost { get; set; }
    public List<Comment> Comments { get; set; }
    public Post ()
    {
        Comments = new List<Comment> ();
    }
}