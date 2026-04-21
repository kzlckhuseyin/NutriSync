public class ClinicManager
{
    public List<Patient> patients = new List<Patient>();
    public List<Dietitian> dietitians = new List<Dietitian>();
     public void AddPatient(Patient p)
    {
        patients.Add(p);
    }

    public void AddDeititian(Dietitian d)
    {
        dietitians.Add(d);
    }

    public void ShowRiskyPatients()
    {
        Console.WriteLine("Risky Patients:");
        foreach (Patient patient in patients)
        {
            if(patient.CalculateBMI() > 25 || patient.Disease.ToLower() == "diabetes")
            {
                Console.WriteLine(patient.GetSummary());
            }
        }
    }
}