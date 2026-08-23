Console.WriteLine(WordPattern("abba", "dog cat cat fish"));

static bool WordPattern(string pattern, string s)
{
    string[] sArray = s.Split(" ");

    if (sArray.Length != pattern.Length) return false;

    Dictionary<char, string> hashset = [];

    for (int i = 0; i < sArray.Length; i++)
    {
        if (hashset.TryGetValue(pattern[i], out string? value))
        {
            if (value != sArray[i])
            {
                return false;
            }
        }
        else
        {
            if (hashset.ContainsValue(sArray[i]))
            {
                return false;
            }

            hashset.Add(pattern[i], sArray[i]);
        }
    }

    return true;
}