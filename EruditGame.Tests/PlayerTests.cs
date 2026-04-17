using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EruditGame.Core;

[TestClass]
public class PlayerTests
{
    [TestMethod]
    public void AddScore_IncreasesScore()
    {
        var player = new Player("Test");

        player.AddScore(10);

        Assert.AreEqual(10, player.Score);
    }

    [TestMethod]
    public void FillLetters_AddsLetters()
    {
        var player = new Player("Test");
        var bag = new LetterBag();

        player.FillLetters(bag);

        Assert.IsTrue(player.Letters.Count > 0);
    }

    [TestMethod]
    public void ReplaceLetters_ReplacesAllLetters()
    {
        var player = new Player("Test");
        var bag = new LetterBag();

        player.FillLetters(bag);
        var oldCount = player.Letters.Count;

        player.ReplaceLetters(bag);

        Assert.AreEqual(7, player.Letters.Count);
    }
}

