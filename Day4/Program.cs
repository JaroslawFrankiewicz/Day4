string name = "Kuba";
string sex = "men";
int age = 10;

if (sex == "women" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "men" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}