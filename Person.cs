public class Person
{
    public string FullName { get; set;} = string.Empty;
    public string Email { get; set;} = string.Empty;

    public Person(string fullName, string email)
    {
        FullName = fullName;
        Email = email;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"-Personal-\nName: {FullName}\nEmail: {Email}\n");
    }
}