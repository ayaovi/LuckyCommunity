using System;

namespace LuckyCommunity
{
  public class Location
  {
    public double x { get; set; } = default(double);
    public double y { get; set; } = default(double);

    public bool Equals(Location otherLocation)
    {
      if ((object)otherLocation == null)
      {
        return false;
      }

      return (x == otherLocation.x) && (y == otherLocation.y);
    }
  }
}