using System;

class Tamagotchi
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Hunger { get; set; }
    public int Fatigue { get; set; }
    public int ExcessFeed { get; set; }
    public int Happiness { get; set; }
    public Tamagotchi(string name)
    {
        Name = name;
        Health = 3;
        Hunger = 0;
        Fatigue = 0;
        ExcessFeed = 0;
        Happiness = 10;
    }

    public void PrintStats()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Health: " + Health);
        Console.WriteLine("Hunger: " + Hunger);
        Console.WriteLine("Fatigue: " + Fatigue);
        Console.WriteLine("Fatigue: " + Happiness);
    }

    public void Feed()
    {
        ExcessFeed++;
        
        if( Hunger < 10)
        {
            Hunger++;
        }

        if (ExcessFeed < 5)
        {
            Health--;
        }
    }

    public void Play()
    {
        Fatigue++;

        if (Fatigue > 5 & Hunger < 10)
        {
            Hunger++;
            Health--;
        }
    }

    public void Sleep()
    {
        Fatigue = 0;
        ExcessFeed=0;
        if (Health < 10)
        {
            Health++;
            Happiness--;
        }

        if (Hunger < 10)
        {
            Hunger++;
        }
    }
    public void Healing()
    {

        if (Health < 10)
        {
            Health++;
        }

        if (Hunger < 10)
        {
            Hunger++;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Tamagotchi";
        Console.WriteLine("Enter the name of your pet:");
        string name = Console.ReadLine();

        Tamagotchi pet = new Tamagotchi(name);

        while (pet.Health > 0)
        {
            
            pet.PrintStats();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Sleep");
            Console.WriteLine("4. Healing");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose an action: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                pet.Feed();
            }
            else if (choice == 2)
            {
                pet.Play();
            }
            else if (choice == 3)
            {
                pet.Sleep();
            }
            else if(choice == 4)
            {
                pet.Healing();
            }
            Console.Clear();
        }

        Console.WriteLine("Your pet is sick and the game is over.");
    }
}
