string[] testCases = new string[]
{
    "((",
    "()",
    "()[]{}",
    "(]",
    "([)]",
    "{[]}"
};

foreach(string testCase in testCases)
{
    Console.WriteLine(IsValid(testCase));
}

bool IsValid(string s)
{
    Stack<char> stack = new();
    foreach(char bracket in s)
    {
        if (bracket == '(' || bracket == '{' || bracket == '[')
        {
            stack.Push(bracket);
        }
        else
        {
            if (stack.Count == 0)
            {
                return false;
            }
            char top = stack.Pop();
            if ((bracket == ')' && top != '(') ||
                (bracket == '}' && top != '{') ||
                (bracket == ']' && top != '['))
            {
                return false;
            }
        }
    }

    if(stack.Count > 0 && (
       stack.Last() == '(' ||
       stack.Last() == '[' ||
       stack.Last() == '{'))
    {
        return false;
    }

    return true;
}
