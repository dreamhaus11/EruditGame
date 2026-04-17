using EruditGame.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class LetterScoreTests
{
    [TestMethod]
    public void GetScore_ReturnsCorrectValue()
    {
        int score = LetterScore.GetScore('А');

        Assert.IsTrue(score > 0);
    }
}
