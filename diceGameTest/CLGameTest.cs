using System.Collections.Generic;
using System.Linq;

using Xunit;
using DiceGameNamespace;
using CLGameNamespace;
using DiceNamespace;
namespace diceGameTest;


public class CLGameTest
{
    public CLGame TestGame;
    public static Dice N;
    [Fact]
    public void DiceTest()
    {
        N = new Dice();
        Assert.Equal(6, N.Sides);
        N = new Dice(10);
        Assert.Equal(10, N.Sides);
    }
    // testing get total and average
    [Theory]
    [InlineData(4.50, new int[] { 2, 7, 3, 11, 2, 2 })]
    [InlineData(11.80, new int[] { 18, 4, 6, 12, 19 })]
    [InlineData(5, new int[] { 5 })]
    [InlineData(0, new int[] { })]
    public void AverageTest(double ExpectedAverage, int[] Values)
    {
        SetupGame();
        TestGame.Results = MakeArrayIntoList(Values);
        double Average = TestGame.GetAverage();
        Assert.Equal(ExpectedAverage, Average);
    }
    [Theory]
    [InlineData(27, new int[] { 2, 7, 3, 11, 2, 2 })]
    [InlineData(59, new int[] { 18, 4, 6, 12, 19 })]
    [InlineData(5, new int[] { 5 })]
    [InlineData(0, new int[] { })]
    public void TotalTest(int ExpectedTotal, int[] Values)
    {
        SetupGame();
        TestGame.Results = MakeArrayIntoList(Values);
        int Total = TestGame.GetTotal();
        Assert.Equal(ExpectedTotal, Total);
    }
    public void SetupGame()
    {
        TestGame = new CLGame();
    }
    public List<int> MakeArrayIntoList(int[] arr)
    {
        return arr.ToList();
    }
}