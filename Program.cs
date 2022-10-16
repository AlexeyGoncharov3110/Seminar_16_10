


int randomNumber = GetRandomNumber(10, 100);

Console.WriteLine(randomNumber);

int max = randomNumber % 10;
randomNumber = randomNumber / 10;

while(randomNumber>0)
{
int LastNumber = randomNumber % 10;
if(LastNumber>max)
{
max = LastNumber;
}
randomNumber = randomNumber /10;
}

Console.WriteLine(max);


int GetRandomNumber(int minValue, int maxValue)
{
    Random random = new Random();
    int randomNumber = random.Next(minValue,maxValue);
    return randomNumber;
}