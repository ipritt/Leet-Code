Console.WriteLine(SearchInsert([1], 2));
Console.WriteLine(BinarySearchInsert([1], 2));

static int SearchInsert(int[] nums, int target)
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

static int BinarySearchInsert(int[] nums, int target)
{
    int low = 0;
    int high = nums.Length - 1;

    while (low <= high)
    {
        int mid = low + (high - low) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }

        if (nums[mid] < target)
        {
            low = mid + 1;
        }

        if (nums[mid] > target)
        {
            high = mid - 1;
        }
    }

    return low;
}
