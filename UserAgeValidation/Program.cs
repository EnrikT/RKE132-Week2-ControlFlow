// See https://aka.ms/new-console-template for more information
//Rakendus küsib kasutajal sisestada oma vanuse
//Kui kasutaja vanus on alla 13, siis kirjutame "You are too young to use IG"
//else "Welcome to IG"

Console.WriteLine("Enter your age");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if(userAgeNum >=13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
else
{
    Console.WriteLine("You're too young to use Instagram");
}
}
else
{
    Console.WriteLine("Couldn't read your age.");
}

//int userAge = Int32.Parse(Console.ReadLine());



//if (userAge >=13)
//{
//    Console.WriteLine("Welcome to Instagram!");
//}
//else
//{
//    Console.WriteLine("You are too young to use Instagram.");
//}