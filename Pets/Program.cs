namespace Pets
{
    internal static class Program
    {
        internal static void Main()
        {
            Pet animal1 = new Dog("Pluto", "German Shepard");
            Pet animal2 = new Cat("Garfield", "Bengal cat");
            Pet animal3 = new Fish("Magicarp");
            Pet animal4 = new Dog("Lassie", "Collie");
            Pet animal5 = new Cat("Puss in Boots", "British shorthair");

            List<Pet> pets =
            [
                animal1,
                animal2,
                animal3,
                animal4,
                animal5
            ];

            foreach (Pet p in pets)
            {
                switch (p)
                {
                    case Dog dog:
                        Console.WriteLine($"{dog.Name} - {dog.Description} ({dog.Breed}): {dog.Trick}, Sound: {dog.Sound}");
                        break;
                    case Cat cat:
                        Console.WriteLine($"{cat.Name} - {cat.Description} ({cat.Breed}): {cat.Trick}, Sound: {cat.Sound}");
                        break;
                    default:
                        Console.WriteLine($"{p.Name} - {p.Description}: {p.Trick}, Sound: {p.Sound}");
                        break;
                }
            }
        }
    }
}