using System.Linq;

Console.WriteLine(IsPalindrome(121));

bool IsPalindrome(int x)
{
    List<int> digits = new();
    List<int> reverseDigits = new();

    if (x < 0) return false;

    while (x > 0)
    {
        digits.Add(x % 10);
        reverseDigits.Add(x % 10);
        x /= 10;
    }

    digits.Reverse();
    return digits.SequenceEqual(reverseDigits);
}
