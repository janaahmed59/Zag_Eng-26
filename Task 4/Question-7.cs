public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();
        foreach(var num in nums)
        {
            numbers.Add(num);
        }
        if(nums.Length > numbers.Count) return true;
        else return false;
    }
}