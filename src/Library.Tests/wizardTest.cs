using System;
using Library;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(wizard))]
public class wizardTest
{

    [Test]
    public void METHOD()
    {
        wizard Alfred = new wizard("Alfred", 150);
        
        Assert.Equals("Alfred", Alfred.Name);
        Assert.Equals(150, Alfred.hp);
        
        
    }
}