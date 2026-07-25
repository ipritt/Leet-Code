Console.WriteLine(IsSubsequence("", "ahbgdc"));

static bool IsSubsequence(string s, string t)
{
    if (s.Length == 0) return true;

    int i = 0;
    bool isSubsequence = false;

    for (int j = 0; j < t.Length; j++)
    {
        if (s[i] == t[j])
        {
            isSubsequence = true;
            i++;

            if (i == s.Length) break;
        }
        else
        {
            isSubsequence = false;
        }
    }

    if (i != s.Length) return false;

    return isSubsequence;
}
