// Project1

const int RequiredAge = 14;
const int SimRequiredAge = 18;
const string AccessDeniedMessage = "Musisz miec 14 lat";
const string Wiad = "Zapraszamy!";
const string SimDeniedMessage = "Jestes za mlody zeby kupic karte SIM";

int age = 19;

if (age >= SimRequiredAge)
{
    Console.WriteLine(Wiad);
}
else if (age < RequiredAge)
{
    Console.WriteLine(AccessDeniedMessage);
}
else
{
    Console.WriteLine(SimDeniedMessage);
}
