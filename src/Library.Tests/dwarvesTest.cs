using Library;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(dwarves))]
public class dwarvesTest
{

    [Test]
    public void METHOD()
    {
        dwarves Franco = new dwarves("FranColapinto", 100);
        Assert.Equals("FranColapinto", Franco.Name);
        Assert.Equals(150, Franco.HealthPoints);
    }
}