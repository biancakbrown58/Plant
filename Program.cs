using System;
using System.Linq;

namespace Plant
{
  class Program
  {
    static void Main(string[] args)
    {
      var db = new PlantsContext();
      var isRunning = true;
      while (isRunning)
      {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("(Add) (View) (Remove) (Water)");
        Console.WriteLine("");
        var input = Console.ReadLine();
        if (input == "add")
        {
          Console.WriteLine("What species of plant?");
          var species = Console.ReadLine();

          Console.WriteLine("Where was it planted?");
          var locatedPlanted = Console.ReadLine();

          Console.WriteLine("How much sun does it need?");
          var lightNeeded = Console.ReadLine();

          Console.WriteLine("How much water does it need?");
          var waterNeeded = Console.ReadLine();

          var newPlant = new Plants
          {
            Species = species,
            LocatedPlanted = locatedPlanted,
            LightNeeded = lightNeeded,
            WaterNeeded = waterNeeded
          };
          db.Plant.Add(newPlant);
          db.SaveChanges();
        }
        else if (input == "view")
        {
          var plants = db.Plant.OrderBy(p => p.LocatedPlanted);
          foreach (var plant in plants)
          {
            Console.WriteLine($"{plant.Species} {plant.LocatedPlanted}");
          }
        }
        else if (input == "remove")
        {
          Console.WriteLine("");
          Console.WriteLine("What plant would you like to remove?");
          var plants = db.Plant.OrderBy(p => p.Species);
          foreach (var plant in plants)
          {
            Console.WriteLine($"{plant.Species}");
          }
          var userInput = Console.ReadLine();
          var plantToRemove = db.Plant.First(c => c.Species == userInput);
          db.Plant.Remove(plantToRemove);
          db.SaveChanges();
        }
        else if (input == "water")
        {
          Console.WriteLine("");
          Console.WriteLine("What plant would you like to water?");
          var plants = db.Plant.OrderBy(p => p.Species);
          foreach (var plant in plants)
          {
            Console.WriteLine($"{plant.Species}");
          }
          var userInput = Console.ReadLine();
          var plantToWater = db.Plant.First(c => c.Species == userInput);
          plantToWater.LastWateredDate = new DateTime();
          db.SaveChanges();
          Console.WriteLine($"This plant has been watered!");
        }
        else if (input == "needed")
        {
          Console.WriteLine("These are the plants you need to water");
          //   var plants = db.Plant.OrderBy(p => p.LastWateredDate);
          //   foreach (var plant in plants)
          //   {
          //     Console.WriteLine($"{plant.Species}");
          //   }
          var todayDate = DateTime.Today;
          var needToWater = db.Plant.Select(c => c.LastWateredDate != todayDate);
          Console.WriteLine($"{needToWater}");

        }
        else if (input == "quit")
        {
          isRunning = false;
        }



      }
    }
  }
}
