Console.WriteLine(IsHappy(19));

static int Next(int x)
{
    int sum = 0;

    while (x > 0)
    {
        int digit = x % 10;
        sum += digit * digit;
        x /= 10;
    }

    return sum;
}

static bool IsHappy(int n)
{
    if (n == 1) return true;

    int slow = n;
    int fast = n;

    // Floyd's cycle-finding algorithm (two-pointer)
    do
    {
        slow = Next(slow);
        fast = Next(Next(fast));
    }
    while (fast != 1 && slow != fast);

    return fast == 1;
}
