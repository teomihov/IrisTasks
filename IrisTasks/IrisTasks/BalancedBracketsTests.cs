namespace IrisTasks;

using Xunit;

public class BalancedBracketsTests
{
    private readonly BalancedBrackets balancedBrackets = new BalancedBrackets();

    [Theory]
    [InlineData("[()]{}{[()()]()}", true)]
    [InlineData("[(])", false)]
    [InlineData("{}[]()", true)]
    [InlineData("{[()]}", true)]
    [InlineData("{[(])}", false)]
    [InlineData("", true)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    [InlineData("[()]{}{[(this is ok)(test)]( )}", false)]
    public void IsBalanced_ShouldReturnExpectedResult(string expression, bool expected)
    {
        Assert.Equal(expected, balancedBrackets.IsBalanced(expression));
    }
}
