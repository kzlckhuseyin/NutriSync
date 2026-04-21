using System.Xml.Serialization;

Console.WriteLine("-- Welcome to NutriSync Clinic Management System --\n");

int choice;
do
{
    Console.Write("1- Add Patient\n2- Add Dietitian\n3- Show Risky Patients\n4- Exit\nChoose an option: ");
    choice = int.Parse(Console.ReadLine() ?? "0");
    
}while(choice != 4);

