using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EruditGame.Core;

[TestClass]
public class BoardTests
{
    [TestMethod]
    public void PlaceLetter_SetsLetter()
    {
        var board = new Board(10);

        board.PlaceLetter(0, 0, 'А');

        Assert.AreEqual('А', board.GetLetter(0, 0));
    }

    [TestMethod]
    public void GetMultiplier_DefaultIsOne()
    {
        var board = new Board(10);

        Assert.AreEqual(1, board.GetMultiplier(2, 2));
    }

    [TestMethod]
    public void GetMultiplier_BonusCell()
    {
        var board = new Board(10);

        int mult = board.GetMultiplier(0, 4);

        Assert.IsTrue(mult == 2 || mult == 3);
    }
}
