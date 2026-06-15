Console.WriteLine(SearchInsert([1], 2));

int SearchInsert(int[] nums, int target)
{
    int result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] < target)
        {
            result = i + 1;
        }
    }

    return result;
}
