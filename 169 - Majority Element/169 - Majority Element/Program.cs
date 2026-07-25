Console.WriteLine(MajorityElement([2, 2, 1, 1, 2]));

static int MajorityElement(int[] nums)
{
    int count = 0;
    int candidate = 0;

    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[candidate] == nums[j])
        {
            count++;
        }
        else
        {
            count--;
            if (count == 0) candidate = j + 1;
        }
    }

    return nums[candidate];
}