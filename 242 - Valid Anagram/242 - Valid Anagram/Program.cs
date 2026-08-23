Console.WriteLine(IsAnagram("aacc", "ccac"));


static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;

    Dictionary<char, int> hashSet = [];

    for (int i = 0; i < s.Length; i++)
    {
        if (hashSet.TryGetValue(s[i], out int count))
        {
            hashSet[s[i]] = count + 1;
        }
        else
        {
            hashSet[s[i]] = 1;
        }
    }

    for (int i = 0; i < t.Length; i++)
    {
        if (hashSet.TryGetValue(t[i], out int value))
        {
            if (value <= 0) return false;

            hashSet[t[i]] = --value;
        }
        else
        {
            return false;
        }
    }

    return true;
}