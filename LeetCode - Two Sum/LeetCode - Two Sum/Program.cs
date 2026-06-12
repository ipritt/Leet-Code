Console.WriteLine(TwoSum([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11));

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int current = nums[i];
        int x = target - current;
        if (map.ContainsKey(x))
        {
            return new int[] { map[x], i };
        }
        map[current] = i;
    }
    return null;
}