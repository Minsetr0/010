Random rand = new Random();
int minRandomNumber = -50;
int maxRandomNumber = 501;
int randomNumber = rand.Next(minRandomNumber, maxRandomNumber);
int numberToDegree = 2;
int degree = 1;
int numberToWork = numberToDegree;

if (randomNumber < 1)
{
    degree = 0;
    numberToDegree = 1;
    Console.WriteLine("Число " + numberToDegree + " в степени " + degree + " будет больше, чем " + randomNumber + ".");
}
else
{
    while (numberToWork < randomNumber)
    {
        degree++;
        numberToWork *= numberToDegree;
    }
}
Console.WriteLine($"Число {randomNumber} меньше, чем {numberToDegree} в степени {degree}.");