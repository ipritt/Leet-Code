Console.WriteLine(RemoveDuplicates([6, 5, 5]));


static int RemoveDuplicates(int[] nums)
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