Console.WriteLine(IsSubsequence("axc", "ahbxdc"));

static bool IsSubsequence(string s, string t)
{
    if (s.Length == 0) return true;

    int leftPointer = 0;

    for (int rightPointer = 0; rightPointer < t.Length; rightPointer++)
    {
        if (leftPointer >= s.Length) break;

        if (s[leftPointer] == t[rightPointer])
        {
            leftPointer++;
        }
    }

    if (leftPointer != s.Length) return false;

    return true;
}
