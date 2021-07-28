using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeChallenges;

namespace CodeChallengesTests
{
  public class ShelterTests
  {
    [Fact]
    public void CanAddCritters()
    {
      AnimalShelter testShelter = new();
      testShelter.AddAnimal("Yuna", "cat");
      testShelter.AddAnimal("Maggie", "dog");
      testShelter.AddAnimal("Primrose", "cat");
      testShelter.AddAnimal("Max", "dog");
      Assert.Equal("Max", testShelter.DogQueue.Front.Next.Value.Name);
      Assert.Equal("Yuna", testShelter.CatQueue.Front.Value.Name);
    }
    [Fact]
    public void CanAdoptCritters()
    {
      AnimalShelter testShelter = new();
      testShelter.AddAnimal("Yuna", "cat");
      testShelter.AddAnimal("Maggie", "dog");
      testShelter.AddAnimal("Primrose", "cat");
      testShelter.AddAnimal("Max", "dog");
      Animal testDog = testShelter.DeQueue("dog");
      Animal testCat = testShelter.DeQueue("cat");
      Assert.Equal("dog", testDog.Species);
      Assert.Equal("cat", testCat.Species);
    }
    [Fact]
    public void ReigningCatsAndDogs()
    {
      AnimalShelter testShelter = new();
      Assert.Throws<Exception>(() => testShelter.DeQueue("dog"));
      testShelter.AddAnimal("Yuna", "cat");
      testShelter.AddAnimal("Maggie", "dog");
      testShelter.AddAnimal("Primrose", "cat");
      testShelter.AddAnimal("Max", "dog");
      Assert.Throws<Exception>(() => testShelter.DeQueue("walrus"));
      Assert.Throws<Exception>(() => testShelter.AddAnimal("Candy Bar","Ferret"));
    }
  }
}
