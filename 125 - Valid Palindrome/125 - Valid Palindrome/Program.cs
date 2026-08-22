Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

static bool IsPalindrome(string s)
{
    // Remove non-alphanumeric chars
    char[] chars = new char[s.Length];
    int index = 0;

    foreach (char c in s)
    {
        if (char.IsLetterOrDigit(c))
        {
            chars[index++] = char.ToLower(c);
        }
    }

    string alphaNumericString = new(chars, 0, index);

    if (alphaNumericString.Length == 0 || alphaNumericString.Length == 1) return true;

    // Check if the string is a palindrome
    int rightIndex = alphaNumericString.Length - 1;
    bool isPalindrome = false;

    for (int leftIndex = 0; leftIndex < alphaNumericString.Length / 2; leftIndex++)
    {
        isPalindrome = alphaNumericString[leftIndex] == alphaNumericString[rightIndex];

        if (!isPalindrome) break;

        rightIndex--;
    }

    return isPalindrome;
}