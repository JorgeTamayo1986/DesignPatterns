// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.FactoryMethod;

#region Singleton
Console.WriteLine(Singleton.Instance.IsCreate);
#endregion


#region Prototype
Animal animal = new Animal() { Leg= 4, Name="Oveja Dolly"};
Animal? animalClone = animal.Clone() as Animal;
animalClone.Leg = 6; 
#endregion

Console.WriteLine(animal.Leg);

#region FactoryMethod
Game game = Manager.GetGame(Manager.Familiar);
Console.WriteLine(game.GetGame());
#endregion


Console.ReadLine();