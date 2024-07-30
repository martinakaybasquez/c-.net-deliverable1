Console.WriteLine("Welcome to Grand Circus' Snack Inventory!"); 
Console.WriteLine();

Console.WriteLine("How many sodas were sold today? We currently have 100 sodas in stock.");
int sodasSold = int.Parse(Console.ReadLine());
int sodasCurrent = 100 - sodasSold;

while (sodasSold > 100) 
{
    Console.WriteLine("IMPOSSIBLE! We only have 100 sodas in stock. Are you a magician?! Please, check again >:(");
    Console.WriteLine();
    Console.WriteLine("How many sodas were sold today? We currently have 100 sodas in stock."); 
    sodasSold = int.Parse(Console.ReadLine());
    sodasCurrent = 100 - sodasSold;
}
Console.WriteLine($"Thank you for the update. We now currently have: {sodasCurrent} sodas.");

Console.WriteLine();
Console.WriteLine("How many chips were told today? We currently have 40 chips in stock.");
int chipsSold = int.Parse(Console.ReadLine());
int chipsCurrent = 40 - chipsSold;
while (chipsSold > 40)
{
    Console.WriteLine("TELLER OF UNTRUTHS! We only have 40 chips in stock. You must really be a magician, huh?! Please, check again >:(");
    Console.WriteLine();
    Console.WriteLine("How many chips were sold today? We currently have 40 chips in stock."); 
    chipsSold = int.Parse(Console.ReadLine());
    chipsCurrent = 40 - chipsSold;
}
Console.WriteLine($"Thank you for the update. We now currently have: {chipsCurrent} chips.");

Console.WriteLine();
Console.WriteLine("How many candies were sold today? We currently have 60 candies in stock.");
int candiesSold = int.Parse(Console.ReadLine());
int candiesCurrent = 60 - candiesSold;
while (candiesSold > 60)
{
    Console.WriteLine("Okay, buddy, I'm worried. We really need to get you new glasses or brush up on your arithmetic because WE ONLY HAVE 60 CANDIES IN STOCK. Please, please, please check again.");
    Console.WriteLine();
    Console.WriteLine("How many candies were sold today? We currently have 60 candies in stock.");
    candiesSold = int.Parse(Console.ReadLine());
    candiesCurrent = 60 - candiesSold;
}
Console.WriteLine($"Thank you for the update. We now currently have: {candiesCurrent} candies.");

Console.WriteLine();
Console.WriteLine("Thank you for providing me with that information. Let's see if anything needs to be restocked...");
if (sodasCurrent <= 40)
{
    Console.WriteLine($"Sodas needs to be restocked. The current inventory is {sodasCurrent}.");
}
if (chipsCurrent <= 20)
{
    Console.WriteLine($"Chips need to be restocked. The current inventory is {chipsCurrent}.");
}
if (candiesCurrent <= 40)
{
    Console.WriteLine($"Candies need to be restocked. The current inventory is {candiesCurrent}.");
}
else
{
    Console.WriteLine("All is well...including your well of inventory--which is full :~)");
    Console.WriteLine("Have a wonderful day!");
}

