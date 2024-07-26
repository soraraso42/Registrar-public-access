namespace Registrar;

public class Student
{
    // use of constructor forbidden for 
    // random student id
    public int Id { get; set; } = 000000;
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Type { get; set; } = "";
    public List<Course> courses { get; set; } = [];
};