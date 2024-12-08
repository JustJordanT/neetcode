//var result = Solution.IsAnagram("racecar", "carrace");
Console.WriteLine(Solution.IsAnagram("jar", "jam"));

public static class Solution
{
    public static bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> numsDictionary = new();

        // Add counts of characters from string s
        foreach (var letterS in s)
        {
            if (numsDictionary.ContainsKey(letterS))
            {
                numsDictionary[letterS] += 1;
            }
            else
            {
                numsDictionary.Add(letterS, 1);
            }
        }

        // Subtract counts of characters from string t
        foreach (var letterT in t)
        {
            if (numsDictionary.ContainsKey(letterT))
            {
                numsDictionary[letterT] -= 1;
            }
            else
            {
                numsDictionary.Add(letterT, -1);
            }
        }

        // Check if all counts are zero
        foreach (var value in numsDictionary.Values)
        {
            if (value != 0)
            {
                return false;
            }
        }

        return true;
    }
}

