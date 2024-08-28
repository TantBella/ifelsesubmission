//1 Even or Odd


//Console.WriteLine("Hello! Please write a number.");
//string evenOdd = Console.ReadLine();

//int evenOddNumber = Convert.ToInt32(evenOdd);
//if (evenOddNumber % 2 == 0)
//{
//    Console.WriteLine("You chose: " + evenOddNumber + ", which is an even number.");
//}
//else
//{
//    Console.WriteLine("You chose " + evenOdd + ", which is an odd number.");
//}


//2. Age bracket

Console.WriteLine("How old are you?");
string ageString = Console.ReadLine();
int ageNumber = Convert.ToInt32(ageString);
if (ageNumber < 13) {
    Console.WriteLine("You are a child.");
}
if (ageNumber >= 13 && ageNumber <= 19)
{
    Console.WriteLine("You're a teenager.");
}
else if (ageNumber > 19 )
{
    Console.WriteLine("You are an adult.");
}