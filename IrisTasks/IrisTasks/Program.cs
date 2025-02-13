// See https://aka.ms/new-console-template for more information

using IrisTasks;

const string BALANCED = "Balanced";
const string NOT_BALANCED = "Not Balanced";

var balancedBrackets = new BalancedBrackets();
var testExpressionOne = "[()]{}{[()()]()}";
var testExpressionTwo = "[(])";

Console.WriteLine(balancedBrackets.IsBalanced(testExpressionOne) ? BALANCED : NOT_BALANCED);
Console.WriteLine(balancedBrackets.IsBalanced(testExpressionTwo) ? BALANCED : NOT_BALANCED);
