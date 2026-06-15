Console.WriteLine(StrStr("hello", "ll"));

int StrStr(string haystack, string needle)
{
    int index = -1;

    for (int i = 0; i <= haystack.Length - needle.Length; i++)
    {
        // input strings are guaranteed to be lower case, so don't
        // need string.Comparison as it has an impact on run time
        if (haystack[i..(i + needle.Length)].Equals(needle))
        {
            index = i;
            break;
        }
    }

    return index;
}
