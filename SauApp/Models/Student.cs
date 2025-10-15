namespace SauApp.Models;

public class Student
{

    public string? StudentID { get; set; } = String.Empty;
    public string Name { get; set; }

    public string? Surname { get; set; }= String.Empty;

    public bool Signed { get; set; }
    public DateTime? SignedAt { get; set; }


}
