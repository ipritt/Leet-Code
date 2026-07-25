Console.WriteLine(IsPalindrome(",; W;:GlG:;l ;,"));

bool IsPalindrome(string s)
{
    string alphaNumericString = RemoveNonAlphanumericCharacters(s);

    if (alphaNumericString.Length == 0 || alphaNumericString.Length == 1) return true;

    int leftIndex = 0;
    int rightIndex = alphaNumericString.Length - 1;
    bool isPalindrome = false;

    for (int i = 0; i < alphaNumericString.Length / 2; i++)
    {
        isPalindrome = alphaNumericString[leftIndex].ToString()
            .Equals(alphaNumericString[rightIndex].ToString(), StringComparison.CurrentCultureIgnoreCase);

        if (!isPalindrome) break;

        leftIndex++;
        rightIndex--;
    }

    return isPalindrome;
}

string RemoveNonAlphanumericCharacters(string str)
{
    char[] chars = new char[str.Length];
    int index = 0;

    foreach (char c in str)
    {
        if (char.IsLetterOrDigit(c))
        {
            chars[index++] = c;
        }    
    }

    return new string(chars, 0, index);
}