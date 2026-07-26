Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));


static int LengthOfLongestSubstring(string s)
{
    if (s.Length == 0) return 0;

    int left = 0;
    int count = 0;
    var map = new Dictionary<char, int>();

    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];

        if (map.TryGetValue(c, out int value))
        {
            left = Math.Max(value + 1, left);
        }

        map[c] = right;
        count = Math.Max(count, right - left + 1);
    }

    return count;
}