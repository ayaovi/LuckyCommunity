using System;
using Xunit;
using LuckyCommunity;

namespace LuckyCommunity.Tests
{
  public class PesronTests
  {
    private readonly Person _person = new Person
    {
      Name = "Ayaovi",
      Age = 22,
      Position = new Location
      {
        x = 0,
        y = 0
      }
    };

    [Fact]
    public void PersonName()
    {
      Assert.Equal("Ayaovi", _person.Name);
    }

    [Fact]
    public void PersonAge()
    {
      Assert.Equal(22, _person.Age);
    }
  }
}
