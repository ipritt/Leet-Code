
Console.WriteLine(GetConcatenation(new int[] { 1, 2, 1 }));


int[] GetConcatenation(int[] nums)
{
    List<int> ans = [];

    ans.InsertRange(0, nums);
    ans.InsertRange(nums.Length, nums);


    return [.. ans];
}