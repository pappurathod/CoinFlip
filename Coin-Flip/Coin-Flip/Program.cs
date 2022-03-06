// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int Coin_Head = 1; //constant
Random random = new Random();
int coinCheck = random.Next(0, 2);
if (coinCheck == Coin_Head)
{
    Console.WriteLine("Coin is Head");
}
else
{
    Console.WriteLine("Coin is Tail");
}