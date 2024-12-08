var result = Solution.HasDuplicate([1, 2, 3, 1]); // true

Console.WriteLine(result);

public static class Solution
{
    public static bool HasDuplicateLinq(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        return nums.Any(num => !set.Add(num));
    }

    public static bool HasDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (var num in nums)
        {
            if (!set.Add(num))
            {
                return true;
            }
        }
        return false;
    }
}