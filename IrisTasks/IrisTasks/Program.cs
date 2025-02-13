// See https://aka.ms/new-console-template for more information

using IrisTasks;

var balancedBrackets = new BalancedBrackets();
var testExpressionOne = "[()]{}{[()()]()}";
var testExpressionTwo = "[(])";

Console.WriteLine($"Result of test epression one is {balancedBrackets.IsBalanced(testExpressionOne)}");
Console.WriteLine($"Result of test epression two is {balancedBrackets.IsBalanced(testExpressionTwo)}");
