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

//Console.WriteLine("Please put in your test score.");
//string testScoreString = Console.ReadLine();

//int testScore = Convert.ToInt32(testScoreString);

//if (testScore >= 90 && testScore <= 100)
//{
//    Console.WriteLine("You got an A! Good job!");
//}
//if (testScore >=80  && testScore <= 89)
//{
//    Console.WriteLine("You got a B. Well done.");
//}
//if (testScore >= 70 && testScore <= 79)
//{
//    Console.WriteLine("You got a C. Keep practicing!");
//}
//if (testScore >= 60 && testScore <= 69)
//{
//    Console.WriteLine("You got a D. Keep practicing!");
//}
//else if (testScore < 60)
//{
//    Console.WriteLine("You got a F.. ");
//}

//4. Leap year checker 0=true 1 = false

//Console.WriteLine("Please write a random year. (Four numbers)");
//string randomYearString = Console.ReadLine();
//int randomYear = int.Parse(randomYearString);
//bool leapYear = (randomYear % 4 == 0 && randomYear % 100 != 0) || (randomYear % 400 == 0);

//if (leapYear) {
//    Console.WriteLine(randomYear + " is a leap year. ");
//}
//else
//{
//    Console.WriteLine(randomYear + " is not a leap year. ");
//}

//5. Maximum of three (biggest number?)

//Console.WriteLine("Give me three different numbers, please. One at a time.");
//string firstNumberString = Console.ReadLine();
//string secondNumberString = Console.ReadLine();
//string thirdNumberString = Console.ReadLine();

//int firstNumber = Convert.ToInt32(firstNumberString);
//int secondNumber = Convert.ToInt32(secondNumberString);
//int thirdNumber = Convert.ToInt32(thirdNumberString);

//if(firstNumber > secondNumber && firstNumber > thirdNumber ) {
//    Console.WriteLine("The first number you wrote, " + firstNumber + ", was the biggest one.");
//}
//if(secondNumber > thirdNumber && secondNumber  > firstNumber)
//{
//    Console.WriteLine("The second number you wrote, " + secondNumber + ", was the biggest one.");
//}
//else if(thirdNumber > secondNumber && thirdNumber > firstNumber)
//{
//    Console.WriteLine("The third number you wrote, " + thirdNumber + ", was the biggest one.");
// }

//6. Positive, negative or zero

//Console.WriteLine("Please put in any kind of number.");
//string inputNumberString = Console.ReadLine();
//int inputNumber = Convert.ToInt32(inputNumberString);

//if(inputNumber > 0)
//{
//    Console.WriteLine(inputNumber + " is positive. ");
//}
//if(inputNumber < 0)
//{
//    Console.WriteLine(inputNumber + " is negative. ");
//}
//else if(inputNumber == 0)
//{
//    Console.WriteLine("Your number is zero. ");
//}

//7. Discount system

Console.WriteLine("How much was your purchase?");
string purchaseString = Console.ReadLine();
int purchase = Convert.ToInt32(purchaseString);

if(purchase >= 1000)
{
    Console.WriteLine("Since your purchase was more than a $1000, I'll give you a discount.. You can pay "
        + (purchase * 0.9) + " instead. ");
}
else if(purchase < 1000)
{
    Console.WriteLine("Ok, have a nice day.");
}


//8. Weekdays 


