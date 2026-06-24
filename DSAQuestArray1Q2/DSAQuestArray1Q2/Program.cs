Console.WriteLine(Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3));

int[] Shuffle(int[] nums, int n)
{
    List<int> result = [.. nums];

    for (int i = 1; i < nums.Length - 1; i += 2)
    {
        result.Insert(i, nums[i + (n - 1)]);
        result.RemoveAt(i + n--);
    }

    return [.. result];
}