using EruditGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class LetterBagTests
{
    [TestMethod]
    public void GetRandomLetter_ReturnsLetter()
    {
        var bag = new LetterBag();

        char letter = bag.GetRandomLetter();

        Assert.IsTrue(letter != '\0');
    }
}
