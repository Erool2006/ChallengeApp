//Zadanie domowe #5

int number = 89653334;
string numberAsString = number.ToString();
char[] numbers = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char digit in numbers)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    else if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    {
        counter3++;
    }
    else if (digit == '4')
    {
        counter4++;
    }
    else if (digit == '5')
    {
        counter5++;
    }
    else if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    else if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }
}
Console.WriteLine("W liczbie " + number);
Console.WriteLine("znajduje się następująca ilość cyfr:");

Console.WriteLine("Dla 0 => " + counter0);
Console.WriteLine("Dla 1 => " + counter1);
Console.WriteLine("Dla 2 => " + counter2);
Console.WriteLine("Dla 3 => " + counter3);
Console.WriteLine("Dla 4 => " + counter4);
Console.WriteLine("Dla 5 => " + counter5);
Console.WriteLine("Dla 6 => " + counter6);
Console.WriteLine("Dla 7 => " + counter7);
Console.WriteLine("Dla 8 => " + counter8);
Console.WriteLine("Dla 9 => " + counter9);