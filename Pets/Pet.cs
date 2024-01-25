namespace Pets
{
    internal abstract class Pet(string name, string description, string trick, string sound)
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string Trick { get; set; } = trick;
        public string Sound { get; set; } = sound;
    }

    internal class Dog(string name, string breed) : Pet(name, "Dog", "Lie down", "Woff")
    {
        public string Breed { get; set; } = breed;
    }

    internal class Cat(string name, string breed) : Pet(name, "Cat", "Cuddle", "Purr")
    {
        public string Breed { get; set; } = breed;
    }

    internal class Fish(string name) : Pet(name, "Fish", "Splash", "Gulp");
}