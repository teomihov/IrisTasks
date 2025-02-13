// See https://aka.ms/new-console-template for more information

using IrisTasks;

FirstTask();

Console.WriteLine();

SecondTask();

static void FirstTask()
{
    const string BALANCED = "Balanced";
    const string NOT_BALANCED = "Not Balanced";

    var balancedBrackets = new BalancedBrackets();
    var testExpressionOne = "[()]{}{[()()]()}";
    var testExpressionTwo = "[(])";

    Console.WriteLine("First TASK:");

    Console.WriteLine($"Example: {testExpressionOne}");
    Console.Write("Result: ");
    Console.WriteLine(balancedBrackets.IsBalanced(testExpressionOne) ? BALANCED : NOT_BALANCED);

    Console.WriteLine($"Example: {testExpressionTwo}");
    Console.Write("Result: ");
    Console.WriteLine(balancedBrackets.IsBalanced(testExpressionTwo) ? BALANCED : NOT_BALANCED);
}

static void SecondTask()
{
    int[] singleNumberExampleOne = [2, 2, 1];
    int[] singleNumberExampleTwo = [4, 1, 2, 1, 2];
    int[] singleNumberExampleThree = [1];

    Console.WriteLine("Second TASK:");
    Console.WriteLine($"Example [{string.Join(", ", singleNumberExampleOne)}]");
    Console.WriteLine($"Result: { SingleNumber.FindViaXOR(singleNumberExampleOne)}");

    Console.WriteLine($"Example [{string.Join(", ", singleNumberExampleTwo)}]");
    Console.WriteLine($"Result: {SingleNumber.FindViaDictionary(singleNumberExampleTwo)}");

    Console.WriteLine($"Example [{string.Join(", ", singleNumberExampleThree)}]");
    Console.WriteLine($"Result: {SingleNumber.FindViaXOR(singleNumberExampleThree)}");
}