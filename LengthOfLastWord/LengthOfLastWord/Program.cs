Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));

static int LengthOfLastWord(string s)
{
    string[] split = s.Split(" ");

    for (int i = split.Length - 1; i >= 0; i--)
    {
        if (split[i] != string.Empty)
        {
            return split[i].Length;
        }
    }
    return s.Length;
}
