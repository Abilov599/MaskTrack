namespace Entities.Concrete;

public class Person
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public long NationalIdentity { get; set; }
    public int DateOfBirthYear { get; set; }
}