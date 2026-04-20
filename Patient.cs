public class Patient : Person, IReportable
{
    public double Weight {get; set;} 
    public double Height {get; set;}
    public string Disease {get; set;} = string.Empty;
    public Patient(string fullName, string email, double weight, double height, string disease) : base(fullName, email)
    {
        Weight = weight;
        Height = height;
        Disease = disease;
    }

    public double CalculateBMI() => Weight / (Height * Height);

    public override void PrintInfo()
    {
        Console.WriteLine($"-Patient-\nName: {FullName}\nEmail: {Email}\nWeight: {Weight} kg\nHeight: {Height} m\nDisease: {Disease}\nBMI: {CalculateBMI():F2}\n");
    }

    public string GetSummary()
    {
        return $"Patient: {FullName}, Disease: {Disease}, BMI: {CalculateBMI():F2}";
    }
}