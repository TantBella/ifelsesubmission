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

//Console.WriteLine("How old are you?");
//string ageString = Console.ReadLine();
//int ageNumber = Convert.ToInt32(ageString);
//if (ageNumber < 13) {
//    Console.WriteLine("You are a child.");
//}
//if (ageNumber >= 13 && ageNumber <= 19)
//{
//    Console.WriteLine("You're a teenager.");
//}
//else if (ageNumber > 19 )
//{
//    Console.WriteLine("You are an adult.");
//}

//3. Grade system

Console.WriteLine("Please put in your test score.");
string testScoreString = Console.ReadLine();

int testScore = Convert.ToInt32(testScoreString);

if (testScore >= 90 && testScore <= 100)
{
    Console.WriteLine("You got an A! Good job!");
}
if (testScore >=80  && testScore <= 89)
{
    Console.WriteLine("You got a B. Well done.");
}
if (testScore >= 70 && testScore <= 79)
{
    Console.WriteLine("You got a C. Keep practicing!");
}
if (testScore >= 60 && testScore <= 69)
{
    Console.WriteLine("You got a D. Keep practicing!");
}
else if (testScore < 60)
{
    Console.WriteLine("You got a F.. ");
}

//4. Leap year checker