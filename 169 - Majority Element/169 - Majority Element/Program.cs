Console.WriteLine(MajorityElement([2, 2, 1, 3, 1, 1, 4, 1, 1, 5, 1, 1, 6]));

static int MajorityElement(int[] nums)
{
    int count = 0;
    int candidate = 0;

    for(int i = 0; i < nums.Length; i++)
    {
        if (count == 0)
        {
            candidate = nums[i];
        }

        if (nums[i] == candidate)
            count++;
        else
            count--;
    }

    return candidate;
}