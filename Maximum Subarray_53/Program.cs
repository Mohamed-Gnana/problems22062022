
int[] nums = new int[] { 5, 6, 7 };

int localMax = nums[0], globalMax = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    if (localMax < 0)
    {
        localMax = 0;
    }
    localMax += nums[i];
    globalMax = globalMax > localMax ? globalMax : localMax;
}

Console.WriteLine(globalMax);