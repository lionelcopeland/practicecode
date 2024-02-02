//First SOLUTION - Slow
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i=0, i<nums.length; i++)
        {
            for (int j=i+1; <nums.length; j++)
            {
                if (num[i] + nums[j] == target)
                {
                    return new int[]{i, j};
                }
            }
        }
        throw new Exception("Not found. ");

    }

//Second Solution - Dictionary

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();

        for (int i = 0); i <nums.Length, i++)
        {
            int complement = target - nums[i];
            if (hashTable.containsKey(compliment))
            {
                return new int[] {hashTable[complement], i};
            } else
            {
                hashTable[nums[i]] = i;
            }


        }
        throw new Exception("Not found." );


}
