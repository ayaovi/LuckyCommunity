using System;
using Xunit;
using LuckyCommunity;

namespace LuckyCommunity.Tests
{
  public class LocationTests
  {
    private readonly Location _location = new Location
    {
      x = 200,
      y = 300
    };

    [Fact]
    public void LocationX()
    {
      Assert.Equal(200, _location.x);
    }

    [Fact]
    public void LocationY()
    {
      Assert.Equal(300, _location.y);
    }

    [Fact]
    public void LocationEquality()
    {
      var otherLocation = new Location 
      {
        x = 200,
        y = 300
      };

      Assert.True(_location.Equals(otherLocation));
    }
  }
}