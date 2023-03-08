class Program
{
    static void Main()
    {
        Cat cat = new Cat();

        while (true)
        {
            Console.WriteLine("Введите название фрукта (яблоко или апельсин):");
            string fruitName = Console.ReadLine();
            Fruit fruit = null;
            if (fruitName == "яблоко")
            {
                fruit = new Fruit("Яблоко", 2);
            }
            else if (fruitName == "апельсин")
            {
                fruit = new Fruit("Апельсин", 3);
            }
            else
            {
                Console.WriteLine("Фрукт не распознан. Попробуйте еще раз.");
                continue;
            }

            cat.Eat(fruit);
            cat.Update();
        }
    }
}