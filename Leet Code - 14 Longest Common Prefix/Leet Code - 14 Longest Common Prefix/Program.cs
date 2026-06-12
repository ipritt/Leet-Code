Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));


string LongestCommonPrefix(string[] strs)
{
    int shortestStringLength = strs.OrderBy(x => x.Length).First().Length;
    string resultString = string.Empty;
    bool isMatch = false;

    for (int i = 0; i < shortestStringLength; i++)
    {
        char currentCharBeingChecked = strs[0][i];

        for (int j = 0; j < strs.Length; j++)
        {
            if (!(strs[j][i] == currentCharBeingChecked))
            {
                isMatch = false;
                break;
            }
            else
            {
                isMatch = true;
            }
        }
        
        if(isMatch)
        {
            resultString += currentCharBeingChecked;
        }
        else
        {
            break;
        }
    }

    return resultString;
}
