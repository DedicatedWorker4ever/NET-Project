namespace cbsStudents.Models.Entities;

public class PostIndexVm
{
    public IEnumerable<Post> Posts { get; set; }
    public string SearchString { get; set; }
}