using Xunit;

namespace IrisTasks;

public class SingleNumberTests
{
    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 1, 6, 3, 3, 2, 7, 8, 8, 7, 2 }, 6)]
    public void FindViaXOR_ShouldReturnExpectedResult(int[] input, int expected)
    {
        var result = SingleNumber.FindViaXOR(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 2, 2, 1 }, 1)]
    [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 1, 6, 3, 3, 2, 7, 8, 8, 7, 2 }, 6)]
    public void FindViaDictionary_ShouldReturnExpectedResult(int[] input, int expected)
    {
        var result = SingleNumber.FindViaDictionary(input);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FindViaXOR_NoSingleNumberFound_ShouldThrowAnError()
    {
        Assert.Throws<InvalidOperationException>(() => SingleNumber.FindViaXOR([1, 1, 2, 2]));
    }

    [Fact]
    public void FindViaDictionary_IfInputIsNullOrEmpty_ShouldThrowAnError()
    {
        Assert.Throws<InvalidOperationException>(() => SingleNumber.FindViaDictionary([1, 1, 2, 2]));
    }

    [Fact]
    public void FindViaXOR_IfInputIsEmptyArray_ShouldThrowAnError()
    {
        Assert.Throws<InvalidOperationException>(() => SingleNumber.FindViaXOR([]));
    }

    [Fact]
    public void FindViaDictionary_IfInputIsEmptyArray_ShouldThrowAnError()
    {
        Assert.Throws<InvalidOperationException>(() => SingleNumber.FindViaDictionary([]));
    }
}
