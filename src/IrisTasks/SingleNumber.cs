namespace IrisTasks;

internal class SingleNumber
{
    public static int FindViaXOR(int[] input)
    {
        var result = 0;
        foreach (var number in input)
        {
            result ^= number;
        }

        if (result == 0)
        {
            throw new InvalidOperationException("No single number found.");
        }

        return result;
    }

    public static int FindViaDictionary(int[] input)
    {
        var numCounts = new Dictionary<int, int>();

        foreach (var number in input)
        {
            if (numCounts.ContainsKey(number))
            {
                numCounts[number]++;
            }
            else
            {
                numCounts[number] = 1;
            }
        }

        foreach (var pair in numCounts)
        {
            if (pair.Value == 1)
            {
                return pair.Key;
            }
        }

        throw new InvalidOperationException("No single number found.");
    }
}
