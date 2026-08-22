Console.WriteLine(CanConstruct("aa", "aab"));

static bool CanConstruct(string ransomNote, string magazine)
{
    int[] counts = new int[26];

    foreach (char c in magazine)
    {
        // c - 'a' is like subtracting 1 because of 0 based index
        counts[c - 'a']++;
    }

    foreach (char c in ransomNote)
    {
        if (--counts[c - 'a'] < 0) return false;
    }

    return true;
}