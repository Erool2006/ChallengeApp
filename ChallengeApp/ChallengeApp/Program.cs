// Zadanie domowe #4

var name = "Ewa";
int age = 33;
bool woman = true;

// Jeśli to jest kobieta
if (woman == true)
{
    // Jeśli Ewa
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (name == "Ewa" && age < 33)
    {
        Console.WriteLine("Ewa, wiek poniżej 33 lat");
    }
    if (name == "Ewa" && age > 33)
    {
        Console.WriteLine("Ewa, powyżej 33 lat");
    }

    // Jeśli nie Ewa
    if (name != "Ewa" && age < 33)
    {
        Console.WriteLine("Kobieta, poniżej 33 lat");
    }
    else if (name != "Ewa" && age >= 33)
    {
        Console.WriteLine("Kobieta, w wieku 33 lat lub powyżej");
    }
}

// Jeśli to nie jest kobieta   
if (woman == false)
{
    if (age < 18)
    {
        Console.WriteLine("Mężczyzna niepełnoletni");
    }
    else if (age >= 18)
    {
        Console.WriteLine("To jest jakiś stary dziad...");
    }
}