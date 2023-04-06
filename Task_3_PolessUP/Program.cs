internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ввод: ");
        int[] nums = new int[] { 1, 2, 3, 4 };
        int target = 5;
        Array.Sort(nums);
        Console.WriteLine("[" + string.Join(",", nums) + "]");
        Console.WriteLine(target);
        Console.WriteLine("Вывод: ");
        Console.WriteLine(FindIndexElement(nums, target));
        Console.ReadLine();
    }

    static int FindIndexElement(int[] nums, int target)
    {
        if (nums.Contains(target))
        {
             return Array.IndexOf(nums, target);
        }
        else
        {
             return FindIndexIfElementMissing(nums, target);
        }
    }

    static int FindIndexIfElementMissing(int[] nums, int target)
    {
        for (int index = 0; index < nums.Length - 1; index++)
        {
            if (nums[index] < target && nums[index + 1] > target)
            {
                return index + 1;
            }
        }
        if (nums[0] > target)
        {
            return 0;
        }
        return nums.Length;
    }
}