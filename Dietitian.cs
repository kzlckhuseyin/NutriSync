public class Dietitian : Person , IReportable
{
    public string Specialty { get; set;} = string.Empty;
    public Dietitian(string fullName, string email, string specialty) : base(fullName, email)
    {
        Specialty = specialty;
    }
    public string GetSummary()
    {
        return $"Dietitian: {FullName}, Specialty: {Specialty}";
    }
}