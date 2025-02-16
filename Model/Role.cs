namespace ProfessorRating.Model;

public class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public List<User>? Users { get; set; } = new(); 
}