
Console.WriteLine(FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));

int FindMaxConsecutiveOnes(int[] nums)
{
    int max = 0;
    int currentCount = 0;

    foreach(int num in nums)
    {
        currentCount = num == 1 ? currentCount + 1 : 0;

        if (currentCount > max)
        {
            max = currentCount;
        }
    }

    return max;
}