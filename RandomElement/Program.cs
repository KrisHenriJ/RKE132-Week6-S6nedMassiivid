string[] snacks = { "sushi", "pizza", "burger", "fish" };
Random rnd = new Random();

int RandomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat{snacks[RandomIndex]}.");


