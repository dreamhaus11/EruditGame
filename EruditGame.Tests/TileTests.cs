using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using EruditGame.Core;

[TestClass]
public class TileTests
{
    [TestMethod]
    public void Tile_DefaultValues()
    {
        var tile = new Tile();

        Assert.AreEqual('\0', tile.Letter);
        Assert.AreEqual(1, tile.Multiplier);
    }
}
