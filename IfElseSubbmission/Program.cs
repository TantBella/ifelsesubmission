//1


Console.WriteLine("Hello! Please write a number.");
string evenOdd = Console.ReadLine();

int evenOddNumber = Convert.ToInt32(evenOdd);
if (evenOddNumber % 2 == 0)
{
    Console.WriteLine("You chose: " + evenOddNumber + ", which is an even number.");
}
else
{
    Console.WriteLine("You chose " + evenOdd + ", which is an odd number.");
}


//2