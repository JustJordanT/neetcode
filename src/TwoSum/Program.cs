
using System.Threading.Channels;

int[] result = Solution.TwoSum([2, 5, 5, 9], 10);

Console.WriteLine(string.Join(", ", result));

public static class Solution
{
    // Time Complexity: O(n^2)
    // Space Complexity: O(1)
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }

        return null;
    }


    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public int[] TwoSumHash(int[] nums, int target)
    {
        Dictionary<int, int> prevDictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (prevDictionary.ContainsKey(diff))
            {
                return new int[] { prevDictionary[diff], i };
            }
            prevDictionary[nums[i]] = i;
        }
        return null;
    }
}