using System;
using System.Text.Json;

namespace ser_class
{
  class Program
  {
    static void Main(string[] args)
    {
      student artem = new student();
      artem.Name = "artem";
      Console.WriteLine(artem);
      string json = JsonSerializer.Serialize<student>(artem);
      Console.WriteLine(json);
      student restoredPerson = JsonSerializer.Deserialize<student>(json);
      Console.WriteLine(restoredPerson.ToString());

    }
  }
}
