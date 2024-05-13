/*Oppgave 1*/

int firstNumber = 5;
int secondNumber = 4;
bool sameNumber = false;
void IsNumber()
{
    if (firstNumber == secondNumber)
    {
        sameNumber = true;
        Console.WriteLine("This number is same!!!");
        Console.Beep();
    }
    else
    {
        sameNumber = false;
        Console.WriteLine("This number is NOT same!!!");
        Console.Beep();
    }
}

IsNumber();


/*Oppgave 2*/



int NumbersHunter()
{
    if (firstNumber == secondNumber)
    {
        return firstNumber * secondNumber;
    }
    else
    {
        return firstNumber + secondNumber;
    }
}

Console.WriteLine(NumbersHunter());


/*Oppgave 3*/
bool exactSum = false; 
bool ExactNumber()
{
    if (firstNumber + secondNumber == 30)
    {
       return exactSum = true;
    }
    else
    {
       return exactSum = false;
    }
}

Console.WriteLine(ExactNumber());