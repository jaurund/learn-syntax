using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

[TestFixture]
public class KataTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(Kata.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" }), Is.EqualTo(new object[] { "Hello", "Hello Again" }));
        Assert.That(Kata.RemoveEveryOther(new object[] { new object[] { 1, 2 } }), Is.EqualTo(new object[] { new object[] { 1, 2 } }));
        Assert.That(Kata.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), Is.EqualTo(new object[] { 1, 3, 5, 7, 9 }));
        Assert.That(Kata.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } }), Is.EqualTo(new object[] { new object[] { "Goodbye" } }));
        Assert.That(Kata.RemoveEveryOther(new object[] { }), Is.EqualTo(new object[] { }));
    }
}