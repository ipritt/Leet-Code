
int[] results = Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);

foreach(int value in results)
{
    Console.WriteLine(value);
}


static int[] Merge(int[] nums1, int m, int[] nums2, int n)
{
    int x = m - 1;
    int y = n - 1;
    int z = m + n - 1;

    while(y >= 0)
    {
        if (x >= 0 && nums1[x] > nums2[y])
        {
            nums1[z--] = nums1[x--];
        }
        else
        {
            nums1[z--] = nums2[y--];
        }
    }

    return nums1;
}