
string[] name = {"Justin", "Ethan", "Victoria", "Ben", "Kyra", "Jack", "Ramses", "Clare", "Ramsey", "Ali", "Pedro", "Mellisa"};
string[] favoriteFood = {"Baja Blast", "Hot Wings", "Pho", "Crab legs", "Sushi", "Hot Wings", "Lasagna", "Cheesy Potatoes", "Dim Sum", "Indian", "Italian", "Pizza"};
string[] hometown = {"Westerville", "Bolivar", "Blacksburg", "Birmingham", "Hazel Park", "Trenton", "Wyoming", "Lake Orion", "Brooklyn", "Dearborn Heights", "Chicago", "Detroit"};

bool playAgain = true;
int student = 0;
int studentPosition = 0;
string option = "1";

while (playAgain)
{
    Console.Write("Welcome! Which student would you like to learn more about? Enter a number 1-12: ");
    student = int.Parse(Console.ReadLine());
    studentPosition = student - 1;

    // valid number input
    if (student <= 0 || student > 12)
    {
        Console.WriteLine("We dont have that many students. Only give a number in the range!" );
        continue;
    } 

    // loop to find name
    for (int i = 0; i < name.Length; i++)
    {
        if (studentPosition == i)
        {
            Console.WriteLine(name[i]);
        }
    }

    // food or hometwon selection + validation + extra options
    while (option != "")
    {
        Console.Write("What information do you want to see? Hometown, Favorite food, or the student roster? ");
        option = Console.ReadLine().ToLower().Trim();

        if (option.Contains("town"))
        {
            Console.WriteLine(hometown[studentPosition]);
            break;
        }
        else if (option.Contains("food"))
        {
            Console.WriteLine(favoriteFood[studentPosition]);
            break;
        } else if (option.Contains("student") || option.Contains("roster"))
        {
            foreach (string n in name)
            Console.WriteLine(n);
            break;
        }
        else
        {
            Console.WriteLine("We don't offer that information! Please enter a valid option.");
        }
    }

    // play again
    while (true)
    {
        Console.Write("Would you like to learn about another student? y/n ");
        string continueLearn = Console.ReadLine();

        if (continueLearn == "y") break;
        else if (continueLearn == "n")
        {
            playAgain = false;
            break;
        } else Console.WriteLine("Not a valid response.");
    }
}





























