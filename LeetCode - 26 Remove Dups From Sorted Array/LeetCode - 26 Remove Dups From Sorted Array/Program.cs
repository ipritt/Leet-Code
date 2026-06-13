int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

int k = RemoveDuplicates(nums);

Console.WriteLine(k + ", [" + string.Join(", ", nums.Take(k)) + "]");

int RemoveDuplicates(int[] nums)
{
    int i = 1;

    foreach (int n in nums)
    {
        if (nums[i - 1] != n)
        { 
            nums[i++] = n;
        }
    }

    return i;
}
