int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
int value = 2;
int result = RemoveElement(nums, value);
Console.WriteLine(result + " [" + string.Join(", ", nums.Take(result)) + "]");

int RemoveElement(int[] nums, int val)
{
    int i = 0;

    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] != val)
        {
            nums[i++] = nums[j];
        }
    }

    return i;
}

