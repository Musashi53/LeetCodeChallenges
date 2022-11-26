namespace LeetCodeChallenges.Easy
{
    public class ConcatenationOfArray
    {
        public static int[] Solution(int[] nums)
        {
            var res = new int[nums.Length + nums.Length];
            nums.CopyTo(res, 0);
            nums.CopyTo(res, nums.Length);

            return res;
        }
    }
}