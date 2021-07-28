using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CodeChallenges
{
  public class AnimalShelter
  {
    public DataStructures.Queue<Cat> CatQueue { get; set; } = new();
    public DataStructures.Queue<Dog> DogQueue { get; set; } = new();
    public void AddAnimal(string name, string species)
    {
      if (species == "cat")
      {
        Cat newCat = new Cat(name);
        CatQueue.EnQueue(newCat);
      }
      else if (species == "dog")
      {
        Dog newDog = new Dog(name);
        DogQueue.EnQueue(newDog);
      }
      else
      {
        throw new Exception("Only cats or dogs please.");
      }
    }
    public Animal DeQueue(string preference)
    {
      if (preference == "cat")
      {
        return CatQueue.DeQueue();
      }
      else if (preference == "dog")
      {
        return DogQueue.DeQueue();
      }
      else
      {
        throw new Exception("Only cats or dogs please.");
      }
    }
  }
  public abstract class Animal
  {
    public abstract string Name { get; set; }
    public abstract string Species { get; set; }
  }
  public class Cat : Animal
  {
    public override string Name { get; set; }
    public override string Species { get; set; } = "cat";
    public Cat(string name)
    {
      Name = name;
    }
    public void Meow()
    {
      Console.WriteLine("Meow!");
    }
  }
  public class Dog : Animal
  {
    public override string Name { get; set; }
    public override string Species { get; set; } = "dog";
    public Dog(string name)
    {
      Name = name;
    }
    public void Bark()
    {
      Console.WriteLine("Woof!");
    }
  }
}
