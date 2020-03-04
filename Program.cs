using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      string[] samsHobbies = new string[] {"hobbyx", "hobbyy", "hobbyz"};
      sam.SetHobbies(samsHobbies);
      var test = sam.ViewProfile();
      Console.WriteLine(test);
        
    
    }
  }
}
