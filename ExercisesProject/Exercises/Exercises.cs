namespace Exercises
{
    public class Exercises
    {
        public static int MaxWidthRamp(int[] nums)
        {
            int maxRampWidth = 0;
            int width;

            // iterate through each start index for a ramp
            for (int i = 0; i < nums.Length && maxRampWidth < (nums.Length - i); i++)
            {
                width = 0;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] >= nums[i])
                    {
                        width = j - i;
                    }
                }
                maxRampWidth = maxRampWidth > width ? maxRampWidth : width;
            }

            return maxRampWidth;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }

            int number = 0;
            int complement = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                number = nums[i];
                complement = target - number;
                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }
            return new int[] { };
        }
    }
}
