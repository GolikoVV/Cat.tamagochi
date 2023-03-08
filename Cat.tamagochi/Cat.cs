using System;

class Cat
{
    private int hunger;
    private int health;

    public Cat()
    {
        hunger = 0;
        health = 10;
    }

    public void Eat(Fruit fruit)
    {
        health += fruit.GetHealth();
        Console.WriteLine("Кошка съела " + fruit.GetName() + " и добавила " + fruit.GetHealth() + " здоровья.");
    }

    public void Meow()
    {
        Console.WriteLine("Мяу!");
    }

    public void Play()
    {
        health -= 2;
        Console.WriteLine("Кошка играет.");
    }

    public void Run()
    {
        health -= 3;
        Console.WriteLine("Кошка бегает.");
    }

    public void Update()
    {
        hunger++;
        if (hunger < 5)
        {
            Meow();
        }
        else if (hunger >= 5 && hunger < 10)
        {
            Play();
        }
        else if (hunger >= 10)
        {
            Console.WriteLine("Кошка умерла от голода.");
            Environment.Exit(0);
        }
    }
}

class Fruit
{
    private string name;
    private int health;

    public Fruit(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public string GetName()
    {
        return name;
    }

    public int GetHealth()
    {
        return health;
    }
}