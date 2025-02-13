namespace IrisTasks;

using Xunit;

public class BalancedBracketsTests
{
    private readonly BalancedBrackets balancedBrackets = new BalancedBrackets();

    [Theory]
    [InlineData("[()]{}{[()()]()}", true)]
    [InlineData("[(])", false)]
    [InlineData("{}[]()", true)]
    [InlineData("{[()]}([])()[]", true)]
    [InlineData("{[(])}", false)]
    [InlineData("(", false)]
    [InlineData(")", false)]
    public void IsBalanced_ShouldReturnExpectedResult(string expression, bool expected)
    {
        Assert.Equal(expected, balancedBrackets.IsBalanced(expression));
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void IsBalanced_IfInputIsNullOrEmpty_ShouldThrowAnError(string expression)
    {
        Assert.Throws<ArgumentNullException>(() => balancedBrackets.IsBalanced(expression));
    }
}
