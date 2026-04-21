Console.WriteLine("-- Welcome to NutriSync Clinic Management System --\n");
ClinicManager clinicManager = new ClinicManager();

int choice;

do
{
    Console.Write("1- Add Patient\n2- Add Dietitian\n3- Show Risky Patients\n4- Exit\nChoose an option: ");
    choice = int.Parse(Console.ReadLine() ?? "0");

    switch (choice)
    {
        case 1:
            AddPatient(clinicManager);
            break;

        case 2:
            AddDietitian(clinicManager);            
            break;

        case 3:
            clinicManager.ShowRiskyPatients();
            break;

        case 4:
            Console.WriteLine("Exiting the system. Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.\n");
            break;
    }
    
}while(choice != 4);

static void AddPatient(ClinicManager clinicManager)
{
    Console.Write("Enter patient's full name: ");
    string fullName = Console.ReadLine() ?? string.Empty;

    Console.Write("Enter patient's email: ");
    string email = Console.ReadLine() ?? string.Empty;

    Console.Write("Enter patient's weight (kg): ");
    double weight = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Enter patient's height (m): ");
    double height = double.Parse(Console.ReadLine() ?? "0");

    Console.Write("Enter patient's disease: ");
    string disease = Console.ReadLine() ?? string.Empty;

    Patient newPatient = new Patient(fullName, email, weight, height, disease);
    clinicManager.AddPatient(newPatient);
    Console.WriteLine("Patient added successfully!\n");
}

static void AddDietitian(ClinicManager clinicManager)
{
    Console.Write("Enter dietitian's full name: ");
    string fullName = Console.ReadLine() ?? string.Empty;

    Console.Write("Enter dietitian's email: ");
    string email = Console.ReadLine() ?? string.Empty;

    Console.Write("Enter dietitian's specialty: ");
    string specialty = Console.ReadLine() ?? string.Empty;

    Dietitian newDietitian = new Dietitian(fullName, email, specialty);
    clinicManager.AddDietitian(newDietitian);
    Console.WriteLine("Dietitian added successfully!\n");
}