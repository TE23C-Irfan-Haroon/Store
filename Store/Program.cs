Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

bool succes = false;
int ageNum = 0;

while (succes == false)
{
    Console.WriteLine("How old are you?");
    String age = Console.ReadLine();
    succes = int.TryParse(age, out ageNum);

    if (succes == false)
    {
        Console.WriteLine("WRITE A NUMBER DUMBASS!!!");
    }
    else if (ageNum < 18)
    {
        Console.WriteLine("You are too young!!!");
        Console.ReadLine();
        return;
    }
    else if (ageNum >= 18)
    {
        Console.WriteLine("Welcome to the SHOP");
        Console.ReadLine();
    }
}


int coins = 100;
String shopChoice = ("");
int shopChoicenum = 1;
Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

while (coins > 0)
{

    Console.WriteLine("Welcome to the Shop!");
    Console.WriteLine($"You have {coins} coins.");
    Console.WriteLine("1. Mostafa's Leg Piece - Extra Spicy - Only 19.99$");
    Console.WriteLine("2. Mostafa's Crispy Breast - Extra Parmesan - Only 29.99$");
    Console.WriteLine("3. Mostafa's Special - MYSTERY FLAVOUR - WARNING SHAPED LIKE BALLS - Only 69.99$");
    Console.WriteLine("4. Exit Shop");
    Console.WriteLine("Choose an option: 1, 2, 3, or 4");
    shopChoice = Console.ReadLine();

    int.TryParse(shopChoice, out shopChoicenum);
    if (shopChoicenum < 1 || shopChoicenum > 4)
    {
        Console.WriteLine("Please choose a valid option.");
    }

    if (shopChoicenum == 1)
    {
        if (coins >= 20)
        {
            coins -= 20;

        }
        else
        {
            Console.WriteLine("Not enough coins.");
        }
    }
    else if (shopChoicenum == 2)
    {
        if (coins >= 30)
        {
            coins -= 30;
            Console.WriteLine($"You have {coins}");
        }
        else
        {
            Console.WriteLine("Not enough coins.");
        }
    }
    else if (shopChoicenum == 3)
    {
        if (coins >= 70)
        {
            coins -= 70;
            Console.WriteLine($"You have {coins}");
        }
        else
        {
            Console.WriteLine("Not enough coins.");
        }
    }
    else if (shopChoicenum == 4)
    {

        break;
    }
    else if (coins <= 0)
    {
        Console.WriteLine("You have no coins left");
        Console.ReadLine();
    }
    shopChoice = Console.ReadLine();
    Console.Clear();
}

