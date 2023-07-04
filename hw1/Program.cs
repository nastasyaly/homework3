
int Random = new Random().Next(10000,100000);
int Number1 = Random / 10000;
int Number2 = Random % 10000;
int Number4 = Random % 100;
int Number5 = Random % 10;
if (Number1 == Number5 || Number2 == Number4)
{
    Console.WriteLine($"число {Random} является палиндромом");
}
else 
{
    Console.WriteLine($"число {Random} не является палиндромом");
}
