using System.Collections.Immutable;

int[] result = FindErrorNums(new int[] { 37, 62, 43, 27, 12, 66, 36, 18, 39, 54, 61, 65, 47, 32, 23, 2, 46, 8, 4, 24, 29, 38, 63, 39, 25, 11, 45, 28, 44, 52, 15, 30, 21, 7, 57, 49, 1, 59, 58, 14, 9, 40, 3, 42, 56, 31, 20, 41, 22, 50, 13, 33, 6, 10, 16, 64, 53, 51, 19, 17, 48, 26, 34, 60, 35, 5 });

foreach(int num in result)
{
    Console.WriteLine(num);
}

static int[] FindErrorNums(int[] nums)
{
    int repeat = 0;
    int numsSum = 0;
    int sequenceSum = 0;
    HashSet<int> seen = [];

    for (int i = 0; i < nums.Length; i++)
    {
        numsSum += nums[i];
        sequenceSum += i + 1;

        if (!seen.Add(nums[i]))
        {
            repeat = nums[i];
        }
    }

    return [repeat, sequenceSum - (numsSum - repeat)];
}