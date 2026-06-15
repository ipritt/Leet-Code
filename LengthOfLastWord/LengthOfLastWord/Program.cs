Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));

int LengthOfLastWord(string s)
{
    int index = 0;
    string[] split = s.Split(" ");

    for (int i = split.Length - 1; i >= 0; i--)
    {
        if (split[i] != string.Empty)
        {
            return split[i].Length;
        }
    }
    return index;
}
