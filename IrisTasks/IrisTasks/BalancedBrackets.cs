namespace IrisTasks;

internal class BalancedBrackets
{
    // TODO: it is better this to be in a config file
    private readonly IDictionary<char, char> bracketPairs = new Dictionary<char, char>
    {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };
    private Stack<char> brackets = new Stack<char>();

    public bool IsBalanced(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException(nameof(input), "Input cannot be null or empty");
        }
        if (input.Length % 2 != 0)
        {
            return false;
        }

        foreach (var ch in input)
        {
            if (!bracketPairs.ContainsKey(ch) && !bracketPairs.Values.Contains(ch))
            {
                continue;
            }

            if (bracketPairs.Values.Contains(ch))
            {
                brackets.Push(ch);
                continue;
            }

            if (brackets.Count == 0 || brackets.Pop() != bracketPairs[ch])
            {
                return false;
            }
        }

        return brackets.Count == 0;
    }
}
