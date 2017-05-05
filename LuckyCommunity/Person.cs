using System;

namespace LuckyCommunity
{
  public class Person
  {
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public Location Position { get; set; } = default(Location);
  }
}
