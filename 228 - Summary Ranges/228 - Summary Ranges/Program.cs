Console.WriteLine(string.Join(", ", SummaryRanges([0, 1, 2, 4, 5, 7])));

static IList<string> SummaryRanges(int[] nums)
{
    if (nums.Length == 0) return [];

    List<string> result = [];
    int valuePointer = nums[0];
    int counter = 1;
    string valueString = valuePointer.ToString();

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == valuePointer + counter++)
        {
            valueString = $"{valuePointer}->{nums[i]}";
        }
        else
        {
            valuePointer = nums[i];
            result.Add(valueString);
            valueString = valuePointer.ToString();
            counter = 1;
        }
    }

    result.Add(valueString);
    return result;
}
